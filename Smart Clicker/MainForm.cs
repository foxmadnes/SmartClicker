using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Smart_Clicker
{
    public partial class MainForm : Form
    {
        private const int WM_WINDOWPOSCHANGING = 0x0046;
        private const int WM_GETMINMAXINFO = 0x0024;

        protected override void WndProc(ref Message m)
        {
            if (resizeForm && m.Msg == WM_WINDOWPOSCHANGING)
            {
                WindowPos windowPos = (WindowPos)m.GetLParam(typeof(WindowPos));

                // Make changes to windowPos
                windowPos.width = 90;
                resizeForm = false;

                // Then marshal the changes back to the message
                Marshal.StructureToPtr(windowPos, m.LParam, true);
            }

            base.WndProc(ref m);

            // Make changes to WM_GETMINMAXINFO after it has been handled by the underlying
            // WndProc, so we only need to repopulate the minimum size constraints
            if (m.Msg == WM_GETMINMAXINFO)
            {
                MinMaxInfo minMaxInfo = (MinMaxInfo)m.GetLParam(typeof(MinMaxInfo));
                minMaxInfo.ptMinTrackSize.x = this.MinimumSize.Width;
                minMaxInfo.ptMinTrackSize.y = this.MinimumSize.Height;
                Marshal.StructureToPtr(minMaxInfo, m.LParam, true);
            }
        }

        struct WindowPos
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int width;
            public int height;
            public uint flags;
        }

        struct POINT
        {
            public int x;
            public int y;
        }

        struct MinMaxInfo
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }


        private ClickStatus clickStatus;
        private CustomizationParameters customParams;
        private PictureBox[] buttons;
        private Dictionary<PictureBox, ProgramMode> ModeMapping;
        private PictureBox currentMousePictureBox;
        private bool inBox = false;
        private bool resizeForm = false;

        public MainForm(ClickStatus status, CustomizationParameters customParams)
        {
            InitializeComponent();
            this.clickStatus = status;
            this.customParams = customParams;

            this.buttons = new PictureBox[] {leftClick, rightClick , doubleClick, contextClick, clickAndDrag, sleepClick};
            foreach (PictureBox mode in buttons)
            {
                mode.MouseHover += new EventHandler(pictureBox_MouseHover);
            }

            ModeMapping = new Dictionary<PictureBox, ProgramMode>() 
            {
                {leftClick, ProgramMode.leftClick},
                {rightClick, ProgramMode.rightClick},
                {doubleClick, ProgramMode.doubleClick},
                {contextClick, ProgramMode.leftClick},
                {clickAndDrag, ProgramMode.clickAndDrag},
                {sleepClick, ProgramMode.sleepClick}
            };

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = String.Empty;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Width - (this.Bounds.Width + 10);
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Bounds.Height / 2);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            //Temporary solution to some problems
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            setPictureBoxSelect(contextClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void OnLoad(EventArgs args)
        {
            Application.Idle += new EventHandler(OnLoaded);
        }

        public void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(OnLoaded);
            resizeForm = true;
            this.Width = 300;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            setPictureBoxHighlighted(current);
            this.inBox = true;
            this.currentMousePictureBox = current;

            startTimer(current);
            current.MouseLeave += new EventHandler(onPictureBoxLeave);
        }

        private void startTimer(PictureBox mode)
        {
            Timer mouseOver = new Timer();
            mouseOver.Tick += (sender, e) => modeSelected(sender, mode);
            mouseOver.Interval = 1000; // in miliseconds
            mouseOver.Start();
        }

        private void modeSelected(object sender, PictureBox mode)
        {
            Timer mouseOver = (Timer)sender;
            mouseOver.Stop();
            mouseOver.Dispose();
            if (this.inBox && (this.currentMousePictureBox == mode))
            {
                this.clickStatus.setCurrentMode(ModeMapping[mode]);
            }
            setPictureBoxSelect(mode);
            this.inBox = false;
            this.currentMousePictureBox = null;
        }

        private void onPictureBoxLeave(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            if (this.currentMousePictureBox == current)
            {
                this.inBox = false;
                this.currentMousePictureBox = null;
            }
            current.MouseLeave -= new EventHandler(onPictureBoxLeave);
        }

        private void setPictureBoxHighlighted(PictureBox toSet)
        {
            if (toSet.BackColor == Color.Red)
            {
                return;
            }
            foreach (PictureBox p in buttons)
            {
                if (p.BackColor != Color.Red)
                {
                    p.BackColor = Color.White;
                }
            }
            toSet.BackColor = Color.Yellow;
        }

        private void setPictureBoxSelect(PictureBox toSet)
        {
            foreach (PictureBox p in buttons)
            {
                p.BackColor = Color.White;
            }
            toSet.BackColor = Color.Red;
        }

        public void setClickDefault()
        {
            setPictureBoxSelect(contextClick);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Smart Clicker", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            //Grab the current width and height of the form for saving
            customParams.layoutValues.startWidth = this.DisplayRectangle.Width;
            customParams.layoutValues.startHeight = this.DisplayRectangle.Height;
            // Save object to XML before you close
            //customParams.saveCustomParams();
            new XmlMethods().saveCustomParams(customParams);
        }

        // This function is never getting called by the APIs.
        // TODO: Investigate
        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
        }

        public void CatchFatalException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Application.Restart();
        }

        private void customize_Click(object sender, EventArgs e)
        {
            // launch custom UI
            CustomUI customWindow = new CustomUI(customParams, this);
            customWindow.Show();


        }
 
    }
}
