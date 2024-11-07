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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 inventory = new Form3();
            inventory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 task = new Form4();
            task.Show();
        }
    }
}
