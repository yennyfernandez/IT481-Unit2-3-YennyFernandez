using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        private object form;
        private object db;
        private string ConnectionString;
        private object lbFound;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = "Data Source=REM\\SQLEXPRESS;database =northwind; integrated security = SSPI";
            SqlConnection con = new SqlConnection(conString);
            
            string selectSql = "select * from customers where CustomerID="+idtxt+"";
            SqlCommand cmd = new SqlCommand(selectSql, con);

            try
            {
                con.Open();
                SqlDataReader read = cmd.ExecuteReader(); 

                {
                    while (read.Read())
                    {
                        // idtxt.Text = (read["CustomerID"].ToString());
                        companytxt.Text = (read["CompanyName"].ToString());
                        cusnametxt.Text = (read["ContactName"].ToString());
                        titletxt.Text = (read["ContactTitle"].ToString());

                    }
                }
 
            }
            finally
            {
                con.Close();
            }
        }

    }
}