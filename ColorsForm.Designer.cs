﻿namespace LabLappolainen2
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.Location = new System.Drawing.Point(51, 26);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(167, 23);
            this.Scroll_Red.TabIndex = 0;
            this.Scroll_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Red_Scroll);
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.Scroll_Red_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.Location = new System.Drawing.Point(51, 95);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(167, 23);
            this.Scroll_Blue.TabIndex = 1;
            this.Scroll_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Blue_Scroll);
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.Location = new System.Drawing.Point(51, 61);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(167, 23);
            this.Scroll_Green.TabIndex = 2;
            this.Scroll_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Green_Scroll);
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.Scroll_Green_ValueChanged);
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(240, 29);
            this.numeric_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(42, 20);
            this.numeric_Red.TabIndex = 3;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.Numeric_Red_ValueChanged);
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(240, 95);
            this.numeric_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(42, 20);
            this.numeric_Blue.TabIndex = 4;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.Numeric_Blue_ValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(240, 61);
            this.numeric_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(42, 20);
            this.numeric_Green.TabIndex = 5;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.Numeric_Green_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(288, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 93);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Other Colors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(378, 174);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Red);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.ColorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}