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

        #region Initialization

        public MainForm(ClickStatus status, CustomizationParameters customParams)
        {
            // Initialize Fetcher icon, that pulls main form forward when moused over, and is always TopForm
            this.fetcher = new Fetcher(this, customParams);
            fetcher.Show();

            // Set starting variables
            InitializeComponent();
            this.clickStatus = status;
            this.customParams = customParams;

            // Set Windows Application parameters and add tray icon
            this.ShowInTaskbar = false;
            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            this.trayIcon = new NotifyIcon();
            trayIcon.Text = "SmartClicker";
            trayIcon.Icon = this.Icon;

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            // This holds every hide-able picturebox for different program modes
            this.buttons = new PictureBox[] {sleepClick, contextClick, leftClick, rightClick , doubleClick, clickAndDrag, help};
            foreach (PictureBox mode in buttons)
            {
                // Help gets its own Event Handler, as it is hideable but not a program mode
                if (!(mode.Name == "help"))
                {
                    // Add mouseover handler for selection
                    mode.MouseHover += new EventHandler(pictureBox_MouseHover);
                }
                else
                {
                    help.MouseHover += new EventHandler(help_MouseHover);
                }
            }

            // Need to add a mouse hover handler to the config button too
            CustomForm.MouseHover += new EventHandler(CustomForm_MouseHover);

            // Create a mapping from picture boxes to default program modes, so we can set them if they are selected
            ModeMapping = new Dictionary<PictureBox, ProgramMode>() 
            {
                {leftClick, ProgramMode.leftClick},
                {rightClick, ProgramMode.rightClick},
                {doubleClick, ProgramMode.doubleClick},
                {contextClick, ProgramMode.contextClick},
                {clickAndDrag, ProgramMode.clickAndDrag},
                {sleepClick, ProgramMode.sleepClick}
            };

            // Create an inverse mapping so the detector can also change how pictureboxes look
            inverseModeMapping = new Dictionary<ProgramMode, PictureBox>();
            foreach(PictureBox box in ModeMapping.Keys)
            {
                inverseModeMapping.Add(ModeMapping[box], box);
            }

            // Redraw the MainForm to match XML configuration
            this.redraw();

            // Initialize the form to the XML/default parameters
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = String.Empty;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = this.customParams.layoutValues.startLeft;
            this.Top = this.customParams.layoutValues.startTop;
            this.Width = this.customParams.layoutValues.startWidth;
            this.Height = this.customParams.layoutValues.startHeight;

            // Add handler to ask "Are you sure?" dialog
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            setPictureBoxLock(contextClick);
        }

        #endregion

        #region Mode Selection

        #region Click Modes

        // Starts a timer and highlights the pictureBox when mousedOver
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

        // Starts timer for mouseover, used both for selection and locking
        private void startTimer(PictureBox mode)
        {
            Timer mouseOver = new Timer();
            mouseOver.Tick += (sender, e) => modeSelected(sender, mode);
            mouseOver.Interval = 1000; // in miliseconds
            mouseOver.Start();
        }

        // Called when mouse was successfully moused over, used for selection and locking
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

        // Clears timer settings if mouse leaves pictureBox while selecting
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

        private void setPictureBoxLock(PictureBox toSet)
        {
            toSet.BackColor = Color.DimGray;
        }

        // Called by Click detector when clearing current mode
        public void setClickDefault()
        {
            foreach (PictureBox box in buttons)
            {
                box.BackColor = Color.White;
            }
            setPictureBoxLock(inverseModeMapping[this.clickStatus.getBackgroundMode()]);
        }

        #endregion

        #region Settings Button

        // Launch settings page
        private void CustomForm_MouseHover(object sender, EventArgs e)
        {
            PictureBox current = (PictureBox)sender;
            startSettingsTimer(current);
            setPictureBoxHighlighted(current);
            this.currentMousePictureBox = current;
            current.MouseLeave += new EventHandler(onPictureBoxLeave);
        }

        private void startSettingsTimer(PictureBox mode)
        {
            Timer mouseOver = new Timer();
            mouseOver.Tick += (sender, e) => settingsSelected(sender, mode);
            mouseOver.Interval = 1000; // in miliseconds
            mouseOver.Start();
        }

        private void CustomForm_Click(object sender, EventArgs e)
        {
            // launch custom UI
            CustomUI customWindow = new CustomUI(customParams, this);
            customWindow.Show();
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

        #endregion

        #region Help Button

        // Eventually launch a help menu with documentation
        private void help_Click(object sender, EventArgs e)
        {

        }

        private void help_MouseHover(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region GUI Functions

        // repaints the mainform each time settings are changed from the customizability form or 
        //  based on config file when application is launched
        public void redraw()
        {
            int size = this.customParams.layoutValues.hiddenIconNames.Count();
            int allButtons = buttons.Count();
            //shown is the number of rows we need for our mode buttons
            int shown = allButtons - size;
            // we add 1 to shown to account for config button
            shown = shown + 1;

            // Rebuild the tableLayoutPanel 
            this.Controls.Remove(tableLayoutPanel1);

            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            this.Controls.Add(tableLayoutPanel1);

            // Format the tableLayoutPanel correctly
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";

            this.tableLayoutPanel1.Size = new System.Drawing.Size(32, 60);
            this.tableLayoutPanel1.TabIndex = 26;

            this.tableLayoutPanel1.RowCount = shown;

            // Add the specified buttons to the mainform page
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

            this.tableLayoutPanel1.Controls.Add(this.CustomForm, 0, i);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.052186F));


        }

        #endregion

        #region Exit Functions

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If Windows shut down, skip dialog
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (MessageBox.Show("Are you sure you want to close?", "Smart Clicker", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
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

        //Catches any uncaught exceptions in the application and restarts if configured
        public void CatchFatalException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            using (StreamWriter w = File.AppendText("ExceptionLog.txt"))
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

        #endregion
    }
}
