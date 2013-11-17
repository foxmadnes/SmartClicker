namespace Smart_Clicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.sleepClick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).BeginInit();
            this.SuspendLayout();
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clickAndDrag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(0, 325);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(321, 66);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 10;
            this.clickAndDrag.TabStop = false;
            // 
            // doubleClick
            // 
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doubleClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(0, 258);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(321, 67);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 11;
            this.doubleClick.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(0, 188);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(321, 70);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 12;
            this.rightClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(0, 126);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(321, 62);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 13;
            this.leftClick.TabStop = false;
            // 
            // contextClick
            // 
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contextClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(0, 64);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(321, 62);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 14;
            this.contextClick.TabStop = false;
            // 
            // sleepClick
            // 
            this.sleepClick.BackColor = System.Drawing.SystemColors.Window;
            this.sleepClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sleepClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sleepClick.Image = ((System.Drawing.Image)(resources.GetObject("sleepClick.Image")));
            this.sleepClick.Location = new System.Drawing.Point(0, 2);
            this.sleepClick.Name = "sleepClick";
            this.sleepClick.Size = new System.Drawing.Size(321, 62);
            this.sleepClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleepClick.TabIndex = 15;
            this.sleepClick.TabStop = false;
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Virtual Mouse Clicker Application";
            this.AccessibleName = "Smart Clicker";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(321, 391);
            this.Controls.Add(this.sleepClick);
            this.Controls.Add(this.contextClick);
            this.Controls.Add(this.leftClick);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.doubleClick);
            this.Controls.Add(this.clickAndDrag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(90, 90);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Smart Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox sleepClick;

    }
}

