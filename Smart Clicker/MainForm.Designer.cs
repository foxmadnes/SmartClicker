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
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.sleepClick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).BeginInit();
            this.SuspendLayout();
            // 
            // leftClick
            // 
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(21, 183);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(98, 82);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 4;
            this.leftClick.TabStop = false;
            this.leftClick.Click += new System.EventHandler(this.leftClick_Click);
            this.leftClick.MouseHover += new System.EventHandler(this.leftClick_MouseHover);
            // 
            // rightClick
            // 
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(21, 271);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(98, 90);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 5;
            this.rightClick.TabStop = false;
            this.rightClick.MouseHover += new System.EventHandler(this.rightClick_MouseHover);
            // 
            // doubleClick
            // 
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(21, 367);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(98, 98);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 6;
            this.doubleClick.TabStop = false;
            this.doubleClick.MouseHover += new System.EventHandler(this.doubleClick_MouseHover);
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(21, 471);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(98, 97);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 7;
            this.clickAndDrag.TabStop = false;
            this.clickAndDrag.MouseHover += new System.EventHandler(this.clickAndDrag_MouseHover);
            // 
            // contextClick
            // 
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(21, 95);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(98, 82);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 8;
            this.contextClick.TabStop = false;
            this.contextClick.MouseHover += new System.EventHandler(this.contextClick_MouseHover);
            // 
            // sleepClick
            // 
            this.sleepClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sleepClick.Image = ((System.Drawing.Image)(resources.GetObject("sleepClick.Image")));
            this.sleepClick.Location = new System.Drawing.Point(21, 7);
            this.sleepClick.Name = "sleepClick";
            this.sleepClick.Size = new System.Drawing.Size(98, 82);
            this.sleepClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleepClick.TabIndex = 9;
            this.sleepClick.TabStop = false;
            this.sleepClick.MouseHover += new System.EventHandler(this.sleepClick_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 576);
            this.Controls.Add(this.sleepClick);
            this.Controls.Add(this.contextClick);
            this.Controls.Add(this.clickAndDrag);
            this.Controls.Add(this.doubleClick);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.leftClick);
            this.Name = "MainForm";
            this.Text = "Smart Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox sleepClick;
    }
}

