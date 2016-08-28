using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void hRDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Username = "UserName1";
            String Password ="1234";


            if ((textBox1.Text == Username) && (textBox2.Text == Password))
            {
                Employees frm = new Employees();
                frm.Show();
              
            }

            else
            {
                MessageBox.Show("Incorrect Password or Username");

            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
