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
    public partial class Main_menu1 : Form
    {
        public Main_menu1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory_Page inventory = new Inventory_Page();
            inventory.Show();
			this.Close();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Task_Page task = new Task_Page();
            task.Show();
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Loginpage loginPage = new Loginpage();
            loginPage.Show();
			this.Close();
		}
	}
}
