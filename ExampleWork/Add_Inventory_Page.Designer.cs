﻿namespace ExampleWork
{
	partial class Add_Inventory_Page
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
			this.components = new System.ComponentModel.Container();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 170);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 22);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Enter Item Total";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 70);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(151, 22);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Enter Item Name";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(12, 221);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(151, 22);
			this.textBox5.TabIndex = 5;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(12, 114);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(151, 22);
			this.textBox6.TabIndex = 6;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(361, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 65);
			this.button1.TabIndex = 7;
			this.button1.Text = "Return to Previous Page";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(361, 180);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(181, 65);
			this.button2.TabIndex = 8;
			this.button2.Text = "Finished Adding";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Add_Inventory_Page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Name = "Add_Inventory_Page";
			this.Text = "Add_Inventory_Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}