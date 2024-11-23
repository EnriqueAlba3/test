using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWork
{
	public partial class Task_Page : Form
	{
		private DataGridView dataGridView1;

		public DataTable get_data(string connString, string query)
		{

			MySqlConnection conn = new MySqlConnection(connString);
			conn.Open();

			MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

			DataTable dt = new DataTable();
			dataAdapter.Fill(dt);
			return dt;
		}
		public Task_Page()
		{
			InitializeComponent();

			dataGridView1 = new DataGridView();
			dataGridView1.Size = new System.Drawing.Size(760, 425);
			dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.Controls.Add(dataGridView1);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Main_menu1 menu = new Main_menu1();
			menu.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Add_Task_Page task_Page = new Add_Task_Page();
			task_Page.Show();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Delete_Task_Page delete__page = new Delete_Task_Page();
			delete__page.Show();
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string conn = "server=localhost;uid=root;pwd=;database=managment";
			string sqlUpdateQuery = "select * from tasks";

			DataTable dt = get_data(conn, sqlUpdateQuery);

			if (dt != null)
			{
				// Bind data to DataGridView
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("No data returned from database.");
			}
		}
	}
}
