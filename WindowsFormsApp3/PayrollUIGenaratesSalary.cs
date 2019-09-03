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
    public partial class PayrollUIGenaratesSalary : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public PayrollUIGenaratesSalary()
        {
            InitializeComponent();
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

            try
            {
                con.Open();


                if (con.State == System.Data.ConnectionState.Open)
                {

                    String SalaryDate = dateTimePayroll.Value.ToString("yyyy/MM/DD");
                    int BasicSalary = Convert.ToInt32(edtBasicSalary.Text);
                    int HousingAllowance = Convert.ToInt32(drpHousingAllowance.selectedValue.ToString());
                    int MedicalAllowance = Convert.ToInt32(drpMedicalAllowance.selectedValue.ToString());
                    int FoodAllowance = Convert.ToInt32(drpFoodAllowance.selectedValue.ToString());
                    int OtherAllowance = Convert.ToInt32(edtOtherAllowance.Text);
                    int SalaryAdvance = Convert.ToInt32(edtSalaryAdvance.Text);
                    int ETF = Convert.ToInt32(edtETF.Text);
                    int EPF = Convert.ToInt32(edtEPF.Text);
                    int Insurance = Convert.ToInt32(drpInsurance.selectedValue.ToString());
                    
                    // MessageBox.Show(WokingHours.ToString() + OT.ToString() + OTRate);

                    String sql = "Insert into  Payroll_Operators_Monthly_Salary(SalaryDate, BasicSalary, HousingAllowance, MedicalAllowance, FoodAllowance, OtherAllowance, SalaryAdvance, ETF, EPF, Insurance )" + "Values('" + SalaryDate + "','" + BasicSalary + "','" + HousingAllowance + "', '" + MedicalAllowance + "', '"+FoodAllowance+"', '"+OtherAllowance+"', '"+SalaryAdvance+"', '"+ETF+"', '"+EPF+"', '"+Insurance+"')";
                    //String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate, EmpolyeeID) Values('"+dateTimePayroll.Text+"', '"+edtWokingHours.Text+"','"+edtOT.Text+"' , '"+drpOTRate.Text+"',)";
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




        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
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
                        
                        edtName.Text = (read["FistName"].ToString());
                       
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
