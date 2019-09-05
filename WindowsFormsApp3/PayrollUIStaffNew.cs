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
    public partial class PayrollUIStaffNew : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        public PayrollUIStaffNew()
        {
            InitializeComponent();
            lberror1.Visible = false;
            lblBasicSalary.Visible = false;
            //lblHousingAllowance.Visible = false;
            //lblMedicalAllowace.Visible = false;
            //lblFoodAllowance.Visible = false;
            lblOtherAllowance.Visible = false;
            lblSalaryAdvance.Visible = false;
            lblETF.Visible = false;
            lblEPF.Visible = false;
            //lblInsurance.Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            PayrollUIChangeValues payChangeValues = new PayrollUIChangeValues();
            payChangeValues.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)

        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            else if (edtOT.Text.Equals(""))
            {
                MessageBox.Show("OT is empty");
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
            else if (drpMonth.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select Month Value");
            }
            else if (drpOTRate.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Please select OTRate Value");
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
            else if (lberror1.Visible == true || lblBasicSalary.Visible == true || lblETF.Visible == true || lblEPF.Visible == true || lblOtherAllowance.Visible == true || lblSalaryAdvance.Visible == true )
            {
                MessageBox.Show("inavalid filed available");
            }
           

            else
            {
                try
                {
                    con.Open();


                    //if (con.State == System.Data.ConnectionState.Open)
                    {

                        
                        String SalaryDate = dateTimePayroll.Value.ToString("yyyy/MM/dd");
                        String Months = (drpMonth.selectedValue.ToString());
                        int OT = Convert.ToInt32(edtOT.Text);
                        int OTRate = Convert.ToInt32(drpOTRate.selectedValue.ToString());
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

                        // MessageBox.Show( SalaryDate + Months + OT.ToString() + OTRate + BasicSalary.ToString() + HousingAllowance.ToString() + MedicalAllowance.ToString() + FoodAllowance.ToString() + OtherAllowance.ToString()+ SalaryAdvance.ToString() + ETF.ToString() + EPF.ToString() + Insurance.ToString());

                        String sql = "Insert into  Payroll_Staff(SalaryDate, Months, OT, OTRate, BasicSalary, HousingAllowance, MedicalAllowance, FoodAllowance, OtherAllowance, SalaryAdvance, ETF, EPF, Insurance, EmployeeID )" + "Values('" + SalaryDate + "', '" + Months + "', '" + OT + "', '" + OTRate + "', '" + BasicSalary + "','" + HousingAllowance + "', '" + MedicalAllowance + "', '" + FoodAllowance + "', '" + OtherAllowance + "', '" + SalaryAdvance + "', '" + ETF + "', '" + EPF + "', '" + Insurance + "', '" + EmployeeID + "')";
                        //String sql = "Insert into  Payroll_Staff(SalaryDate, Months, OT, OTRate, BasicSalary, HousingAllowance, MedicalAllowance, FoodAllowance, OtherAllowance, SalaryAdvance, ETF, EPF, Insurance )" + "Values('5012-02-06','apad', 12, 155, 20000, 500,500, 500, 500, 200, 12, 23, 522)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Succes");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
                finally
                {
                    clear();
                }

            }
        }

        private void edtBSalary_TextChanged(object sender, EventArgs e)
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

        private void btnSetEmployeeID_Click(object sender, EventArgs e)
        {
            if (edtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter EmployeeID");
            }
            else
            {
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
                            //MessageBox.Show(read["FirstName"].ToString());
                            //edtName.Text = (read["FistName"].ToString());
                            edtName.Text = read.GetValue(1).ToString();
                            edtPossition.Text = read.GetValue(12).ToString();
                            //edtName.Text = "name";

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

        private void PayrollUIStaffNew_Load(object sender, EventArgs e)
        {

        }

        private void edtOT_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Regex.IsMatch(edtOT.Text, @"^[0-9]*$"))
            {
                lberror1.Visible = false;
            }
            else
            {
                lberror1.Visible = true;
            }
        }

        private void edtOT_Validated(object sender, EventArgs e)
        {
            if (Regex.IsMatch(edtOT.Text, @"^[0-9]*$"))
            {
                lberror1.Visible = false;
            }
            else
            {
                lberror1.Visible = true;
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

        private void edtSalaryAdvance_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void edtOtherAllowance_Validated(object sender, EventArgs e)
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

        private void edtSalaryAdvance_Validated(object sender, EventArgs e)
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

        private void edtEPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtEPF_Validated(object sender, EventArgs e)
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

        private void edtETF_Validated(object sender, EventArgs e)
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

        private void drpHousingAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void clear()
        {
            edtEmployeeID.Text = String.Empty;
            edtName.Text = String.Empty;
            edtOT.Text = String.Empty;
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