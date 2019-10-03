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
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
   
    public partial class PayrollUIVeiw : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public PayrollUIVeiw()
        {
            InitializeComponent();
            lblEmployeeID.Visible = false;
        }

        private void PayrollUIVeiw_Load(object sender, EventArgs e)
        {
            String sql = "select * from Payroll_Staff";
            SqlDataAdapter sda = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvParollUI.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter EmployeeID");
            }
            else
            {

                String EmployeeID = (edtEmployeeID.Text);
                string sql1 = "Select * from Payroll_Staff where EmployeeID = '" + EmployeeID + "'";
                // String sql2 = "Select * from Payroll_Operators_Monthly_Salary where EmployeeID = '" + EmployeeID + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, con);
                // SqlDataAdapter sda2 = new SqlDataAdapter(sql2, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                //sda2.Fill(dt);
                dgvParollUI.DataSource = dt;
            } 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvParollUI.Update();
            dgvParollUI.Refresh();
        }

        private void edtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtEmployeeID.Text, @"^[0-9]*$"))
            {
                lblEmployeeID.Visible = true;
            }
            else
            {
                lblEmployeeID.Visible = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PayrollUIPaySlip paySlip = new PayrollUIPaySlip();
            paySlip.ShowDialog();
        }
    }
}
