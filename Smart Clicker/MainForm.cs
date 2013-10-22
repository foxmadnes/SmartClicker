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
    public partial class MainForm : Form
    {
        private ClickStatus clickStatus;
        private PictureBox[] buttons;

        public MainForm(ClickStatus status)
        {
            InitializeComponent();
            this.clickStatus = status;
            this.buttons = new PictureBox[] { leftClick, rightClick , doubleClick, contextClick, clickAndDrag, sleepClick};
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            this.clickStatus.setContext(false);
        }

        private void doubleClick_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(doubleClick);
            this.clickStatus.setStatus(statusEnum.doubleClick);
            this.clickStatus.setContext(false);
        }

        private void clickAndDrag_MouseHover(object sender, EventArgs e)
        {
            setPictureBoxColors(clickAndDrag);
            this.clickStatus.setStatus(statusEnum.leftDown);
            this.clickStatus.setContext(false);
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
    }
}
