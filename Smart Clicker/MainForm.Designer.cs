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
            else if (disposing)
            {
                this.trayIcon.Visible = false;
                this.trayIcon.Dispose();
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
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.CustomForm = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.sleepClick = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleClick
            // 
            this.doubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(1, 33);
            this.doubleClick.Margin = new System.Windows.Forms.Padding(1);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(30, 6);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 24;
            this.doubleClick.TabStop = false;
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(1, 41);
            this.clickAndDrag.Margin = new System.Windows.Forms.Padding(1);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(30, 6);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 25;
            this.clickAndDrag.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(1, 25);
            this.rightClick.Margin = new System.Windows.Forms.Padding(1);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(30, 6);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 23;
            this.rightClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(1, 17);
            this.leftClick.Margin = new System.Windows.Forms.Padding(1);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(30, 6);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 22;
            this.leftClick.TabStop = false;
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.help.BackColor = System.Drawing.SystemColors.Window;
            this.help.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(1, 53);
            this.help.Margin = new System.Windows.Forms.Padding(1);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(30, 6);
            this.help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.help.TabIndex = 27;
            this.help.TabStop = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // CustomForm
            // 
            this.CustomForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomForm.BackColor = System.Drawing.SystemColors.Window;
            this.CustomForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomForm.Image = ((System.Drawing.Image)(resources.GetObject("CustomForm.Image")));
            this.CustomForm.Location = new System.Drawing.Point(1, 49);
            this.CustomForm.Margin = new System.Windows.Forms.Padding(1);
            this.CustomForm.Name = "CustomForm";
            this.CustomForm.Size = new System.Drawing.Size(30, 2);
            this.CustomForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomForm.TabIndex = 26;
            this.CustomForm.TabStop = false;
            this.CustomForm.Click += new System.EventHandler(this.CustomForm_Click);
            // 
            // contextClick
            // 
            this.contextClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(1, 9);
            this.contextClick.Margin = new System.Windows.Forms.Padding(1);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(30, 6);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 21;
            this.contextClick.TabStop = false;
            // 
            // sleepClick
            // 
            this.sleepClick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sleepClick.BackColor = System.Drawing.SystemColors.Window;
            this.sleepClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sleepClick.Image = ((System.Drawing.Image)(resources.GetObject("sleepClick.Image")));
            this.sleepClick.Location = new System.Drawing.Point(1, 1);
            this.sleepClick.Margin = new System.Windows.Forms.Padding(1);
            this.sleepClick.Name = "sleepClick";
            this.sleepClick.Size = new System.Drawing.Size(30, 6);
            this.sleepClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleepClick.TabIndex = 20;
            this.sleepClick.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sleepClick, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contextClick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomForm, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.help, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.leftClick, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rightClick, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clickAndDrag, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.doubleClick, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.052186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.052186F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(32, 60);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AccessibleDescription = "Virtual Mouse Clicker Application";
            this.AccessibleName = "Smart Clicker";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(32, 60);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 1800);
            this.MinimumSize = new System.Drawing.Size(25, 100);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Smart Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.PictureBox CustomForm;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox sleepClick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;


    }
}

