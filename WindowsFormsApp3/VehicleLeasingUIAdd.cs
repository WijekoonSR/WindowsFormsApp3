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
 
            txtVehicleLeasingID.Text =  GetID();
        }

        private void setIdSql()
        {
            //set when user tries to insert values to db ** confirmed
            sql.Open();
            SqlCommand com = new SqlCommand("select next VALUE FOR  Id_Vehicle_Leasings", sql);
            com.ExecuteNonQuery();

            sql.Close();
        }
        private string GetID()
        {
            try
            {
                string ID = null;
                sql.Open();
                String queryCurrentID = "SELECT current_value FROM sys.sequences WHERE name = 'Id_Vehicle_Leasings' ;";
                SqlCommand command = new SqlCommand(queryCurrentID, sql);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                sql.Close();
                return "VL" + (int.Parse(ID));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Customer:getID ");
                return "Error";

            }
            finally
            {
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
           
            String vid = txtVid.Text;
            string vLeasingID = txtVehicleLeasingID.Text;

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

            string query = "insert into Vehicle_Leasings(VehicleLeasingsID,VehicleID,BankName,Branch,BankCode,AccountHolder,AccountNumber,Year,TotalLeasingAmount,AnnualInterestRate,LeasingPeriod,MonthlyPayment,StartLeasingDate,EndLeasingDate) " +
                "values('"+ vLeasingID + "','" + vid + "', '" + Bank + "','" + Branch + "','" + BankCode + "','" + AccountHolder + "','" + AccountNumber + "','" + Year + "','" + TotalLeasingAmount + "','" + AnnualInterestRate + "','" + LeasingPeriod + "','" + MonthlyPayment + "','" + StartLeasingDate + "','" + EndLeasingDate + "')";

            command = new SqlCommand(query, sql);
            command.ExecuteNonQuery();
            sql.Close();
            DialogResult dr = MessageBox.Show("Data Submitted", "Success!!", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                setIdSql();
                txtVehicleLeasingID.Text = GetID();
            }
        }


        }
    }

