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
	public partial class Modify_Stock : Form
	{
		static bool modify_Inventory(string Name, string total)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=managment";

				MySqlConnection conn = new MySqlConnection(connstring);
				conn.Open();
				string sqlUpdateQuery = "Update inventory set total = @total where Name = @Name";

				MySqlCommand cmd = new MySqlCommand(sqlUpdateQuery, conn);
				cmd.Parameters.AddWithValue("@total", total);
				cmd.Parameters.AddWithValue("@Name", Name);

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

		public Modify_Stock()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Inventory_Page inventoryPage = new Inventory_Page();
			inventoryPage.Show();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string Name = textBox6.Text;
			string total = textBox5.Text;
			bool trueOrFalse = false;

			trueOrFalse = modify_Inventory(Name, total);

			if (trueOrFalse)
			{
				MessageBox.Show("Modification completed");
				Main_menu1 MainMenu = new Main_menu1();
				MainMenu.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Modification failed. Try again");
			}
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
