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
    public partial class PayrollUIEditOperater : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public PayrollUIEditOperater()
        {
            InitializeComponent();
            lblEmployeeID.Visible = false;
            lblTotalWorkingHours.Visible = false;
            lblTotalOT.Visible = false;
            lblBasicSalary.Visible = false;
            lblHousingAllowance.Visible = false;
            lblMedicalAllowance.Visible = false;
            lblFoodAllowance.Visible = false;
            lblOtherAllowance.Visible = false;
            lblSalaryAdvance.Visible = false;
            lblETF.Visible = false;
            lblEPF.Visible = false;
            lblInsurance.Visible = false;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {

            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter EmployeeID");
            }
            else
            {

                int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                string Sql1 = "select * from Employee where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd1 = new SqlCommand(Sql1, con);

                String sql2 = "select * from Payroll_Operators_Monthly_Salary where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);


                String sql3 = "select * from Payroll_Operators where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, con);

                String sql4 = "select * from Payroll_Operators where EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd4 = new SqlCommand(sql4, con);





                try
                {

                    con.Open();

                    using (SqlDataReader read = cmd1.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            // MessageBox.Show(read["FirstName"].ToString());
                            //edtName.Text = (read["FistName"].ToString());
                            //edtName.Text = "name";
                            edtName.Text = read.GetValue(1).ToString();
                            

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
                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd2.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            // MessageBox.Show(read["FirstName"].ToString());
                            //edtName.Text = (read["FistName"].ToString());
                            //edtName.Text = "name";
                            //edtWokingHours.Text = read.GetValue(2).ToString();
                            //edtOT.Text = read.GetValue(3).ToString();
                            edtBasicSalary.Text = read.GetValue(4).ToString();
                            edtHousingAllowance.Text = read.GetValue(5).ToString();
                            edtMedicalAllowance.Text = read.GetValue(6).ToString();
                            edtFoodAllowance.Text = read.GetValue(7).ToString();
                            edtOtherAllowance.Text = read.GetValue(8).ToString();
                            edtSalaryAdvance.Text = read.GetValue(9).ToString();
                            edtETF.Text = read.GetValue(10).ToString();
                            edtEPF.Text = read.GetValue(11).ToString();
                            edtInsurance.Text = read.GetValue(12).ToString();


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


                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd3.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            edtWokingHours.Text = read.GetValue(2).ToString();


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

                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd4.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            edtOT.Text = read.GetValue(3).ToString();

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
        private void btnEdit_Click(object sender, EventArgs e)
        {
             

            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter EmployeeID");
            }
            else if (edtWokingHours.Text.Equals(""))
            {
                MessageBox.Show("Working Hours is empty");
            }
            else if (edtOT.Text.Equals(""))
            {
                MessageBox.Show("OT is empty");
            }

            else if (edtBasicSalary.Text.Equals(""))
            {
                MessageBox.Show("Basic Salary is empty");
            }
            else if (edtHousingAllowance.Text.Equals(""))
            {
                MessageBox.Show("Please select Housing Allowance Value");
            }

            else if (edtMedicalAllowance.Text.Equals(""))
            {
                MessageBox.Show("Please select Medical Allowance Value");
            }
            else if (edtFoodAllowance.Text.Equals(""))
            {
                MessageBox.Show("Please select Food Allowance Value");
            }
            else if (edtOtherAllowance.Text.Equals(""))
            {
                MessageBox.Show("Please select Other Allowance Value");
            }
            else if (edtSalaryAdvance.Text.Equals(""))
            {
                MessageBox.Show("Please select Salary Advance Value");
            }
            else if (edtEPF.Text.Equals(""))
            {
                MessageBox.Show("EPF is empty");
            }
            else if (edtETF.Text.Equals(""))
            {
                MessageBox.Show("ETF is empty");
            }

            else if (edtInsurance.Text.Equals(""))
            {
                MessageBox.Show("Please select Insurdance Value");
            }
            else if (lblEmployeeID.Visible == true || lblTotalWorkingHours.Visible == true || lblTotalOT.Visible == true || lblBasicSalary.Visible == true || lblHousingAllowance.Visible == true || lblMedicalAllowance.Visible == true || lblFoodAllowance.Visible == true || lblETF.Visible == true || lblEPF.Visible == true || lblOtherAllowance.Visible == true || lblSalaryAdvance.Visible == true || lblInsurance.Visible == true)
            {
                MessageBox.Show("inavalid filed available");
            }


            else
            {
                int TotalWorkingHours = Convert.ToInt32(edtWokingHours.Text);
                int TotalOT = Convert.ToInt32(edtOT.Text);
                int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                int BasicSalary = Convert.ToInt32(edtBasicSalary.Text);
                int HousingAllowance = Convert.ToInt32(edtHousingAllowance.Text);
                int MedicalAllowance = Convert.ToInt32(edtMedicalAllowance.Text);
                int FoodAllowance = Convert.ToInt32(edtFoodAllowance.Text);
                int OtherAllowance = Convert.ToInt32(edtOtherAllowance.Text);
                int SalaryAdvance = Convert.ToInt32(edtSalaryAdvance.Text);
                int ETF = Convert.ToInt32(edtETF.Text);
                int EPF = Convert.ToInt32(edtEPF.Text);
                int Insurance = Convert.ToInt32(edtInsurance.Text);
                {

                    try
                    {
                        con.Open();

                        // String sql = "Upadate Payroll_Operators_Monthly_Salary SET BasicSalary = '"+BasicSalary+"', HousingAllowance = '"+HousingAllowance+"', MedicalAllowance = '"+MedicalAllowance+"', FoodAllowance = '"+FoodAllowance+"', OtherAllowance = '"+OtherAllowance+"', SalaryAdvance = '"+SalaryAdvance+"', ETF = '"+ETF+"', EPF = '"+EPF+"', Insurance = '"+Insurance+"' where PayrollMonthlyID = '"+EmployeeID+"'";
                        String sql = "Update Payroll_Operators_Monthly_Salary SET TotalWorkingHours = '" + TotalWorkingHours + "', TotalOT = '" + TotalOT + "',  BasicSalary = '" + BasicSalary + "', HousingAllowance = '" + HousingAllowance + "', MedicalAllowance = '" + MedicalAllowance + "', FoodAllowance = '" + FoodAllowance + "', OtherAllowance = '" + OtherAllowance + "', SalaryAdvance = '" + SalaryAdvance + "',  ETF = '" + ETF + "', EPF = '" + EPF + "', Insurance = '" + Insurance + "'  where EmployeeID = '" + EmployeeID + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sucsess");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    finally
                    {
                        con.Close();
                        clear();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter EmployeeID");
            }
            else
            {
                int EmployeeID = Convert.ToInt32(edtEmployeeID.Text);
                try
                {
                    con.Open();
                    String sql1 = "DELETE FROM Payroll_Operators WHERE EmployeeID ='" + EmployeeID + "'";
                    String sql2 = "DELETE FROM Payroll_Operators_Monthly_Salary WHERE EmployeeID ='" + EmployeeID + "'";

                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    //cmd.ExecuteNonQuery();
                    // MessageBox.Show("Sucsess");
                    cmd2.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Data record deleted!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    clear();
                    //DisableButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void edtWokingHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtWokingHours.Text, @"^[0-9]*$"))
            {
                lblTotalWorkingHours.Visible = false;
            }
            else
            {
                lblTotalWorkingHours.Visible = true;
            }
        }

        private void edtOT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtOT.Text, @"^[0-9]*$"))
            {
                lblTotalOT.Visible = false;
            }
            else
            {
                lblTotalOT.Visible = true;
            }
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

        private void edtHousingAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtHousingAllowance.Text, @"^[0-9]*$"))
            {
                lblHousingAllowance.Visible = false;
            }
            else
            {
                lblHousingAllowance.Visible = true;
            }
        }

        private void edtMedicalAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtMedicalAllowance.Text, @"^[0-9]*$"))
            {
                lblMedicalAllowance.Visible = false;
            }
            else
            {
                lblHousingAllowance.Visible = true;
            }
        }

        private void edtFoodAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtFoodAllowance.Text, @"^[0-9]*$"))
            {
                lblFoodAllowance.Visible = false;
            }
            else
            {
                lblFoodAllowance.Visible = true;
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

        private void edtInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtInsurance.Text, @"^[0-9]*$"))
            {
                lblInsurance.Visible = false;
            }
            else
            {
                lblInsurance.Visible = true;
            }
        }

        private void edtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(edtEmployeeID.Text, @"^[0-9]*$"))
            {
                lblEmployeeID.Visible = false;
            }
            else
            {
                lblEmployeeID.Visible = true;
            }
        }
        private void clear()
        {
            edtName.Text = String.Empty;
            edtName.Text = String.Empty;
            edtEmployeeID.Text = String.Empty;
            edtWokingHours.Text = String.Empty;
            edtOT.Text = String.Empty;
            edtBasicSalary.Text = String.Empty;
            edtHousingAllowance.Text = String.Empty;
            edtMedicalAllowance.Text = String.Empty;
            edtFoodAllowance.Text = String.Empty;
            edtOtherAllowance.Text = String.Empty;
            edtSalaryAdvance.Text = String.Empty;
            edtETF.Text = String.Empty;
            edtEPF.Text = String.Empty;
            edtInsurance.Text = String.Empty;
        }
    }
    }

