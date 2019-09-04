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
        public static string ID;
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(nameServer);
        string  ContractStartDate, ContractEndDate, name, address, email, ProjectManagerName, ProjectAddress, ProjectEmail, EndDate,StartDate;
        int ContactNumber, FaxNumber, ProjectContactNumber;
        SqlCommand command;
        String newCustomerID;

        public CustomerUINew()
        {
            InitializeComponent();
            getCurrentID();
            ID = txtcutomerID.Text.ToString();
        }

        private void getCurrentID() {
            using (sqlConnection = new SqlConnection(nameServer))
            {
                sqlConnection.Open();
                String queryCurrentID = "select IDENT_CURRENT('Customer')";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    newCustomerID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                sqlConnection.Open();
                SqlCommand chkExistsData = new SqlCommand("select * from Customer where CustomerID = 1", sqlConnection);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtcutomerID.Text = "C" + (int.Parse(newCustomerID) + 1).ToString();
               else txtcutomerID.Text = "C1";
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
                using (sqlConnection = new SqlConnection(nameServer))
                {
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtName.Focus();
                    }
                    else if (txtAddress.Text == "")
                    {
                        MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAddress.Focus();
                    }
                    else if (txtContactNumber.Text == "")
                    {
                        MessageBox.Show("Please Enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContactNumber.Focus();
                    }
                    else if (txtEmail1.Text == "")
                    {
                        MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail1.Focus();
                    }
                    else if (txtFaxNumber.Text == "")
                    {
                        MessageBox.Show("Please Enter Fax Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFaxNumber.Focus();
                    }
                    else if (txtProjectManager.Text == "")
                    {
                        MessageBox.Show("Please Enter Project Manager Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtProjectManager.Focus();
                    }
                    else if (txtAddress1.Text == "")
                    {
                        MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAddress1.Focus();
                    }
                    else if (txtContactNumber2.Text == "")
                    {
                        MessageBox.Show("Please Enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContactNumber2.Focus();
                    }
                    else if (txtEmail2.Text == "")
                    {
                        MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail2.Focus();
                    }
                    else
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
                        EndDate = dateEndContract.Value.ToString("yyyy/MM/dd");
                        StartDate = dateStartContract.Value.ToString("yyyy/MM/dd");

                        string query = "insert into Customer(name,address,email,ProjectManagerName,ProjectAddress,ProjectEmail,ContactNumber,FaxNumber,ProjectContactNumber,ContractStartDate,ContractEndDate) " +
                            "values('" + name + "','" + address + "','" + email + "','" + ProjectManagerName + "','" + ProjectAddress + "','" + ProjectEmail + "','" + ContactNumber + "','" + FaxNumber + "','" + ProjectContactNumber + "','" + StartDate + "','" + EndDate + "')";
                        command = new SqlCommand(query, sqlConnection);
                        int chk = command.ExecuteNonQuery();

                        if (chk == 0)
                        {
                            MessageBox.Show("Failed to insert data");
                        }
                        else
                        {
                            DialogResult DR = MessageBox.Show("successfully");
                            if (DR == DialogResult.OK)
                            {
                                getCurrentID();
                            }
                        }
                        sqlConnection.Close();
                    }
                }
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
