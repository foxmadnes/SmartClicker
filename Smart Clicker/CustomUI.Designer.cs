namespace Smart_Clicker
{
    partial class CustomUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomUI));
            this.label1 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.boundingBoxLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayContextMode = new System.Windows.Forms.CheckBox();
            this.displayLeftMode = new System.Windows.Forms.CheckBox();
            this.displaySleepMode = new System.Windows.Forms.CheckBox();
            this.displayRightMode = new System.Windows.Forms.CheckBox();
            this.displayDoubleMode = new System.Windows.Forms.CheckBox();
            this.displayClickDragMode = new System.Windows.Forms.CheckBox();
            this.timePlus = new System.Windows.Forms.Button();
            this.timeMinus = new System.Windows.Forms.Button();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boundingBoxMinus = new System.Windows.Forms.Button();
            this.boxSizePlus = new System.Windows.Forms.Button();
            this.boundingBoxText = new System.Windows.Forms.TextBox();
            this.timerText = new System.Windows.Forms.TextBox();
            this.confirmCustom = new System.Windows.Forms.Button();
            this.cancelCustom = new System.Windows.Forms.Button();
            this.startupBoot = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crashReboot = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customizable Features:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(13, 46);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(123, 20);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "Time For Click:";
            // 
            // boundingBoxLabel
            // 
            this.boundingBoxLabel.AutoSize = true;
            this.boundingBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundingBoxLabel.Location = new System.Drawing.Point(14, 90);
            this.boundingBoxLabel.Name = "boundingBoxLabel";
            this.boundingBoxLabel.Size = new System.Drawing.Size(175, 20);
            this.boundingBoxLabel.TabIndex = 3;
            this.boundingBoxLabel.Text = "Size of Bounding Box:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu Layout:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select which icons will be displayed";
            // 
            // displayContextMode
            // 
            this.displayContextMode.AutoSize = true;
            this.displayContextMode.Location = new System.Drawing.Point(202, 375);
            this.displayContextMode.Name = "displayContextMode";
            this.displayContextMode.Size = new System.Drawing.Size(116, 21);
            this.displayContextMode.TabIndex = 17;
            this.displayContextMode.Text = "Context Mode";
            this.displayContextMode.UseVisualStyleBackColor = true;
            this.displayContextMode.CheckedChanged += new System.EventHandler(this.displayContextMode_CheckedChanged);
            // 
            // displayLeftMode
            // 
            this.displayLeftMode.AutoSize = true;
            this.displayLeftMode.Location = new System.Drawing.Point(385, 375);
            this.displayLeftMode.Name = "displayLeftMode";
            this.displayLeftMode.Size = new System.Drawing.Size(126, 21);
            this.displayLeftMode.TabIndex = 18;
            this.displayLeftMode.Text = "Left Click Mode";
            this.displayLeftMode.UseVisualStyleBackColor = true;
            this.displayLeftMode.CheckedChanged += new System.EventHandler(this.displayLeftMode_CheckedChanged);
            // 
            // displaySleepMode
            // 
            this.displaySleepMode.AutoSize = true;
            this.displaySleepMode.Location = new System.Drawing.Point(19, 375);
            this.displaySleepMode.Name = "displaySleepMode";
            this.displaySleepMode.Size = new System.Drawing.Size(105, 21);
            this.displaySleepMode.TabIndex = 19;
            this.displaySleepMode.Text = "Sleep Mode";
            this.displaySleepMode.UseVisualStyleBackColor = true;
            this.displaySleepMode.CheckedChanged += new System.EventHandler(this.displaySleepMode_CheckedChanged);
            // 
            // displayRightMode
            // 
            this.displayRightMode.AutoSize = true;
            this.displayRightMode.Location = new System.Drawing.Point(19, 528);
            this.displayRightMode.Name = "displayRightMode";
            this.displayRightMode.Size = new System.Drawing.Size(135, 21);
            this.displayRightMode.TabIndex = 20;
            this.displayRightMode.Text = "Right Click Mode";
            this.displayRightMode.UseVisualStyleBackColor = true;
            this.displayRightMode.CheckedChanged += new System.EventHandler(this.displayRightMode_CheckedChanged);
            // 
            // displayDoubleMode
            // 
            this.displayDoubleMode.AutoSize = true;
            this.displayDoubleMode.Location = new System.Drawing.Point(202, 528);
            this.displayDoubleMode.Name = "displayDoubleMode";
            this.displayDoubleMode.Size = new System.Drawing.Size(147, 21);
            this.displayDoubleMode.TabIndex = 21;
            this.displayDoubleMode.Text = "Double Click Mode";
            this.displayDoubleMode.UseVisualStyleBackColor = true;
            this.displayDoubleMode.CheckedChanged += new System.EventHandler(this.displayDoubleMode_CheckedChanged);
            // 
            // displayClickDragMode
            // 
            this.displayClickDragMode.AutoSize = true;
            this.displayClickDragMode.Location = new System.Drawing.Point(385, 528);
            this.displayClickDragMode.Name = "displayClickDragMode";
            this.displayClickDragMode.Size = new System.Drawing.Size(122, 21);
            this.displayClickDragMode.TabIndex = 22;
            this.displayClickDragMode.Text = "Click and Drag";
            this.displayClickDragMode.UseVisualStyleBackColor = true;
            this.displayClickDragMode.CheckedChanged += new System.EventHandler(this.displayClickDragMode_CheckedChanged);
            // 
            // timePlus
            // 
            this.timePlus.BackgroundImage = global::Smart_Clicker.Properties.Resources.plusblack;
            this.timePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timePlus.ImageKey = "(none)";
            this.timePlus.Location = new System.Drawing.Point(432, 32);
            this.timePlus.Name = "timePlus";
            this.timePlus.Size = new System.Drawing.Size(75, 34);
            this.timePlus.TabIndex = 32;
            this.timePlus.UseVisualStyleBackColor = true;
            this.timePlus.MouseHover += new System.EventHandler(this.timePlus_MouseHover);
            // 
            // timeMinus
            // 
            this.timeMinus.Image = global::Smart_Clicker.Properties.Resources.minus_black;
            this.timeMinus.Location = new System.Drawing.Point(202, 32);
            this.timeMinus.Name = "timeMinus";
            this.timeMinus.Size = new System.Drawing.Size(83, 34);
            this.timeMinus.TabIndex = 31;
            this.timeMinus.UseVisualStyleBackColor = true;
            this.timeMinus.MouseHover += new System.EventHandler(this.timeMinus_mouseHover);
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(385, 414);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(98, 97);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 28;
            this.clickAndDrag.TabStop = false;
            // 
            // doubleClick
            // 
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(202, 414);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(98, 98);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 27;
            this.doubleClick.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(26, 414);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(98, 90);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 26;
            this.rightClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(386, 277);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(98, 82);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 25;
            this.leftClick.TabStop = false;
            // 
            // contextClick
            // 
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(202, 277);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(98, 82);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 24;
            this.contextClick.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // boundingBoxMinus
            // 
            this.boundingBoxMinus.Image = global::Smart_Clicker.Properties.Resources.minus_black;
            this.boundingBoxMinus.Location = new System.Drawing.Point(202, 84);
            this.boundingBoxMinus.Name = "boundingBoxMinus";
            this.boundingBoxMinus.Size = new System.Drawing.Size(83, 34);
            this.boundingBoxMinus.TabIndex = 36;
            this.boundingBoxMinus.UseVisualStyleBackColor = true;
            this.boundingBoxMinus.MouseHover += new System.EventHandler(this.sizeMinus_MouseHover);
            // 
            // boxSizePlus
            // 
            this.boxSizePlus.BackgroundImage = global::Smart_Clicker.Properties.Resources.plusblack;
            this.boxSizePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxSizePlus.Location = new System.Drawing.Point(432, 84);
            this.boxSizePlus.Name = "boxSizePlus";
            this.boxSizePlus.Size = new System.Drawing.Size(75, 34);
            this.boxSizePlus.TabIndex = 37;
            this.boxSizePlus.UseVisualStyleBackColor = true;
            this.boxSizePlus.MouseHover += new System.EventHandler(this.sizePlus_MouseHover);
            // 
            // boundingBoxText
            // 
            this.boundingBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundingBoxText.Location = new System.Drawing.Point(310, 87);
            this.boundingBoxText.Multiline = true;
            this.boundingBoxText.Name = "boundingBoxText";
            this.boundingBoxText.Size = new System.Drawing.Size(102, 34);
            this.boundingBoxText.TabIndex = 30;
            this.boundingBoxText.Text = "25";
            this.boundingBoxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.Location = new System.Drawing.Point(310, 32);
            this.timerText.Multiline = true;
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(102, 34);
            this.timerText.TabIndex = 35;
            this.timerText.Text = "1";
            this.timerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmCustom
            // 
            this.confirmCustom.Location = new System.Drawing.Point(202, 557);
            this.confirmCustom.Name = "confirmCustom";
            this.confirmCustom.Size = new System.Drawing.Size(98, 42);
            this.confirmCustom.TabIndex = 38;
            this.confirmCustom.Text = "OK";
            this.confirmCustom.UseVisualStyleBackColor = true;
            this.confirmCustom.Click += new System.EventHandler(this.confirmCustom_Click);
            // 
            // cancelCustom
            // 
            this.cancelCustom.Location = new System.Drawing.Point(385, 559);
            this.cancelCustom.Name = "cancelCustom";
            this.cancelCustom.Size = new System.Drawing.Size(98, 38);
            this.cancelCustom.TabIndex = 39;
            this.cancelCustom.Text = "Cancel";
            this.cancelCustom.UseVisualStyleBackColor = true;
            this.cancelCustom.Click += new System.EventHandler(this.cancelCustom_Click);
            // 
            // startupBoot
            // 
            this.startupBoot.AutoSize = true;
            this.startupBoot.Location = new System.Drawing.Point(202, 154);
            this.startupBoot.Name = "startupBoot";
            this.startupBoot.Size = new System.Drawing.Size(74, 21);
            this.startupBoot.TabIndex = 40;
            this.startupBoot.Text = "Enable";
            this.startupBoot.UseVisualStyleBackColor = true;
            this.startupBoot.CheckedChanged += new System.EventHandler(this.startupBoot_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Boot on Startup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Reboot on Crash";
            // 
            // crashReboot
            // 
            this.crashReboot.AutoSize = true;
            this.crashReboot.Location = new System.Drawing.Point(202, 197);
            this.crashReboot.Name = "crashReboot";
            this.crashReboot.Size = new System.Drawing.Size(74, 21);
            this.crashReboot.TabIndex = 44;
            this.crashReboot.Text = "Enable";
            this.crashReboot.UseVisualStyleBackColor = true;
            this.crashReboot.CheckedChanged += new System.EventHandler(this.crashReboot_CheckedChanged);
            // 
            // CustomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 628);
            this.Controls.Add(this.crashReboot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startupBoot);
            this.Controls.Add(this.cancelCustom);
            this.Controls.Add(this.confirmCustom);
            this.Controls.Add(this.boxSizePlus);
            this.Controls.Add(this.boundingBoxMinus);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.timePlus);
            this.Controls.Add(this.timeMinus);
            this.Controls.Add(this.boundingBoxText);
            this.Controls.Add(this.clickAndDrag);
            this.Controls.Add(this.doubleClick);
            this.Controls.Add(this.rightClick);
            this.Controls.Add(this.leftClick);
            this.Controls.Add(this.contextClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayClickDragMode);
            this.Controls.Add(this.displayDoubleMode);
            this.Controls.Add(this.displayRightMode);
            this.Controls.Add(this.displaySleepMode);
            this.Controls.Add(this.displayLeftMode);
            this.Controls.Add(this.displayContextMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boundingBoxLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Name = "CustomUI";
            this.Text = "CustomUI";
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label boundingBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox displayContextMode;
        private System.Windows.Forms.CheckBox displayLeftMode;
        private System.Windows.Forms.CheckBox displaySleepMode;
        private System.Windows.Forms.CheckBox displayRightMode;
        private System.Windows.Forms.CheckBox displayDoubleMode;
        private System.Windows.Forms.CheckBox displayClickDragMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.Button timeMinus;
        private System.Windows.Forms.Button timePlus;
        private System.Windows.Forms.Button boundingBoxMinus;
        private System.Windows.Forms.Button boxSizePlus;
        private System.Windows.Forms.TextBox boundingBoxText;
        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.Button confirmCustom;
        private System.Windows.Forms.Button cancelCustom;
        private System.Windows.Forms.CheckBox startupBoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox crashReboot;
    }
}