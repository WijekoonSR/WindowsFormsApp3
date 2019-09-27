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
    public partial class VehicleLeasingUIAdd : UserControl
    {
        public static String serverName = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection sql = new SqlConnection(serverName);
        String Bank, Branch, BankCode, AccountHolder, StartLeasingDate, EndLeasingDate,StartDate,EndDate;
        int AccountNumber, Year, LeasingPeriod;
        public static string search;
        private void txtVehicleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleLeasingUIAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search = txtVid.Text.ToString();
            VehicleLeasingUIAddVehicleDetails vehicleLeasingUIAddVehicleDetails = new VehicleLeasingUIAddVehicleDetails();
            vehicleLeasingUIAddVehicleDetails.Show();
        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {

        }

        float AnnualInterestRate, MonthlyPayment, TotalLeasingAmount;
        SqlCommand command;
        String newVehicleID;

        public VehicleLeasingUIAdd()
        {
            InitializeComponent();
 
            getCurrentID();
        }

        private void getCurrentID() {
            try
            {
                sql.Open();
                String queryCurrentID = "select IDENT_CURRENT('Vehicle_Leasings')";
                SqlCommand command = new SqlCommand(queryCurrentID, sql);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    newVehicleID = dataReader[0].ToString();
                }
                sql.Close();
                sql.Open();
                SqlCommand chkExistsData = new SqlCommand("select * from Vehicle_Leasings where VehicleLeasingsID = 1", sql);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtVehicleLeasingID.Text = "VL" + (int.Parse(newVehicleID) + 1).ToString();
                else txtVehicleLeasingID.Text = "VL1";
                sql.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally {
                sql.Close();
            }
        }

        public void clearAllFields() {
            txtVid.Clear();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
       }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql.Open();
           
            String ID = txtVid.Text;
            ID = Regex.Replace(ID, "[^0-9]", "");
            int vid = int.Parse(ID);

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

            string query = "insert into Vehicle_Leasings(VehicleID,BankName,Branch,BankCode,AccountHolder,AccountNumber,Year,TotalLeasingAmount,AnnualInterestRate,LeasingPeriod,MonthlyPayment,StartLeasingDate,EndLeasingDate) " +
                "values('" + vid + "', '" + Bank + "','" + Branch + "','" + BankCode + "','" + AccountHolder + "','" + AccountNumber + "','" + Year + "','" + TotalLeasingAmount + "','" + AnnualInterestRate + "','" + LeasingPeriod + "','" + MonthlyPayment + "','" + StartLeasingDate + "','" + EndLeasingDate + "')";

            command = new SqlCommand(query, sql);
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            sql.Close();
            clearAllFields();
        }


        }
    }

