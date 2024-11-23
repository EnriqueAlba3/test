namespace ExampleWork
{
	partial class Modify_Stock
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(373, 182);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(181, 65);
			this.button2.TabIndex = 20;
			this.button2.Text = "Finished Modifying";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(373, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 65);
			this.button1.TabIndex = 19;
			this.button1.Text = "Return to Previous Page";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(24, 116);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(151, 22);
			this.textBox6.TabIndex = 18;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(24, 223);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(151, 22);
			this.textBox5.TabIndex = 17;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(24, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(151, 22);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "Enter Item Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 22);
			this.textBox2.TabIndex = 15;
			this.textBox2.Text = "Enter New Item Value";
			// 
			// Modify_Stock
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
			this.Name = "Modify_Stock";
			this.Text = "Modify_Stock";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
	}
}