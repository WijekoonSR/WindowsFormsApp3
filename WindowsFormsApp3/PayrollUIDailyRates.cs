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
    public partial class PayrollUIDailyRates : UserControl
    {
        public static String conString = @"Data Source=(localdb)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public PayrollUIDailyRates()
        {
            InitializeComponent();
        }
        
        
        private void btnChangeOTRates_Click(object sender, EventArgs e)
        {
            PayrollUIOperaterChangeOTRates payOperaterChangeOT = new PayrollUIOperaterChangeOTRates();
            payOperaterChangeOT.ShowDialog();
           
        }

        private void btnSetDailyRates_Click(object sender, EventArgs e)
        {
          
            try {
                con.Open();


                if (con.State == System.Data.ConnectionState.Open)
                {


                    String SalaryDate = dateTimePayroll.Value.ToString("yyyy/MM/DD");
                    int WokingHours = Convert.ToInt32(edtWokingHours.Text);
                    int OT = Convert.ToInt32(edtOT.Text);
                    int OTRate = Convert.ToInt32(drpOTRate.selectedValue.ToString());
                    MessageBox.Show(WokingHours.ToString() + OT.ToString() + OTRate);

                    String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate)" + "Values('" + SalaryDate + "','" + WokingHours + "','" + OT + "', '"+OTRate+"')";
                    //String sql = "Insert into Payroll_Operators(SalaryDate, WorkingHours, OT, OTRate, EmpolyeeID) Values('"+dateTimePayroll.Text+"', '"+edtWokingHours.Text+"','"+edtOT.Text+"' , '"+drpOTRate.Text+"',)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succes");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
}
        private void edtWokingHours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
