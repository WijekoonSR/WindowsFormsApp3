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
    public partial class VehicleLeasingUIEdit : UserControl
    {
            string date1, date2;
        static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(name);
        public VehicleLeasingUIEdit()
        {
            InitializeComponent();
        }

        private void DateStartLeasingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string id = txtLeasingID.Text.ToString();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Vehicle_Leasings where VehicleLeasingsID  = '"+id+"'",con);
            SqlDataReader sr = sqlCommand.ExecuteReader();
            while (sr.Read()) {
                txtBank.Text = sr["BankName"].ToString();
                txtBranch.Text = sr["Branch"].ToString();
                txtBankCode.Text = sr["BankCode"].ToString();
                txtAccountHolder.Text = sr["AccountHolder"].ToString();
                txtAccountNumber.Text = sr["AccountNumber"].ToString();
                txtYear.Text =sr["Year"].ToString() ;
                txtTotalLeasingAmount.Text = sr["TotalLeasingAmount"].ToString();
                txtAnnualInterestRate.Text = sr["AnnualInterestRate"].ToString();
                txtMonthlyPayment.Text = sr["MonthlyPayment"].ToString();
                date1 = sr["StartLeasingDate"].ToString();
                date2 = sr["EndLeasingDate"].ToString();
             	
            }

            DateStartLeasingDate.Value = Convert.ToDateTime(date1);
            DateEndLeasingDate.Value = Convert.ToDateTime(date2);
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Vehicle_Leasings set BankName ='" + txtBank.Text.ToString() + "' , Branch = '" + txtBranch.Text.ToString() + "', BankCode = '" + txtBankCode.ToString() + "',AccountHolder= '" + txtAccountHolder.Text.ToString() + "',AccountNumber ='" + txtAccountNumber.Text.ToString() + "',Year ='" + txtYear.Text.ToString() + "', TotalLeasingAmount='" + txtTotalLeasingAmount.Text.ToString() + "',AnnualInterestRate='" + txtAnnualInterestRate.Text.ToString() + "',MonthlyPayment='" + txtMonthlyPayment.Text.ToString() + "',StartLeasingDate='" + DateStartLeasingDate.Value.ToString("yyyy/MM/dd") + "',EndLeasingDate='" + DateEndLeasingDate.Value.ToString("yyyy/MM/dd")+"'",con);
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Succesfully","Updated",MessageBoxButtons.OK);
        }

        public void clearAllFields()
        {
            txtLeasingID.Clear();
            txtBank.Clear();
            txtBankCode.Clear();
            txtAccountHolder.Clear();
            txtAccountNumber.Clear();
            txtYear.Clear();
            txtTotalLeasingAmount.Clear();
            txtAnnualInterestRate.Clear();
            txtLeasingPeriod.Clear();
            txtMonthlyPayment.Clear();
            DateStartLeasingDate.Value = DateTime.Now;
            DateEndLeasingDate.Value = DateTime.Now;
        }
    }
}
