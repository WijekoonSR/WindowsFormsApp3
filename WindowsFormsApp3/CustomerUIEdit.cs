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
        string CustomerID, ContractStartDate, ContractEndDate, name, address, email, ProjectManagerName, ProjectAddress, ProjectEmail, EndDate, StartDate;
        int ContactNumber, FaxNumber, ProjectContactNumber;
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

        private void btnSave_Click(object sender, EventArgs e)
        {


            CustomerID = txtcutomerID.Text;
            name = txtName.Text.ToString();
            address = txtAddress.Text.ToString();
            email = txtEmail1.Text.ToString();
            ProjectManagerName = txtProjectManager.Text.ToString();
            ProjectAddress = txtAddress1.Text.ToString();
            ProjectEmail = txtEmail2.Text.ToString();
            ContactNumber = int.Parse(txtContactNumber.Text);
            FaxNumber = int.Parse(txtFaxNumber.Text);
            ProjectContactNumber = int.Parse(txtContactNumber2.Text);
            EndDate = dateEndContract.Value.ToString("yyyy/MM/dd");
            StartDate = dateStartContract.Value.ToString("yyyy/MM/dd");
            try {
                sqlConnection.Open();
                string query = "UPDATE Customer set name='" + name + "',address='" + address + "',email='" + email + "',ProjectManagerName='" + ProjectManagerName + "',ProjectAddress='" + ProjectAddress + "',ProjectEmail='" + ProjectEmail + "',ContactNumber='" + ContactNumber + "',FaxNumber='" + FaxNumber + "',ProjectContactNumber='" + ProjectContactNumber + "',ContractStartDate='" + ContractStartDate + "',ContractEndDate='" + ContractEndDate + "' where CustomerID = '" + CustomerID + "'";


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
            int CustomerID = int.Parse(txtcutomerID.Text);
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
                        txtName.Text = read.GetValue(3).ToString();
                        txtAddress.Text = read.GetValue(4).ToString();
                        txtContactNumber.Text = read.GetValue(5).ToString();
                        txtEmail1.Text = read.GetValue(6).ToString();
                        txtFaxNumber.Text = read.GetValue(7).ToString();
                        txtProjectManager.Text = read.GetValue(8).ToString();
                        txtAddress1.Text = read.GetValue(9).ToString();
                        txtContactNumber2.Text = read.GetValue(10).ToString();
                        txtEmail2.Text = read.GetValue(11).ToString();

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
                txtName.Clear();
                txtAddress.Clear();
                txtContactNumber.Clear();
                txtEmail1.Clear();
                txtFaxNumber.Clear();
                txtProjectManager.Clear();
                txtAddress1.Clear();
                txtContactNumber2.Clear();
                txtEmail2.Clear();
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
