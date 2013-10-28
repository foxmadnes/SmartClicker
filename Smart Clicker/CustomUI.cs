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
        private int dwellTime = 10; // 10 by default
        private int boxSize = 10; // 10 by default

        public CustomUI()
        {
            InitializeComponent();
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

        private void timePlus_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(timerText.Text) + 1;
                timerText.Text = val.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input.  Please try again!", "Error", MessageBoxButtons.OK);
            }
        }

        private void timeMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(timerText.Text) - 1;
                timerText.Text = val.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input.  Please try again!", "Error", MessageBoxButtons.OK);
            }
        }

        private void boxSizePlus_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(boundingBoxText.Text) + 1;
                boundingBoxText.Text = val.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input.  Please try again!", "Error", MessageBoxButtons.OK);
            }
        }

        private void boundingBoxMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(boundingBoxText.Text) - 1;
                boundingBoxText.Text = val.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input.  Please try again!", "Error", MessageBoxButtons.OK);
            }

        }



        private void confirmCustom_Click(object sender, EventArgs e)
        {
            try
            {
                dwellTime = int.Parse(timerText.Text);
                boxSize = int.Parse(boundingBoxText.Text);
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


        
        
    }
}
