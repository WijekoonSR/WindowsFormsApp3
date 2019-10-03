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
    public partial class EmployeeUIEditOperator : UserControl
    {
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        public EmployeeUIEditOperator()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                string EmployeeID = (txtEmployeeID.Text).ToString();
                sqlConnection.Open();
               // String sql1 = "Delete From Payroll_Operators where EmployeeID = '" + EmployeeID + "'";
               // String sql2 = "Delete From Payroll_Operators_Monthly_Salary where EmployeeID = '" + EmployeeID + "'";
               // String sql3 = "Delete From Payroll_Staff where EmployeeID = '" + EmployeeID + "'";
               // String sql4 = "Delete From Vehicle_Operators where EmployeeID = '" + EmployeeID + "'";
                String sql = "Delete From Employee where EmployeeID = '" + EmployeeID + "'";
                //String sq4 = "Delete From Vehicle_Operators where EmployeeID = '" + EmployeeID + "'";

               // SqlCommand cmd1 = new SqlCommand(sql1, sqlConnection);
               // SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
               // SqlCommand cmd3 = new SqlCommand(sql3, sqlConnection);
               // SqlCommand cmd4 = new SqlCommand(sql4, sqlConnection);
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                //cmd1.ExecuteNonQuery();
               // cmd2.ExecuteNonQuery();
               // cmd3.ExecuteNonQuery();
               // cmd4.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");
                sqlConnection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Eror" + ex);
            }
}
        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeID = (txtEmployeeID.Text).ToString();
            string Sql = "select * from Employee where EmployeeID = '" + EmployeeID + "'";
            SqlCommand cmd = new SqlCommand(Sql, sqlConnection);
            SqlCommand cmd2 = new SqlCommand("select * from Vehicle_Operators where EmployeeID = '" + EmployeeID + "'",sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sdr = cmd2.ExecuteReader();
                if (sdr.HasRows) {
                    while (sdr.Read())
                    {
                        txtLicense.Text = sdr.GetValue(0).ToString();
                    }
                }
                sqlConnection.Close();
                sqlConnection.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        txtfname.Text = read["FirstName"].ToString();
                        txtLname.Text = read["Lastname"].ToString();
                        cmbGender.Text = read["Gender"].ToString();
                        dateDOB.Value = Convert.ToDateTime(read["DOB"].ToString()).Date;
                        txtNIC.Text = read.GetValue(4).ToString();
                        txtContactNum.Text = read.GetValue(5).ToString();
                        txtEmail.Text = read.GetValue(6).ToString();
                        txtAddress01.Text = read.GetValue(7).ToString();
                        txtAddress02.Text = read.GetValue(8).ToString();
                        txtCity.Text = read.GetValue(9).ToString();
                        txtPostalCode.Text = read.GetValue(10).ToString();
                        cmbJobTitle.Text = read.GetValue(11).ToString();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string EmployeeID = (txtEmployeeID.Text).ToString();
            string fname = txtfname.Text;
            string lname = txtLname.Text;
            string gender = cmbGender.Text;
            string dob = dateDOB.Value.ToString("yyyy/MM/dd");
            string NIC = txtNIC.Text;
            string licenseNUm = txtLicense.Text;
            string ContactNum = txtContactNum.Text;
            string email = txtEmail.Text;
            string address01 = txtAddress01.Text;
            string address02 = txtAddress02.Text;
            string city = txtCity.Text;
            string postalCode = txtPostalCode.Text;
            string jobTitle = cmbJobTitle.Text;
            
            try
            {
                sqlConnection.Open();

                // String sql = "Upadate Payroll_Operators_Monthly_Salary SET BasicSalary = '"+BasicSalary+"', HousingAllowance = '"+HousingAllowance+"', MedicalAllowance = '"+MedicalAllowance+"', FoodAllowance = '"+FoodAllowance+"', OtherAllowance = '"+OtherAllowance+"', SalaryAdvance = '"+SalaryAdvance+"', ETF = '"+ETF+"', EPF = '"+EPF+"', Insurance = '"+Insurance+"' where PayrollMonthlyID = '"+EmployeeID+"'";
                String sql = "Update Employee SET FirstName = '" + fname + "', LastName = '" + lname + "', DOB = '" + dob + "', NIC = '" + NIC + "', ContactNumber = '" + ContactNum + "', Email = '" + email + "',  Address01 = '" + address01 + "', Address02 = '" + address02 + "', City = '" + city + "',PostalCode = '"+postalCode+"',Jobtitle ='"+jobTitle+"',Gender = '"+gender+ "'  where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucsess");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}
