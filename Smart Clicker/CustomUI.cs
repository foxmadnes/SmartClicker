using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace Smart_Clicker
{
    public partial class CustomUI : Form
    {
        private static double MAX_TIME = 10;
        private static double MIN_TIME = 0.3;
        private static int MAX_SIZE = 100;
        private static int MIN_SIZE = 10;
        private CustomizationParameters customParams;
        private CustomizationParameters changedParams;
        private Dictionary<CheckBox, string> ModeToStringMapping;
        private Dictionary<string, CheckBox> StringToModeMapping;
        private MainForm mainform;

        public CustomUI(CustomizationParameters customParams, MainForm mainForm)
        {
            InitializeComponent();
            this.customParams = customParams;
            this.changedParams = customParams.copy();
            this.mainform = mainForm;
            this.timerText.Text = (((double) changedParams.clickValues.timeout)/ 100).ToString();
            this.boundingBoxText.Text = changedParams.clickValues.clickBoundingBox.ToString();
            CheckBox[] modes = { displayClickDragMode, displayContextMode, displayDoubleMode, displayLeftMode, displayRightMode, displaySleepMode };
            CheckBox[] contextSettings = { contextCompareCursors, contextScrollBars, contextTabs, contextTitleBars };
            // Read several parameters from the customization classes
            this.startupBoot.Checked = this.changedParams.layoutValues.startOnStartup;
            this.crashReboot.Checked = this.changedParams.layoutValues.restartOnCrash;
            this.autoHide.Checked = this.changedParams.layoutValues.autoHide;
            contextCompareCursors.Checked = this.changedParams.contextValues.compareCursors;
            contextScrollBars.Checked = this.changedParams.contextValues.supportScrollBars;
            contextTabs.Checked = this.changedParams.contextValues.supportTabs;
            contextTitleBars.Checked = this.changedParams.contextValues.supportTitleBars;


            ModeToStringMapping = new Dictionary<CheckBox, string>() 
            {
                {displayLeftMode, "leftClick"},
                {displayRightMode, "rightClick"},
                {displayDoubleMode, "doubleClick"},
                {displayContextMode, "contextClick"},
                {displayClickDragMode, "clickAndDrag"},
                {displaySleepMode, "sleepClick"},
            };
            StringToModeMapping = new Dictionary<string,CheckBox>();
            // Initialize checkboxes on first tab, load settings 
            foreach (CheckBox key in ModeToStringMapping.Keys)
            {
                StringToModeMapping.Add(this.ModeToStringMapping[key], key);
            }
            foreach (CheckBox box in modes)
            {
                box.Checked = true;
                box.CheckedChanged += new EventHandler(box_CheckedChanged);
            }
            foreach (string hidden in this.changedParams.layoutValues.hiddenIconNames.ToList<string>())
            {
                StringToModeMapping[hidden].Checked = false;
            }
        }



        private void confirmCustom_Click(object sender, EventArgs e)
        {
            try
            {
                // on confirm, add unchecked boxes to the hidden icons list in customization object
                this.changedParams.layoutValues.hiddenIconNames.Clear();
                CheckBox[] checkmodes = { displayClickDragMode, displayContextMode, displayDoubleMode, displayLeftMode, displayRightMode, displaySleepMode};
                foreach (CheckBox checkbox in checkmodes)
                {
                    if (!(checkbox.Checked))
                    {
                        this.changedParams.layoutValues.hiddenIconNames.Add(StringToModeMapping.FirstOrDefault(x => x.Value == checkbox).Key);
                    }
                }
                this.customParams.merge(changedParams);
                // serialize object --> XML
                new XmlMethods().saveCustomParams(changedParams);
                this.mainform.detector.resetTimerInterval();
                // update the mainform with the configuration changes made by the user
                this.mainform.redraw();
                this.setStartOnBoot();

                this.Close();
            }
            catch(Exception exp)
            {
                Debug.Write(exp.ToString());
                MessageBox.Show("Invalid input.  Please try again!", "Error", MessageBoxButtons.OK);
            }
        }

        private void cancelCustom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timePlus_MouseHover(object sender, EventArgs e)
        {
            while (timePlus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                
                double val = double.Parse(timerText.Text);
                // While cursor is on the button, keep incrementing the values of the text box
                if (double.Parse(timerText.Text) != MAX_TIME) {
                    val += 0.1;
                }
                timerText.Text = val.ToString();
                this.changedParams.clickValues.timeout = (int) (val * 100);
                timerText.Refresh();
                Thread.Sleep(500);  // Half second delays after each update             
            }
        }

        private void timeMinus_mouseHover(object sender, EventArgs e)
        {
           
            while (timeMinus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                double val = double.Parse(timerText.Text);
                // While cursor is on the button, keep decrementing the values of the text box
                if (double.Parse(timerText.Text) != MIN_TIME)
                {
                    val -= 0.1;
                }
                timerText.Text = val.ToString();
                this.changedParams.clickValues.timeout = (int) (val * 100);
                timerText.Refresh();
                Thread.Sleep(500);  // Half second delays after each update
            }
        }

        private void sizePlus_MouseHover(object sender, EventArgs e)
        {
            while (boxSizePlus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                int val = int.Parse(boundingBoxText.Text) + 1;
                boundingBoxText.Text = val.ToString();
                boundingBoxText.Refresh();
                Thread.Sleep(500); 
            }
        }

        private void sizeMinus_MouseHover(object sender, EventArgs e)
        {
            while (boundingBoxMinus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                int val = int.Parse(boundingBoxText.Text) - 1;
                boundingBoxText.Text = val.ToString();
                boundingBoxText.Refresh();
                Thread.Sleep(500);  
            }
        }

        // update customization object when checkbox changed
        private void box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentBox = (CheckBox)sender;
            if (currentBox.Checked)
            {
                while( this.changedParams.layoutValues.hiddenIconNames.Contains(this.ModeToStringMapping[currentBox]))
                {
                    this.changedParams.layoutValues.hiddenIconNames.Remove(this.ModeToStringMapping[currentBox]);
                }
            }
            else
            {
                this.changedParams.layoutValues.hiddenIconNames.Add(this.ModeToStringMapping[currentBox]);
            }
        }

        private void setStartOnBoot()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (this.changedParams.layoutValues.startOnStartup)
            {
                key.SetValue("SmartClicker", "\"" + Application.ExecutablePath.ToString() + "\"");
            }
            else
            {
                if (key.GetValue("SmartClicker") != null)
                {
                    key.DeleteValue("SmartClicker");
                }
            }
        }

        private void contextCompareCursors_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            this.changedParams.contextValues.compareCursors = box.Checked;
        }

        private void contextTitleBars_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            this.changedParams.contextValues.supportTitleBars = box.Checked;
        }

        private void contextScrollBars_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            this.changedParams.contextValues.supportScrollBars = box.Checked;
        }

        private void contextTabs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;
            this.changedParams.contextValues.supportTabs = box.Checked;
        }

        private void startupBoot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            this.changedParams.layoutValues.startOnStartup = box.Checked;
        }

        private void crashReboot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            this.changedParams.layoutValues.restartOnCrash = box.Checked;
        }

        private void autoHide_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            this.changedParams.layoutValues.autoHide = box.Checked;
        }

    }
}
