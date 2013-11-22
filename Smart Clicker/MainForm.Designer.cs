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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.customize = new System.Windows.Forms.ToolStripButton();
            this.help = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sleepClick = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customize,
            this.help,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 399);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(140, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // customize
            // 
            this.customize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customize.Image = ((System.Drawing.Image)(resources.GetObject("customize.Image")));
            this.customize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(23, 22);
            this.customize.Text = "Settings";
            this.customize.Click += new System.EventHandler(this.customize_Click);
            // 
            // help
            // 
            this.help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(23, 22);
            this.help.Text = "Help";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Smart_Clicker.Properties.Resources.FetcherIcon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "About";
            // 
            // sleepClick
            // 
            this.sleepClick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sleepClick.BackColor = System.Drawing.SystemColors.Window;
            this.sleepClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sleepClick.Image = ((System.Drawing.Image)(resources.GetObject("sleepClick.Image")));
            this.sleepClick.Location = new System.Drawing.Point(0, 0);
            this.sleepClick.Name = "sleepClick";
            this.sleepClick.Size = new System.Drawing.Size(89, 67);
            this.sleepClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleepClick.TabIndex = 20;
            this.sleepClick.TabStop = false;
            // 
            // contextClick
            // 
            this.contextClick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(0, 67);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(89, 67);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 21;
            this.contextClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(0, 134);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(89, 67);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 22;
            this.leftClick.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(0, 201);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(89, 67);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 23;
            this.rightClick.TabStop = false;
            // 
            // doubleClick
            // 
            this.doubleClick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(0, 268);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(89, 67);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 24;
            this.doubleClick.TabStop = false;
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(0, 335);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(89, 67);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 25;
            this.clickAndDrag.TabStop = false;
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Virtual Mouse Clicker Application";
            this.AccessibleName = "Smart Clicker";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(140, 424);
            this.Controls.Add(this.clickAndDrag);
            this.Controls.Add(this.doubleClick);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.leftClick);
            this.Controls.Add(this.contextClick);
            this.Controls.Add(this.sleepClick);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(90, 90);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Smart Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton customize;
        private System.Windows.Forms.ToolStripButton help;
        private System.Windows.Forms.PictureBox sleepClick;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

