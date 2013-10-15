namespace Smart_Clicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            this.SuspendLayout();
            // 
            // leftClick
            // 
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(24, 12);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(146, 127);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 4;
            this.leftClick.TabStop = false;
            this.leftClick.MouseHover += new System.EventHandler(this.leftClick_MouseHover);
            // 
            // rightClick
            // 
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(24, 162);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(146, 127);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 5;
            this.rightClick.TabStop = false;
            this.rightClick.MouseHover += new System.EventHandler(this.rightClick_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 634);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.leftClick);
            this.Name = "Form1";
            this.Text = "Smart Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox rightClick;
    }
}

