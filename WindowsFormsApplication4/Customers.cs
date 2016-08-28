using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
         private Class1.BooksEntities dbcontext =
          new Class1.BooksEntities();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Employees frm = new Employees();
                frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
               }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCustomerID(this.northwindDataSet.Customers, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByCustomerIDToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void fillByContactNameToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByCityToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCity(this.northwindDataSet.Customers, cityToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cityToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void findbyCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FindbyCustomerID(this.northwindDataSet.Customers, customerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void findbyCustomerIDToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
         
        }
    }
}