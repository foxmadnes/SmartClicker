using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Smart_Clicker
{
    public partial class MainForm : Form
    {
        private ClickStatus clickStatus;
        private CustomizationParameters customParams;
        public ClickDetector detector;
        public Fetcher fetcher;
        private PictureBox[] buttons;
        private Dictionary<PictureBox, ProgramMode> ModeMapping;
        private Dictionary<ProgramMode, PictureBox> inverseModeMapping;
        private PictureBox currentMousePictureBox;
        private NotifyIcon trayIcon;

        public MainForm(ClickStatus status, CustomizationParameters customParams)
        {
            fetcher = new Fetcher(this);

            fetcher.Show();

            InitializeComponent();
            this.ShowInTaskbar = false;
            this.clickStatus = status;
            this.customParams = customParams;

            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            this.trayIcon = new NotifyIcon();
            trayIcon.Text = "SmartClicker";
            trayIcon.Icon = this.Icon;
            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            //buttons1 = new PictureBox[] { sleepClick, contextClick, leftClick, rightClick, doubleClick, clickAndDrag, CustomForm, help };
            this.buttons = new PictureBox[] {sleepClick, contextClick, leftClick, rightClick , doubleClick, clickAndDrag};
            foreach (PictureBox mode in buttons)
            {
                mode.MouseHover += new EventHandler(pictureBox_MouseHover);
            }

            ModeMapping = new Dictionary<PictureBox, ProgramMode>() 
            {
                {leftClick, ProgramMode.leftClick},
                {rightClick, ProgramMode.rightClick},
                {doubleClick, ProgramMode.doubleClick},
                {contextClick, ProgramMode.contextClick},
                {clickAndDrag, ProgramMode.clickAndDrag},
                {sleepClick, ProgramMode.sleepClick}
            };

            inverseModeMapping = new Dictionary<ProgramMode, PictureBox>();
            foreach(PictureBox box in ModeMapping.Keys)
            {
                inverseModeMapping.Add(ModeMapping[box], box);
            }

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = String.Empty;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = this.customParams.layoutValues.startLeft;
            this.Top = this.customParams.layoutValues.startTop;
            this.Width = this.customParams.layoutValues.startWidth;
            this.Height = this.customParams.layoutValues.startHeight;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            setPictureBoxLock(contextClick);
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
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            if (ModeMapping[current] == this.clickStatus.getBackgroundMode())
            {
                return;
            }
            setPictureBoxHighlighted(current);
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
            mode.MouseLeave -= new EventHandler(onPictureBoxLeave);
            if ((this.currentMousePictureBox == mode))
            {
                if (this.clickStatus.currentMode == ModeMapping[mode])
                {
                    this.clickStatus.setBackgroundMode(ModeMapping[mode]);
                    setClickDefault();
                }
                else
                {
                    this.clickStatus.setCurrentMode(ModeMapping[mode]);
                    setPictureBoxSelect(mode);
                    startTimer(mode);
                    mode.MouseLeave += new EventHandler(onPictureBoxLeave);
                }
            }
        }

        private void onPictureBoxLeave(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            if (this.currentMousePictureBox == current)
            {
                this.currentMousePictureBox = null;
            }
            if (current.BackColor == Color.Yellow)
            {
                current.BackColor = Color.White;
            }
            current.MouseLeave -= new EventHandler(onPictureBoxLeave);
        }

        private void setPictureBoxHighlighted(PictureBox toSet)
        {
            if (toSet.BackColor == Color.Red)
            {
                return;
            }
            toSet.BackColor = Color.Yellow;
        }

        private void setPictureBoxLock(PictureBox toSet)
        {
            toSet.BackColor = Color.DimGray;
        }

        private void setPictureBoxSelect(PictureBox toSet)
        {
            foreach (PictureBox box in buttons)
            {
                if (box.BackColor == Color.Red)
                {
                    box.BackColor = Color.White;
                }
            }
            toSet.BackColor = Color.Red;
        }

        public void setClickDefault()
        {
            foreach (PictureBox box in buttons)
            {
                box.BackColor = Color.White;
            }
            setPictureBoxLock(inverseModeMapping[this.clickStatus.getBackgroundMode()]);
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (MessageBox.Show("Are you sure you want to close?", "Smart Clicker", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                //Grab the current width and height of the form for saving
                customParams.layoutValues.startWidth = this.Width;
                customParams.layoutValues.startHeight = this.Height;
                // Save object to XML before you close
                this.customParams.layoutValues.startLeft = this.Left;
                this.customParams.layoutValues.startTop = this.Top;
                new XmlMethods().saveCustomParams(customParams);
                return;
            }
        }

        // This function is never getting called by the APIs.
        // TODO: Investigate
        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
        }

        public void CatchFatalException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log(e.Exception.ToString(), w);
            }
            if (this.customParams.layoutValues.restartOnCrash)
            {
                Application.Restart();
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        public void redraw()
        {
            foreach (string name in this.customParams.layoutValues.hiddenIconNames)
            {
                Debug.WriteLine(name);
            }
            int size = this.customParams.layoutValues.hiddenIconNames.Count();
            int allButtons = buttons.Count();
            //shown is the number of rows we need for our mode buttons
            int shown = allButtons - size;
            // we add 1 to shown to account for config button
            shown = shown + 1; 

            // Try to rebuild the tablelayoutpanel each time
            this.Controls.Remove(tableLayoutPanel1);

            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            this.Controls.Add(tableLayoutPanel1);

            //Formatting things, move to another method eventually if this works
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";

            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 360);
            this.tableLayoutPanel1.TabIndex = 26;

            this.tableLayoutPanel1.RowCount = shown;
            int i = 0;

            foreach (PictureBox button in buttons)
            {
                if (!(this.customParams.layoutValues.hiddenIconNames.Contains(button.Name)))
                {
                    this.tableLayoutPanel1.Controls.Add(button, 0, i);
                    i++;
                    if (button.Name.Equals("help"))
                    {
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.052186F));
                    }
                    else
                    {
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
                    }
                }
            }
            
            
        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void CustomForm_MouseHover(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;


            setPictureBoxHighlighted(current);
            this.currentMousePictureBox = current;

            startSettingsTimer(current);
            current.MouseLeave += new EventHandler(onPictureBoxLeave);

        }

        private void startSettingsTimer(PictureBox mode)
        {
            Timer mouseOver = new Timer();
            mouseOver.Tick += (sender, e) => settingsSelected(sender, mode);
            mouseOver.Interval = 1000; // in miliseconds
            mouseOver.Start();
        }


        private void settingsSelected(object sender, PictureBox mode)
        {
            Timer mouseOver = (Timer)sender;
            mouseOver.Stop();
            mouseOver.Dispose();
            mode.MouseLeave -= new EventHandler(onPictureBoxLeave);
            if ((this.currentMousePictureBox == mode))
            {
                CustomForm_Click(sender, null);
            }
            this.currentMousePictureBox = null;
        }


        private void CustomForm_Click(object sender, EventArgs e)
        {
            // launch custom UI
            CustomUI customWindow = new CustomUI(customParams, this);
            customWindow.Show();
        }

        //private void launchCustomForm()
        //{
        //    CustomUI customWindow = new CustomUI(customParams, this);
        //    customWindow.Show();
        //}

    }
}
