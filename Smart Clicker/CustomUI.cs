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

namespace Smart_Clicker
{
    public partial class CustomUI : Form
    {
        private static double MAX_TIME = 10;
        private static double MIN_TIME = 0.3;
        private static int MAX_SIZE = 100;
        private static int MIN_SIZE = 10;
        private CustomizationParameters customParams;
        private MainForm mainform;

        public CustomUI()
        {
            InitializeComponent();
        }

        public CustomUI(CustomizationParameters customParams, MainForm mainForm)
        {
            InitializeComponent();
            this.customParams = customParams;
            this.mainform = mainForm;
            this.customParams.clickValues.timeout = 1;
            this.customParams.clickValues.clickBoundingBox = 25;
        }



        private void confirmCustom_Click(object sender, EventArgs e)
        {
            try
            {
                //dwellTime = int.Parse(timerText.Text);
                //boxSize = int.Parse(boundingBoxText.Text);
                //this.customParams.clickValues.timeout = dwellTime;
                //this.customParams.clickValues.clickBoundingBox = boxSize;
                new XmlMethods().saveCustomParams(customParams);
                // the layout event handlers below will edit the customparams instance
                //this.mainform.draw(); --> Klaudia add this function to mainform!
                this.Close();
            }
            catch
            {
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
                Debug.WriteLine("In the plus loop");
                double val = double.Parse(timerText.Text);
                // While cursor is on the button, keep incrementing the values of the text box
                if (double.Parse(timerText.Text) != MAX_TIME) {
                    val += 0.1;
                }
                timerText.Text = val.ToString();
                timerText.Refresh();
                Thread.Sleep(500);  // Take half second delays right after refreshing each update, else it happens too quickly              

                
            }
        }

        // Combine this and timePlus into one callback function later
        private void timeMinus_mouseHover(object sender, EventArgs e)
        {

            while (timeMinus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                Debug.WriteLine("In the minus loop");
                double val = double.Parse(timerText.Text);
                // While cursor is on the button, keep decrementing the values of the text box
                if (double.Parse(timerText.Text) != MIN_TIME)
                {
                    val -= 0.1;
                }
                timerText.Text = val.ToString();
                timerText.Refresh();
                Thread.Sleep(500);  // Take half second delays right after refreshing each update, else it happens too quickly
            }
        }

        private void sizePlus_MouseHover(object sender, EventArgs e)
        {
            while (boxSizePlus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                Debug.WriteLine("In the loop, assuming the ticking interval will trigger the update handler");
                // While cursor is on the button, keep incrementing the values of the text box
                int val = int.Parse(boundingBoxText.Text) + 1;
                boundingBoxText.Text = val.ToString();
                boundingBoxText.Refresh();
                Thread.Sleep(500);  // Take half second delays right after refreshing each update, else it happens too quickly
            }
        }

        private void sizeMinus_MouseHover(object sender, EventArgs e)
        {
            while (boundingBoxMinus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                Debug.WriteLine("In the loop, assuming the ticking interval will trigger the update handler");
                // While cursor is on the button, keep incrementing the values of the text box
                int val = int.Parse(boundingBoxText.Text) - 1;
                boundingBoxText.Text = val.ToString();
                boundingBoxText.Refresh();
                Thread.Sleep(500);  // Take half second delays right after refreshing each update, else it happens too quickly
            }
        }


        /** Layout Alteration portion of the code.. Separate Tab? **/

        private void displaySleepMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displayContextMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displayLeftMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displayRightMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displayDoubleMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displayClickDragMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startupBoot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void crashReboot_CheckedChanged(object sender, EventArgs e)
        {

        }


        
    }
}
