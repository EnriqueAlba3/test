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
	public partial class Add_Inventory_Page : Form
	{
		static bool add_Inventory(string Name, string total)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=managment";

				MySqlConnection conn = new MySqlConnection(connstring);
				conn.Open();

				string sqlUpdateQuery = "insert into inventory (Name,total) Values(@Name,@total)";

				MySqlCommand cmd = new MySqlCommand(sqlUpdateQuery, conn);
				cmd.Parameters.AddWithValue("@Name", Name);
				cmd.Parameters.AddWithValue("@total", total);

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
		public Add_Inventory_Page()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string Name = textBox6.Text;
			string total = textBox5.Text;
			bool trueOrFalse = false;

			trueOrFalse = add_Inventory(Name,total);

			if (trueOrFalse)
			{
				MessageBox.Show("Inventory Created");
				Main_menu1 MainMenu = new Main_menu1();
				MainMenu.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Inventory creation failed. Try again");
			}
		}



private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Inventory_Page inventoryPage = new Inventory_Page();
			inventoryPage.Show();
			this.Close();
		}
	}

	}
