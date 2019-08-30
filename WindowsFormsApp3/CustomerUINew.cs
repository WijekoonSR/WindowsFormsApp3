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
        string Type, ContractStartDate, ContractEndDate, name, address, email, ProjectManagerName, ProjectAddress, ProjectEmail;
        int ContactNumber, FaxNumber, ProjectContactNumber;
        SqlCommand command;
        public CustomerUINew()
        {
            InitializeComponent();
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

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

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

                name = txtName.Text;
                address = txtAddress.Text;
                email = txtEmail1.Text;
                ProjectManagerName = txtProjectManager.Text;
                ProjectAddress = txtAddress1.Text;
                ProjectEmail = txtEmail2.Text;
                ContactNumber = int.Parse(txtContactNumber.Text);
                FaxNumber = int.Parse(txtFaxNumber.Text);
                ProjectContactNumber = int.Parse(txtContactNumber2.Text);

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
