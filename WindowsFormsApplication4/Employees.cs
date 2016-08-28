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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet1.Employees);

        }

        private void fillByTitleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillByTitle(this.northwindDataSet1.Employees, titleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillByLastName(this.northwindDataSet1.Employees, lastNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void findbyEmployeeIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FindbyEmployeeID(this.northwindDataSet1.Employees, ((int)(System.Convert.ChangeType(employeeIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Customers frm = new Customers();
            frm.Show();
     
        }
    }
}
