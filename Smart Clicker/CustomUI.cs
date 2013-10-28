using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Clicker
{
    public partial class CustomUI : Form
    {
        private int dwellTime;
        private int boxSize;

        public CustomUI()
        {
            InitializeComponent();
        }

        private void timerSelectBox_ValueChanged(object sender, EventArgs e)
        {
            // Change the time to dwell before clicking, in seconds- What's the maximum and minimum values for this?
            dwellTime = (int) timerSelectBox.Value;

        }

        private void boundingBox_ValueChanged(object sender, EventArgs e)
        {
            // Change the size of the clickable area- What's the maximum and minimum size for this?
            boxSize = (int) boundingBox.Value;
        }

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

        private int getDwellTime()
        {

            return dwellTime;
        }

        private int getBozSize()
        {
            return boxSize;
        }
        
    }
}
