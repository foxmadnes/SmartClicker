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
        private int dwellTime = 10; // 10 by default
        private int boxSize = 10; // 10 by default
        private CustomizationParameters customParams;


        // Accept instance of customizable class
        public CustomUI(CustomizationParameters customParams)
        {
            InitializeComponent();
            this.customParams = customParams;
            // set default values- Andres, what would you like here?
            this.customParams.clickValues.timeout = 10;
            this.customParams.clickValues.clickBoundingBox = 10;
        }

        private CustomizationParameters getCustomizationParameters()
        {
            return this.customParams;
        }        

        // Write object Data to an XML file 
        private void saveCustomParams()
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CustomizationParameters));
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\SmartClickerCustomization.xml");
            writer.Serialize(file, this.customParams);
            file.Close();
        }

        private void confirmCustom_Click(object sender, EventArgs e)
        {
            try
            {
                dwellTime = int.Parse(timerText.Text);
                boxSize = int.Parse(boundingBoxText.Text);
                this.customParams.clickValues.timeout = dwellTime;
                this.customParams.clickValues.clickBoundingBox = boxSize;
                saveCustomParams(); // Should this happen here? Or on the parent level?
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
                // While cursor is on the button, keep incrementing the values of the text box
                int val = int.Parse(timerText.Text) + 1;
                timerText.Text = val.ToString();
                timerText.Refresh();
                Thread.Sleep(500);  // Take half second delays right after refreshing each update, else it happens too quickly              

                
            }
        }

        private void timeMinus_mouseHover(object sender, EventArgs e)
        {

            while (timeMinus.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                Debug.WriteLine("In the minus loop");
                // While cursor is on the button, keep incrementing the values of the text box
                int val = int.Parse(timerText.Text) - 1;
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
