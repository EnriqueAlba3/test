namespace ExampleWork
{
	partial class Add_Task_Page
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
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(21, 130);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(151, 22);
			this.textBox5.TabIndex = 7;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(21, 79);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 22);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Task Name";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(313, 31);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(184, 70);
			this.button3.TabIndex = 8;
			this.button3.Text = "Return to Previous Page";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(313, 125);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(184, 71);
			this.button4.TabIndex = 9;
			this.button4.Text = "Finished Adding Task";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Add_Task_Page
			// 
			this.ClientSize = new System.Drawing.Size(649, 373);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox2);
			this.Name = "Add_Task_Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}