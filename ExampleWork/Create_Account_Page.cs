using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWork
{
	public partial class Create_Account_Page : Form
	{
		static bool createNewLogin(string Us, string Ps, string Role)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=managment";

				MySqlConnection conn = new MySqlConnection(connstring);
				conn.Open();
				string sqlUpdateQuery = "insert into login (Us,Ps,Role) Values(@Us,@Ps,@Role)";
				MySqlCommand cmd = new MySqlCommand(sqlUpdateQuery, conn);
				cmd.Parameters.AddWithValue("@Us", Us);
				cmd.Parameters.AddWithValue("@Ps", Ps);
				cmd.Parameters.AddWithValue("@Role", Role);
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
			catch(MySqlException ex) 
			{
				MessageBox.Show(ex.ToString());
				return false;
			}

		}
		public Create_Account_Page()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Main_menu mainMenu = new Main_menu();
			mainMenu.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string Us = textBox6.Text;
			string Ps = textBox5.Text;
			string Role = textBox1.Text;
			bool trueOrFalse = false;

			trueOrFalse = createNewLogin(Us, Ps, Role);

			if (trueOrFalse)
			{
				MessageBox.Show("Account Created");
				Main_menu MainMenu = new Main_menu();
				MainMenu.Show();
			}
			else
			{
				MessageBox.Show("Account creation failed. Try again");
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
