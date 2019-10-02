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
    public partial class CustomerUINew : UserControl
    {

        public static String nameServer = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        public static string ID;
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(nameServer);
        string name, address, email, EndDate, StartDate, ContactNumber, FaxNumber, CId;
       
        SqlCommand command;
        String newCustomerID;

        public CustomerUINew()
        {
            InitializeComponent();
           
            txtcutomerID.Text = GetID();
        }

        private void setIdSql()
        {
            //set when user tries to insert values to db ** confirmed
            sqlConnection.Open();
            SqlCommand com = new SqlCommand("select next VALUE FOR  Id_Customer", sqlConnection);
            com.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private string GetID()
        {
            try
            {
                string ID = null;
                sqlConnection.Open();
                String queryCurrentID = "SELECT current_value FROM sys.sequences WHERE name = 'Id_Customer' ;";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                return "CU" + (int.Parse(ID));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Customer:getID ");
                return "Error";

            }
            finally
            {
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

            if (dr == DialogResult.OK)
            {

                clearfields();

            }
        }
        private void clearfields() {
            dateEndContract.Value = DateTime.Now;
            dateStartContract.Value = DateTime.Now;
            txtCompanyName.Clear();
            txtCompanyAddress.Clear();
            txtContactNumber.Clear();
            txtEmaiAddress.Clear();
            txtFaxNumber.Clear();
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
                    if (txtCompanyName.Text == "")
                    {
                        MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCompanyName.Focus();
                    }
                    else if (txtCompanyAddress.Text == "")
                    {
                        MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCompanyAddress.Focus();
                    }
                    else if (txtContactNumber.Text == "")
                    {
                        MessageBox.Show("Please Enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContactNumber.Focus();
                    }
                    else if (txtEmaiAddress.Text == "")
                    {
                        MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmaiAddress.Focus();
                    }
                    else if(isValidEmailAddress(txtEmaiAddress.Text.ToString()) == false){
                        MessageBox.Show("This is not a valid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmaiAddress.Focus();

                    }
                    else if (txtFaxNumber.Text == "")
                    {
                        MessageBox.Show("Please Enter Fax Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFaxNumber.Focus();
                    }
                   
                    else
                    {

                        sqlConnection.Open();
                        name = txtCompanyName.Text.ToString();
                        address = txtCompanyAddress.Text.ToString();
                        email = txtEmaiAddress.Text.ToString();
                       
                        ContactNumber = txtContactNumber.Text.ToString();
                        FaxNumber = txtFaxNumber.Text.ToString();
                        EndDate = dateEndContract.Value.ToString();
                        StartDate = dateStartContract.Value.ToString();
                        CId = txtcutomerID.Text.ToString();


                        string query = "insert into Customer(CustomerID,name,address,email,ContactNumber,FaxNumber,ContractStartDate,ContractEndDate) " +
                            "values('"+CId +"','" + name + "','" + address + "','" + email + "','" + ContactNumber + "','" + FaxNumber + "','" + Convert.ToDateTime(StartDate) + "','" + Convert.ToDateTime(EndDate) + "')";
                        command = new SqlCommand(query, sqlConnection);
                        int chk = command.ExecuteNonQuery();
                        sqlConnection.Close();

                        if (chk == 0)
                        {
                            MessageBox.Show("Failed to insert data");
                        }
                        else
                        {
                            DialogResult DR = MessageBox.Show("successfully","Success",MessageBoxButtons.OK);
                            if (DR == DialogResult.OK)
                            {
                                clearfields();
                                setIdSql();
                                txtcutomerID.Text =  GetID(); 
                            }
                        }
                      
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
        public bool isValidEmailAddress(String s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else
            {
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(s) && !s.EndsWith(".");
            }
        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
    }
}
