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
    public partial class VehicleLeasingUIAdd : UserControl
    {
        public static String serverName = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection sql = new SqlConnection(serverName);
        String Bank, Branch, BankCode, AccountHolder, StartLeasingDate, EndLeasingDate,StartDate,EndDate;
        int AccountNumber, Year, LeasingPeriod;

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        float AnnualInterestRate, MonthlyPayment, TotalLeasingAmount;
        SqlCommand command;
        String newVehicleID;

        public VehicleLeasingUIAdd()
        {
            InitializeComponent();
            sql.Open();
            String queryCurrentID = "select IDENT_CURRENT('Vehicle_Leasings') + 1";
            SqlCommand command = new SqlCommand(queryCurrentID, sql);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                newVehicleID = dataReader[0].ToString();
            }

            txtVehicleID.Text = "VL" + newVehicleID;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
       }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int vid = int.Parse(txtVehicleID.Text);
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

            string query = "insert into Vehicle_Leasings(VehicleID,Bank,Branch,BankCode,AccountHolder,AccountNumber,Year,TotalLeasingAmount,AnnualInterestRate,LeasingPeriod,MonthlyPayment,StartLeasingDate,EndLeasingDate) " +
                "values('" + vid + "', '" + Bank + "','" + Branch + "','" + BankCode + "','" + AccountHolder + "','" + AccountNumber + "','" + Year + "','" + TotalLeasingAmount + "','" + AnnualInterestRate + "','" + LeasingPeriod + "','" + MonthlyPayment + "','" + StartLeasingDate + "','" + EndLeasingDate + "')";

            command = new SqlCommand(query, sql);
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            sql.Close();
        }


        }
    }

