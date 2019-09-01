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
    public partial class CustomerUINew : UserControl
    {

        public static String nameServer = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(nameServer);
        string  ContractStartDate, ContractEndDate, name, address, email, ProjectManagerName, ProjectAddress, ProjectEmail, EndDate,StartDate;
        int ContactNumber, FaxNumber, ProjectContactNumber;
        SqlCommand command;
        String newCustomerID;

        public CustomerUINew()
        {
            InitializeComponent();
            using (sqlConnection = new SqlConnection(nameServer)) {
                sqlConnection.Open(); String queryCurrentID = "select IDENT_CURRENT('Bookings') + 1";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    newCustomerID = dataReader[0].ToString();
                }
                txtcutomerID.Text = newCustomerID;
                sqlConnection.Close();

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcutomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to clear all fields ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK) {

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


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CustomerUINew_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                name = txtName.Text.ToString();
                address = txtAddress.Text.ToString();
                email = txtEmail1.Text.ToString();
                ProjectManagerName = txtProjectManager.Text.ToString();
                ProjectAddress = txtAddress1.Text.ToString();
                ProjectEmail = txtEmail2.Text.ToString();
                ContactNumber = int.Parse(txtContactNumber.Text);
                FaxNumber = int.Parse(txtFaxNumber.Text);
                ProjectContactNumber = int.Parse(txtContactNumber2.Text);
                EndDate = dateEndContract.Value.ToString("yyyy/MM/DD");
                StartDate = dateStartContract.Value.ToString("yyyy/MM/DD");

                string query = "insert into Customer(name,address,email,ProjectManagerName,ProjectAddress,ProjectEmail,ContactNumber,FaxNumber,ProjectContactNumber) " +
                    "values('" + name + "','" + address + "','" + email + "','" + ProjectManagerName + "','" + ProjectAddress + "','" + ProjectEmail + "','" + ContactNumber + "','" + FaxNumber + "','" + ProjectContactNumber + "')";
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("succes");
                sqlConnection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
            finally
            {

                sqlConnection.Close();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
