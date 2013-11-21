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
            this.confirmCustom = new System.Windows.Forms.Button();
            this.cancelCustom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crashReboot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startupBoot = new System.Windows.Forms.CheckBox();
            this.boxSizePlus = new System.Windows.Forms.Button();
            this.boundingBoxMinus = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.TextBox();
            this.timePlus = new System.Windows.Forms.Button();
            this.timeMinus = new System.Windows.Forms.Button();
            this.boundingBoxText = new System.Windows.Forms.TextBox();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayClickDragMode = new System.Windows.Forms.CheckBox();
            this.displayDoubleMode = new System.Windows.Forms.CheckBox();
            this.displayRightMode = new System.Windows.Forms.CheckBox();
            this.displaySleepMode = new System.Windows.Forms.CheckBox();
            this.displayLeftMode = new System.Windows.Forms.CheckBox();
            this.displayContextMode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boundingBoxLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmCustom
            // 
            this.confirmCustom.Location = new System.Drawing.Point(354, 582);
            this.confirmCustom.Name = "confirmCustom";
            this.confirmCustom.Size = new System.Drawing.Size(98, 38);
            this.confirmCustom.TabIndex = 38;
            this.confirmCustom.Text = "Apply";
            this.confirmCustom.UseVisualStyleBackColor = true;
            this.confirmCustom.Click += new System.EventHandler(this.confirmCustom_Click);
            // 
            // cancelCustom
            // 
            this.cancelCustom.Location = new System.Drawing.Point(458, 582);
            this.cancelCustom.Name = "cancelCustom";
            this.cancelCustom.Size = new System.Drawing.Size(98, 38);
            this.cancelCustom.TabIndex = 39;
            this.cancelCustom.Text = "Cancel";
            this.cancelCustom.UseVisualStyleBackColor = true;
            this.cancelCustom.Click += new System.EventHandler(this.cancelCustom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 577);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crashReboot);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.startupBoot);
            this.tabPage1.Controls.Add(this.boxSizePlus);
            this.tabPage1.Controls.Add(this.boundingBoxMinus);
            this.tabPage1.Controls.Add(this.timerText);
            this.tabPage1.Controls.Add(this.timePlus);
            this.tabPage1.Controls.Add(this.timeMinus);
            this.tabPage1.Controls.Add(this.boundingBoxText);
            this.tabPage1.Controls.Add(this.clickAndDrag);
            this.tabPage1.Controls.Add(this.doubleClick);
            this.tabPage1.Controls.Add(this.rightClick);
            this.tabPage1.Controls.Add(this.leftClick);
            this.tabPage1.Controls.Add(this.contextClick);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.displayClickDragMode);
            this.tabPage1.Controls.Add(this.displayDoubleMode);
            this.tabPage1.Controls.Add(this.displayRightMode);
            this.tabPage1.Controls.Add(this.displaySleepMode);
            this.tabPage1.Controls.Add(this.displayLeftMode);
            this.tabPage1.Controls.Add(this.displayContextMode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.boundingBoxLabel);
            this.tabPage1.Controls.Add(this.timerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Context Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crashReboot
            // 
            this.crashReboot.AutoSize = true;
            this.crashReboot.Location = new System.Drawing.Point(224, 181);
            this.crashReboot.Name = "crashReboot";
            this.crashReboot.Size = new System.Drawing.Size(74, 21);
            this.crashReboot.TabIndex = 70;
            this.crashReboot.Text = "Enable";
            this.crashReboot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Reboot on Crash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Boot on Startup";
            // 
            // startupBoot
            // 
            this.startupBoot.AutoSize = true;
            this.startupBoot.Location = new System.Drawing.Point(224, 138);
            this.startupBoot.Name = "startupBoot";
            this.startupBoot.Size = new System.Drawing.Size(74, 21);
            this.startupBoot.TabIndex = 67;
            this.startupBoot.Text = "Enable";
            this.startupBoot.UseVisualStyleBackColor = true;
            // 
            // boxSizePlus
            // 
            this.boxSizePlus.BackgroundImage = global::Smart_Clicker.Properties.Resources.plusblack;
            this.boxSizePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxSizePlus.Location = new System.Drawing.Point(454, 68);
            this.boxSizePlus.Name = "boxSizePlus";
            this.boxSizePlus.Size = new System.Drawing.Size(75, 34);
            this.boxSizePlus.TabIndex = 66;
            this.boxSizePlus.UseVisualStyleBackColor = true;
            // 
            // boundingBoxMinus
            // 
            this.boundingBoxMinus.Image = global::Smart_Clicker.Properties.Resources.minus_black;
            this.boundingBoxMinus.Location = new System.Drawing.Point(224, 68);
            this.boundingBoxMinus.Name = "boundingBoxMinus";
            this.boundingBoxMinus.Size = new System.Drawing.Size(83, 34);
            this.boundingBoxMinus.TabIndex = 65;
            this.boundingBoxMinus.UseVisualStyleBackColor = true;
            // 
            // timerText
            // 
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.Location = new System.Drawing.Point(332, 16);
            this.timerText.Multiline = true;
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(102, 34);
            this.timerText.TabIndex = 64;
            this.timerText.Text = "1";
            this.timerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timePlus
            // 
            this.timePlus.BackgroundImage = global::Smart_Clicker.Properties.Resources.plusblack;
            this.timePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timePlus.ImageKey = "(none)";
            this.timePlus.Location = new System.Drawing.Point(454, 16);
            this.timePlus.Name = "timePlus";
            this.timePlus.Size = new System.Drawing.Size(75, 34);
            this.timePlus.TabIndex = 63;
            this.timePlus.UseVisualStyleBackColor = true;
            // 
            // timeMinus
            // 
            this.timeMinus.Image = global::Smart_Clicker.Properties.Resources.minus_black;
            this.timeMinus.Location = new System.Drawing.Point(224, 16);
            this.timeMinus.Name = "timeMinus";
            this.timeMinus.Size = new System.Drawing.Size(83, 34);
            this.timeMinus.TabIndex = 62;
            this.timeMinus.UseVisualStyleBackColor = true;
            // 
            // boundingBoxText
            // 
            this.boundingBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundingBoxText.Location = new System.Drawing.Point(332, 71);
            this.boundingBoxText.Multiline = true;
            this.boundingBoxText.Name = "boundingBoxText";
            this.boundingBoxText.Size = new System.Drawing.Size(102, 34);
            this.boundingBoxText.TabIndex = 61;
            this.boundingBoxText.Text = "25";
            this.boundingBoxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(407, 398);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(98, 97);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 60;
            this.clickAndDrag.TabStop = false;
            // 
            // doubleClick
            // 
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(224, 398);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(98, 98);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 59;
            this.doubleClick.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(48, 398);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(98, 90);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 58;
            this.rightClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(408, 261);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(98, 82);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 57;
            this.leftClick.TabStop = false;
            // 
            // contextClick
            // 
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(224, 261);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(98, 82);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 56;
            this.contextClick.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // displayClickDragMode
            // 
            this.displayClickDragMode.AutoSize = true;
            this.displayClickDragMode.Location = new System.Drawing.Point(407, 512);
            this.displayClickDragMode.Name = "displayClickDragMode";
            this.displayClickDragMode.Size = new System.Drawing.Size(122, 21);
            this.displayClickDragMode.TabIndex = 54;
            this.displayClickDragMode.Text = "Click and Drag";
            this.displayClickDragMode.UseVisualStyleBackColor = true;
            // 
            // displayDoubleMode
            // 
            this.displayDoubleMode.AutoSize = true;
            this.displayDoubleMode.Location = new System.Drawing.Point(224, 512);
            this.displayDoubleMode.Name = "displayDoubleMode";
            this.displayDoubleMode.Size = new System.Drawing.Size(147, 21);
            this.displayDoubleMode.TabIndex = 53;
            this.displayDoubleMode.Text = "Double Click Mode";
            this.displayDoubleMode.UseVisualStyleBackColor = true;
            // 
            // displayRightMode
            // 
            this.displayRightMode.AutoSize = true;
            this.displayRightMode.Location = new System.Drawing.Point(41, 512);
            this.displayRightMode.Name = "displayRightMode";
            this.displayRightMode.Size = new System.Drawing.Size(135, 21);
            this.displayRightMode.TabIndex = 52;
            this.displayRightMode.Text = "Right Click Mode";
            this.displayRightMode.UseVisualStyleBackColor = true;
            // 
            // displaySleepMode
            // 
            this.displaySleepMode.AutoSize = true;
            this.displaySleepMode.Location = new System.Drawing.Point(41, 359);
            this.displaySleepMode.Name = "displaySleepMode";
            this.displaySleepMode.Size = new System.Drawing.Size(105, 21);
            this.displaySleepMode.TabIndex = 51;
            this.displaySleepMode.Text = "Sleep Mode";
            this.displaySleepMode.UseVisualStyleBackColor = true;
            // 
            // displayLeftMode
            // 
            this.displayLeftMode.AutoSize = true;
            this.displayLeftMode.Location = new System.Drawing.Point(407, 359);
            this.displayLeftMode.Name = "displayLeftMode";
            this.displayLeftMode.Size = new System.Drawing.Size(126, 21);
            this.displayLeftMode.TabIndex = 50;
            this.displayLeftMode.Text = "Left Click Mode";
            this.displayLeftMode.UseVisualStyleBackColor = true;
            // 
            // displayContextMode
            // 
            this.displayContextMode.AutoSize = true;
            this.displayContextMode.Location = new System.Drawing.Point(224, 359);
            this.displayContextMode.Name = "displayContextMode";
            this.displayContextMode.Size = new System.Drawing.Size(116, 21);
            this.displayContextMode.TabIndex = 49;
            this.displayContextMode.Text = "Context Mode";
            this.displayContextMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Select which icons will be displayed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Menu Layout:";
            // 
            // boundingBoxLabel
            // 
            this.boundingBoxLabel.AutoSize = true;
            this.boundingBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundingBoxLabel.Location = new System.Drawing.Point(34, 68);
            this.boundingBoxLabel.Name = "boundingBoxLabel";
            this.boundingBoxLabel.Size = new System.Drawing.Size(129, 20);
            this.boundingBoxLabel.TabIndex = 46;
            this.boundingBoxLabel.Text = "Pixel sensitivity:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(35, 30);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(173, 20);
            this.timerLabel.TabIndex = 45;
            this.timerLabel.Text = "Seconds before Click:";
            // 
            // CustomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 628);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelCustom);
            this.Controls.Add(this.confirmCustom);
            this.Name = "CustomUI";
            this.Text = "CustomUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmCustom;
        private System.Windows.Forms.Button cancelCustom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox crashReboot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox startupBoot;
        private System.Windows.Forms.Button boxSizePlus;
        private System.Windows.Forms.Button boundingBoxMinus;
        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.Button timePlus;
        private System.Windows.Forms.Button timeMinus;
        private System.Windows.Forms.TextBox boundingBoxText;
        private System.Windows.Forms.PictureBox clickAndDrag;
        private System.Windows.Forms.PictureBox doubleClick;
        private System.Windows.Forms.PictureBox rightClick;
        private System.Windows.Forms.PictureBox leftClick;
        private System.Windows.Forms.PictureBox contextClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox displayClickDragMode;
        private System.Windows.Forms.CheckBox displayDoubleMode;
        private System.Windows.Forms.CheckBox displayRightMode;
        private System.Windows.Forms.CheckBox displaySleepMode;
        private System.Windows.Forms.CheckBox displayLeftMode;
        private System.Windows.Forms.CheckBox displayContextMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label boundingBoxLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TabPage tabPage2;
    }
}