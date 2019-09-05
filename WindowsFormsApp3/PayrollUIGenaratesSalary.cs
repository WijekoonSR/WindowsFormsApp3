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
    public partial class PayrollUIGenaratesSalary : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public PayrollUIGenaratesSalary()
        {
            InitializeComponent();
            
            lblBasicSalary.Visible = false;
            lblOtherAllowance.Visible = false;
            lblSalaryAdvance.Visible = false;
            lblETF.Visible = false;
            lblEPF.Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            PayrollUIGenerateSalaryChangeValues payGenerateSalaryChangeV = new PayrollUIGenerateSalaryChangeValues();
            payGenerateSalaryChangeV.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            else if (edtBasicSalary.Text.Equals(""))
            {
                MessageBox.Show("Basic Salary is empty");
            }

            else if (edtETF.Text.Equals(""))
            {
                MessageBox.Show("ETF is empty");
            }
            else if (edtEPF.Text.Equals(""))
            {
                MessageBox.Show("EPF is empty");
            }

            else if (drpHousingAllowance.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select Housing Allowance Value");
            }

            else if (drpMedicalAllowance.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select Medical Allowance Value");
            }
            else if (drpFoodAllowance.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select Food Allowance Value");
            }
            else if (drpInsurance.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select Insurdance Value");
            }
            else if (lblBasicSalary.Visible == true || lblETF.Visible == true || lblEPF.Visible == true || lblOtherAllowance.Visible == true || lblSalaryAdvance.Visible == true)
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
                        int BasicSalary = Convert.ToInt32(edtBasicSalary.Text);
                        int HousingAllowance = Convert.ToInt32(drpHousingAllowance.selectedValue.ToString());
                        int MedicalAllowance = Convert.ToInt32(drpMedicalAllowance.selectedValue.ToString());
                        int FoodAllowance = Convert.ToInt32(drpFoodAllowance.selectedValue.ToString());
                        int OtherAllowance = Convert.ToInt32(edtOtherAllowance.Text);
                        int SalaryAdvance = Convert.ToInt32(edtSalaryAdvance.Text);
                        int ETF = Convert.ToInt32(edtETF.Text);
                        int EPF = Convert.ToInt32(edtEPF.Text);
                        int Insurance = Convert.ToInt32(drpInsurance.selectedValue.ToString());
                        int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                        //int PayrollID = Convert.ToInt32()

                        // MessageBox.Show(WokingHours.ToString() + OT.ToString() + OTRate);
                        String sql2 = "Select PayrollID from Payroll_Operators where EmployeeID = '" + EmployeeID + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        int PayrollID = (int)cmd2.ExecuteScalar();
                        //MessageBox.Show(PayrollID.ToString());
                        String sql = "Insert into  Payroll_Operators_Monthly_Salary(SalaryDate, BasicSalary, HousingAllowance, MedicalAllowance, FoodAllowance, OtherAllowance, SalaryAdvance, ETF, EPF, Insurance, EmployeeID, PayrollID )" + "Values('" + SalaryDate + "','" + BasicSalary + "','" + HousingAllowance + "', '" + MedicalAllowance + "', '" + FoodAllowance + "', '" + OtherAllowance + "', '" + SalaryAdvance + "', '" + ETF + "', '" + EPF + "', '" + Insurance + "', '" + EmployeeID + "', '" + PayrollID + "')";
                        //String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate, EmpolyeeID) Values('"+dateTimePayroll.Text+"', '"+edtWokingHours.Text+"','"+edtOT.Text+"' , '"+drpOTRate.Text+"',)";
                        SqlCommand cmd1 = new SqlCommand(sql, con);
                        cmd1.ExecuteNonQuery();
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            else
            {
                string Sql = "select * from Employee";
                SqlCommand cmd = new SqlCommand(Sql, con);
                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            // MessageBox.Show(read["FirstName"].ToString());
                            //edtName.Text = (read["FistName"].ToString());
                            //edtName.Text = "name";
                            edtName.Text = read.GetValue(1).ToString();
                            edtPossition.Text = read.GetValue(11).ToString();
                            edtCity.Text = read.GetValue(9).ToString();

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
        private void btnAddHousingAllowance_Click(object sender, EventArgs e)
        {
           // drpHousingAllowance.Items.SetValue()
        }

        private void edtWokingHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void edtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtBasicSalary.Text, @"^[0-9]*$"))
            {
                lblBasicSalary.Visible = false;
            }
            else
            {
                lblBasicSalary.Visible = true;
            }
        }

        private void edtOtherAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtOtherAllowance.Text, @"^[0-9]*$"))
            {
                lblOtherAllowance.Visible = false;
            }
            else
            {
                lblOtherAllowance.Visible = true;
            }
        }

        private void edtSalaryAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtSalaryAdvance.Text, @"^[0-9]*$"))
            {
                lblSalaryAdvance.Visible = false;
            }
            else
            {
                lblSalaryAdvance.Visible = true;
            }
        }

        private void edtEPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtEPF.Text, @"^[0-9]*$"))
            {
                lblEPF.Visible = false;
            }
            else
            {
                lblEPF.Visible = true;
            }
        }

        private void edtETF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtETF.Text, @"^[0-9]*$"))
            {
                lblETF.Visible = false;
            }
            else
            {
                lblETF.Visible = true;
            }
        }
        private void clear()
        {
            edtEmployeeID.Text = String.Empty;
            edtName.Text = String.Empty;
            txtOT.Text = String.Empty;
            edtWokingHours.Text = String.Empty;
            edtBasicSalary.Text = String.Empty;
            drpHousingAllowance.selectedIndex = -1;
            drpMedicalAllowance.selectedIndex = -1;
            drpFoodAllowance.selectedIndex = -1;
            edtOtherAllowance.Text = String.Empty;
            edtSalaryAdvance.Text = String.Empty;
            edtETF.Text = String.Empty;
            edtEPF.Text = String.Empty;
            drpInsurance.selectedIndex = -1;
        }
    }
}
