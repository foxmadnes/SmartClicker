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
            if (formLoaded && m.Msg == WM_WINDOWPOSCHANGING)
            {
                WindowPos windowPos = (WindowPos)m.GetLParam(typeof(WindowPos));

                // Make changes to windowPos
                windowPos.width = 90;
                formLoaded = false;

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
        private PictureBox[] buttons;
        private bool formLoaded = false;

        public MainForm(ClickStatus status)
        {
            InitializeComponent();
            this.clickStatus = status;
            this.buttons = new PictureBox[] { leftClick, rightClick , doubleClick, contextClick, clickAndDrag, sleepClick};
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = String.Empty;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Width - (this.Bounds.Width + 10);
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Bounds.Height / 2);
            setPictureBoxColors(contextClick);
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void OnLoad(EventArgs args)
        {
            Application.Idle += new EventHandler(OnLoaded);
        }

        public void OnLoaded(object sender, EventArgs args)
        {
            Application.Idle -= new EventHandler(OnLoaded);
            formLoaded = true;
            this.Width = 300;
        }

        private void leftClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(leftClick);
            this.clickStatus.setStatus(statusEnum.leftClick);
            this.clickStatus.setContext(false);
        }

        private void rightClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(rightClick);
            this.clickStatus.setStatus(statusEnum.rightClick);
        }

        private void doubleClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(doubleClick);
            this.clickStatus.setStatus(statusEnum.doubleClick);
        }

        private void clickAndDrag_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(clickAndDrag);
            this.clickStatus.setStatus(statusEnum.leftDown);
        }

        private void leftClick_Click(object sender, EventArgs e)
        {
            setPictureBoxColors(leftClick);
            this.clickStatus.setStatus(statusEnum.leftClick);
            this.clickStatus.setContext(false);
        }

        private void sleepClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(sleepClick);
            this.clickStatus.setStatus(statusEnum.sleepClick);
            this.clickStatus.setContext(false);
        }

        private void contextClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(contextClick);
            this.clickStatus.setStatus(statusEnum.leftClick);
            this.clickStatus.setContext(true);
        }

        private void sleepClick_Click(object sender, EventArgs e)
        {
            setPictureBoxColors(sleepClick);
        }

        private void setPictureBoxColors(PictureBox toSet)
        {
            foreach (PictureBox p in buttons)
            {
                p.BackColor = Color.White;
            }

            toSet.BackColor = Color.Red;
        }

        public void setClickDefault()
        {
            if (this.clickStatus.getContext())
            {
                setPictureBoxColors(contextClick);
                return;
            }   
            setPictureBoxColors(leftClick);
        }
    }
}
