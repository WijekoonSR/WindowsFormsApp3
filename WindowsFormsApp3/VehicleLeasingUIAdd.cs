using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp3
{
    public partial class VehicleLeasingUIAdd : UserControl
    {
        String Bank, Branch, BankCode, AccountHolder,StartLeasingDate,EndLeasingDate;
        int AccountNumber, Year, LeasingPeriod;
        float AnnualInterestRate, MonthlyPayment, TotalLeasingAmount;
        string StartDate, EndDate;

        public VehicleLeasingUIAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
       }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                Bank = txtBank.Text.ToString();
                Branch = txtBranch.Text.ToString();
                BankCode = txtBankCode.Text.ToString();
                AccountHolder = txtAccountHolder.Text.ToString();
                AccountNumber = int.Parse(txtAccountNumber.Text);
                Year = int.Parse(txtYear.Text);
                TotalLeasingAmount = float.Parse(txtTotalLeasingAmount.Text);
                AnnualInterestRate = float.Parse(txtAnnualInterestRate.Text);
                LeasingPeriod = int.Parse(txtLeasingPeriod.Text);
                MonthlyPayment = float.Parse(txtMonthlyPayment.Text);
                StartDate = DateStartLeasingDate.Value.ToString("yyyy/MM/DD");
                EndDate = DateEndLeasingDate.Value.ToString("yyyy/MM/DD");

            

          

        }
    }
}
