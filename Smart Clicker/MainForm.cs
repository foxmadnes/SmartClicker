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

        public MainForm(ClickStatus status)
        {
            InitializeComponent();
            this.clickStatus = status;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftClick_MouseHover(object sender, EventArgs e)
        {
            this.clickStatus.setStatus(statusEnum.leftClick);
        }

        private void rightClick_MouseHover(object sender, EventArgs e)
        {
            this.clickStatus.setStatus(statusEnum.rightClick);
        }

        private void doubleClick_MouseHover(object sender, EventArgs e)
        {
            this.clickStatus.setStatus(statusEnum.doubleClick);
        }

        private void clickAndDrag_MouseHover(object sender, EventArgs e)
        {
            this.clickStatus.setStatus(statusEnum.leftDown);
        }

        private void leftClick_Click(object sender, EventArgs e)
        {
            this.clickStatus.setStatus(statusEnum.leftClick);
        }
    }
}
