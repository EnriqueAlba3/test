﻿namespace ExampleWork
{
    partial class Inventory_Page
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(43, 204);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 65);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add Inventory";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(43, 564);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(197, 65);
			this.button2.TabIndex = 1;
			this.button2.Text = "Main Menu";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(43, 383);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(197, 65);
			this.button3.TabIndex = 2;
			this.button3.Text = "View Inventory";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(43, 289);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(197, 65);
			this.button4.TabIndex = 3;
			this.button4.Text = "Remove Inventory";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::ExampleWork.Properties.Resources.openart_image_J6t8D7De_1730958770528_raw_removebg_preview;
			this.pictureBox2.Location = new System.Drawing.Point(489, 254);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(291, 251);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(556, 107);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 22);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "Inventory Menu";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(43, 471);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(197, 65);
			this.button5.TabIndex = 8;
			this.button5.Text = "Modify Stock of Item";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Inventory_Page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ExampleWork.Properties.Resources.blue;
			this.ClientSize = new System.Drawing.Size(1067, 679);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Inventory_Page";
			this.Text = "Form3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button5;
	}
}