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
    public partial class PayrollUIDailyRates : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public PayrollUIDailyRates()
        {
            
            InitializeComponent();
            lblWorkingHours.Visible = false;
            lblOT.Visible = false;
        }
        
        
        private void btnChangeOTRates_Click(object sender, EventArgs e)
        {
            PayrollUIOperaterChangeOTRates payOperaterChangeOT = new PayrollUIOperaterChangeOTRates();
            payOperaterChangeOT.ShowDialog();
           
        }

        private void btnSetDailyRates_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            else if (edtWokingHours.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Working Hours");
            }
            else if (edtOT.Text.Equals(""))
            {
                MessageBox.Show("Please Enter OT");
            }
            else if (drpOTRate.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select OTRate Value");
            }
            else if (lblWorkingHours.Visible == true || lblOT.Visible == true)
            {
                MessageBox.Show("inavalid filed available");
            }
            else
            {
                try
                {
                    con.Open();


                    if (con.State == System.Data.ConnectionState.Open)
                    {


                        String SalaryDate = dateTimePayroll.Value.ToString("yyyy/MM/dd");
                        int WokingHours = Convert.ToInt32(edtWokingHours.Text);
                        int OT = Convert.ToInt32(edtOT.Text);
                        int OTRate = Convert.ToInt32(drpOTRate.selectedValue.ToString());
                        int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                        MessageBox.Show(WokingHours.ToString() + OT.ToString() + OTRate);

                        String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate, EmployeeID)" + "Values('" + SalaryDate + "','" + WokingHours + "','" + OT + "', '" + OTRate + "', '" + EmployeeID + "')";
                        //String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate, EmpolyeeID) Values('"+dateTimePayroll.Text+"', '"+edtWokingHours.Text+"','"+edtOT.Text+"' , '"+drpOTRate.Text+"',)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Succes");
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
            }
}
        private void edtWokingHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            else
            {
                //String SalaryDate = dateTimePayroll.Value.ToString("yyyy/MM/dd");
                int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                string Sql = "select * from Employee where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd = new SqlCommand(Sql, con);
                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {

                            edtName.Text = read.GetValue(1).ToString();
                            edtPossition.Text = read.GetValue(12).ToString();
                            edtCity.Text = read.GetValue(10).ToString();


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void edtWokingHours_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Regex.IsMatch(edtWokingHours.Text, @"^[0-9]*$"))
            {
                lblWorkingHours.Visible = false;
            }
            else
            {
                lblWorkingHours.Visible = true;
            }
        }

        private void edtOT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Regex.IsMatch(edtOT.Text, @"^[0-9]*$"))
            {
                lblOT.Visible = false;
            }
            else
            {
                lblOT.Visible = true;
            }
        }
        private void clear()
        {
            edtEmployeeID.Text = String.Empty;
            edtName.Text = String.Empty;
            edtWokingHours.Text = String.Empty;
            edtOT.Text = String.Empty;
           
        }
    }
    }
