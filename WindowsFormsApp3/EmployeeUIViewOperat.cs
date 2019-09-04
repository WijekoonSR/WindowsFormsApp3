using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class EmployeeUIViewOperat : UserControl
    {
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        public EmployeeUIViewOperat()
        {
            InitializeComponent();
        }

        private void EmployeeUIView_Load(object sender, EventArgs e)
        {
            string EmployeeID = btnSearch.Text;
            string sql = "Select * from  Employee e inner join Vehicle_Operators v on v.EmployeeID = e.EmployeeID ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(txtEmployeeID.Text);
            string sql = "Select * from  Employee e inner join Vehicle_Operators v on v.EmployeeID = e.EmployeeID where e.EmployeeID = '" + EmployeeID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeID =btnSearch.Text;
            string sql = "Select * from  Employee e inner join Vehicle_Operators v on v.EmployeeID = e.EmployeeID where e.EmployeeID = '" + EmployeeID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

