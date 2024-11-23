using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K4os.Compression.LZ4.Encoders;
using MySql.Data.MySqlClient;

namespace ExampleWork
{
    public partial class Loginpage : Form
    {
		private string  validateLogin(string Username, string Password)
		{
			string role = null;
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=managment";

				MySqlConnection conn = new MySqlConnection(connstring);
				conn.Open();
				string sqlUpdateQuery = "SELECT Role from Login where Us = @Us and Ps = @Ps";
			MySqlCommand cmd = new MySqlCommand(sqlUpdateQuery, conn);
				cmd.Parameters.AddWithValue("@Us", Username);
				cmd.Parameters.AddWithValue("@Ps", Password);

				var result = cmd.ExecuteScalar();
				if (result != null)
				{
					role = result.ToString();
				}
				else
				{
					MessageBox.Show("Invalid Password or Username");
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return role;
		}

        public Loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			string username = textBox3.Text;
			string password = textBox4.Text;

			string role = validateLogin(username, password);

			if (!string.IsNullOrEmpty(role))
			{

				if((role == "Admin") || (role == "admin"))
				{
					MessageBox.Show("Login was successful");
					Main_menu main_Menu = new Main_menu();
					main_Menu.Show();
					
				}
				else if ((role == "User") || (role == "user"))
				{
					MessageBox.Show("Login was successful");
					Main_menu1 main_Menu1 = new Main_menu1();
					main_Menu1.Show();
					
				}
				else
				{
					MessageBox.Show("Invalid Password or Username or it may be that you don't have access");
				}
			}

		}
		
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
            string Login = textBox3.Text;


		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
            string passWord = textBox4.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
