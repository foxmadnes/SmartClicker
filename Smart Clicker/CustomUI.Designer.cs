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
            this.timerSelectBox = new System.Windows.Forms.NumericUpDown();
            this.boundingBoxLabel = new System.Windows.Forms.Label();
            this.boundingBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayContextMode = new System.Windows.Forms.CheckBox();
            this.displayLeftMode = new System.Windows.Forms.CheckBox();
            this.displaySleepMode = new System.Windows.Forms.CheckBox();
            this.displayRightMode = new System.Windows.Forms.CheckBox();
            this.displayDoubleMode = new System.Windows.Forms.CheckBox();
            this.displayClickDragMode = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextClick = new System.Windows.Forms.PictureBox();
            this.leftClick = new System.Windows.Forms.PictureBox();
            this.rightClick = new System.Windows.Forms.PictureBox();
            this.doubleClick = new System.Windows.Forms.PictureBox();
            this.clickAndDrag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).BeginInit();
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
            // timerSelectBox
            // 
            this.timerSelectBox.Location = new System.Drawing.Point(386, 46);
            this.timerSelectBox.Name = "timerSelectBox";
            this.timerSelectBox.Size = new System.Drawing.Size(119, 22);
            this.timerSelectBox.TabIndex = 2;
            this.timerSelectBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerSelectBox.ValueChanged += new System.EventHandler(this.timerSelectBox_ValueChanged);
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
            // boundingBox
            // 
            this.boundingBox.Location = new System.Drawing.Point(385, 90);
            this.boundingBox.Name = "boundingBox";
            this.boundingBox.Size = new System.Drawing.Size(120, 22);
            this.boundingBox.TabIndex = 4;
            this.boundingBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.boundingBox.ValueChanged += new System.EventHandler(this.boundingBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu Layout:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select which icons will be displayed";
            // 
            // displayContextMode
            // 
            this.displayContextMode.AutoSize = true;
            this.displayContextMode.Location = new System.Drawing.Point(202, 272);
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
            this.displayLeftMode.Location = new System.Drawing.Point(385, 272);
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
            this.displaySleepMode.Location = new System.Drawing.Point(19, 272);
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
            this.displayRightMode.Location = new System.Drawing.Point(19, 425);
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
            this.displayDoubleMode.Location = new System.Drawing.Point(202, 425);
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
            this.displayClickDragMode.Location = new System.Drawing.Point(385, 425);
            this.displayClickDragMode.Name = "displayClickDragMode";
            this.displayClickDragMode.Size = new System.Drawing.Size(122, 21);
            this.displayClickDragMode.TabIndex = 22;
            this.displayClickDragMode.Text = "Click and Drag";
            this.displayClickDragMode.UseVisualStyleBackColor = true;
            this.displayClickDragMode.CheckedChanged += new System.EventHandler(this.displayClickDragMode_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // contextClick
            // 
            this.contextClick.BackColor = System.Drawing.SystemColors.Window;
            this.contextClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextClick.Image = ((System.Drawing.Image)(resources.GetObject("contextClick.Image")));
            this.contextClick.Location = new System.Drawing.Point(202, 174);
            this.contextClick.Name = "contextClick";
            this.contextClick.Size = new System.Drawing.Size(98, 82);
            this.contextClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextClick.TabIndex = 24;
            this.contextClick.TabStop = false;
            // 
            // leftClick
            // 
            this.leftClick.BackColor = System.Drawing.SystemColors.Window;
            this.leftClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftClick.Image = ((System.Drawing.Image)(resources.GetObject("leftClick.Image")));
            this.leftClick.Location = new System.Drawing.Point(386, 174);
            this.leftClick.Name = "leftClick";
            this.leftClick.Size = new System.Drawing.Size(98, 82);
            this.leftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftClick.TabIndex = 25;
            this.leftClick.TabStop = false;
            // 
            // rightClick
            // 
            this.rightClick.BackColor = System.Drawing.SystemColors.Window;
            this.rightClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightClick.Image = ((System.Drawing.Image)(resources.GetObject("rightClick.Image")));
            this.rightClick.Location = new System.Drawing.Point(26, 311);
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(98, 90);
            this.rightClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightClick.TabIndex = 26;
            this.rightClick.TabStop = false;
            // 
            // doubleClick
            // 
            this.doubleClick.BackColor = System.Drawing.SystemColors.Window;
            this.doubleClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doubleClick.Image = ((System.Drawing.Image)(resources.GetObject("doubleClick.Image")));
            this.doubleClick.Location = new System.Drawing.Point(202, 311);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(98, 98);
            this.doubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleClick.TabIndex = 27;
            this.doubleClick.TabStop = false;
            // 
            // clickAndDrag
            // 
            this.clickAndDrag.BackColor = System.Drawing.SystemColors.Window;
            this.clickAndDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("clickAndDrag.Image")));
            this.clickAndDrag.Location = new System.Drawing.Point(385, 311);
            this.clickAndDrag.Name = "clickAndDrag";
            this.clickAndDrag.Size = new System.Drawing.Size(98, 97);
            this.clickAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickAndDrag.TabIndex = 28;
            this.clickAndDrag.TabStop = false;
            // 
            // CustomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 472);
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
            this.Controls.Add(this.boundingBox);
            this.Controls.Add(this.boundingBoxLabel);
            this.Controls.Add(this.timerSelectBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label1);
            this.Name = "CustomUI";
            this.Text = "CustomUI";
            ((System.ComponentModel.ISupportInitialize)(this.timerSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickAndDrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.NumericUpDown timerSelectBox;
        private System.Windows.Forms.Label boundingBoxLabel;
        private System.Windows.Forms.NumericUpDown boundingBox;
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
    }
}