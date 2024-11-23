using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWork
{
	public partial class Add_Task_Page : Form
	{
		static bool add_Task(string Tn)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=managment";

				MySqlConnection conn = new MySqlConnection(connstring);
				conn.Open();
				
				string sqlUpdateQuery = "insert into tasks (Tn) Values(@Tn)";
				
				MySqlCommand cmd = new MySqlCommand(sqlUpdateQuery, conn);
				cmd.Parameters.AddWithValue("@Tn", Tn);
				
				int rowsaffected = cmd.ExecuteNonQuery();
				
				if (rowsaffected > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}

		}

		public Add_Task_Page()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string Ts = textBox5.Text;
			bool trueOrFalse = false;

			trueOrFalse = add_Task(Ts);

			if (trueOrFalse)
			{
				MessageBox.Show("Task Created");
				Main_menu1 MainMenu = new Main_menu1();
				MainMenu.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Task creation failed. Try again");
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Task_Page task_Page = new Task_Page();
			task_Page.Show();
			this.Close();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
	
}
