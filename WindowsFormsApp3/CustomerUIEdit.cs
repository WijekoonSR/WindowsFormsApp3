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
    
    public partial class CustomerUIEdit : UserControl
    {
        string CustomerID, ContractStartDate, ContractEndDate, name, address, email, EndDate, StartDate;
        string ContactNumber, FaxNumber;
       public static string sqlname = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(sqlname);

        public CustomerUIEdit()
        {
            InitializeComponent();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            CustomerID = txtcutomerID.Text;
            name = txtCompanyName.Text.ToString();
            address = txtCompanyAddress.Text.ToString();
            email = txtEmailAddress.Text.ToString();
            ContactNumber  = txtContactNumber.Text.ToString();
            FaxNumber = txtFaxNumber.Text.ToString();
            EndDate = dateEndContract.Value.ToString("yyyy/MM/dd");
            StartDate = dateStartContract.Value.ToString("yyyy/MM/dd");
            try {
                sqlConnection.Open();
                string query = "UPDATE Customer set name='" + name + "',address='" + address + "',email='" + email + "',ContactNumber='" + ContactNumber + "',FaxNumber='" + FaxNumber + "',ContractStartDate='" + ContractStartDate + "',ContractEndDate='" + ContractEndDate + "' where CustomerID = '" + CustomerID + "'";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string CustomerID = txtcutomerID.Text.ToString();
            //SqlConnection sqlConnection = new SqlConnection(name);
            string query_Search = "SELECT * FROM Customer WHERE CustomerID='" +CustomerID+ "'";
            SqlCommand cmd = new SqlCommand(query_Search, sqlConnection);

            try
            {
                sqlConnection.Open();
                using(SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        txtCompanyName.Text = read["name"].ToString();
                        txtCompanyAddress.Text = read["address"].ToString();
                        txtContactNumber.Text = read["ContactNumber"].ToString();
                        txtEmailAddress.Text = read["email"].ToString();
                        txtFaxNumber.Text = read["FaxNumber"].ToString();
                        dateStartContract.Value = Convert.ToDateTime(read["ContractStartDate"]);
                        dateEndContract.Value = Convert.ToDateTime(read["ContractEndDate"]);

                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerUIEditExtendPeriod customerUIEditExtendPeriod = new CustomerUIEditExtendPeriod();
            customerUIEditExtendPeriod.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Do you want to clear all fields ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {

                dateEndContract.Value = DateTime.Now;
                dateStartContract.Value = DateTime.Now;
                txtCompanyName.Clear();
                txtCompanyAddress.Clear();
                txtContactNumber.Clear();
                txtEmailAddress.Clear();
                txtFaxNumber.Clear();
                 }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerID = txtcutomerID.Text;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sqlname);
                sqlConnection.Open();
                String deletesql = "delete from Customer WHERE CustomerID = '" + CustomerID + "'";
                SqlCommand com = new SqlCommand(deletesql, sqlConnection);
                com.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Delete Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error whiling delete" + ex);
            }
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
