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
    public partial class EmployeeUINewOperator : UserControl
    {
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        public EmployeeUINewOperator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Create string variables that contain the patterns   
           /* string NICPattern = @"[0-9]{9}[x|X|v|V]$"; //NICpattern  

            bool isNICValid = Regex.IsMatch(txtNIC.Text, NICPattern);

            if (isNICValid)
            {
                MessageBox.Show("Please enter a valid NIC Number");
            }
            */
             sqlConnection.Open();
             string fname = txtfname.Text;
             string lname = txtLname.Text;
             string gender = cmbGender.Text;
             string dob = dateDOB.Value.ToString("yyyy/MM/dd");
             string NIC = txtNIC.Text;
             string licenseNUm = txtLicense.Text;
             string ContactNum = txtContactNum.Text;
             string email = txtEmail.Text;
             string address01 = txtAddress01.Text;
             string address02 = txtAddress02.Text;
             string city = txtCity.Text;
             string postalCode = txtPostalCode.Text;
             string jobTitle = cmbJobTitle.Text;

            String EID = txtEmployeeID.Text;
            EID = Regex.Replace(EID, "[^0-9]", "");
            int ID = int.Parse(EID);

          

            string query = "insert into Employee(FirstName,Lastname,Gender,DOB,NIC,ContactNumber,Email,Address01,Address02,City,PostalCode,JobTitle) " +
               "values('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + NIC + "','" + ContactNum + "','" + email + "','" + address01 + "','" + address02 + "','" + city + "','" + postalCode + "','" + jobTitle + "')";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();

            string query02 = "insert into Vehicle_Operators(EmployeeID,LicenseNo)"+ "values('" +ID+ "','" +licenseNUm+ "')";
                SqlCommand cmd2 = new SqlCommand(query02, sqlConnection);
                 cmd2.ExecuteNonQuery();
            

             sqlConnection.Close();
             //sqlConnection.Open();

            /* string query02 = "Exec AsignOperators '" + licenseNUm + "'";
             SqlCommand cmd2 = new SqlCommand(query02,sqlConnection);
             cmd2.ExecuteNonQuery();*/


             MessageBox.Show("Data Submitted");
             clearDet();
            getOpertaorID();
           //  sqlConnection.Close();

        }
        public void clearDet()
        {
            txtfname.Text = "";
            txtLname.Text = "";
            cmbGender.Text = "";
            dateDOB.Text = "";
            txtNIC.Text = "";
            txtLicense.Text = "";
            txtContactNum.Text = "";
            txtEmail.Text = "";
            txtAddress01.Text = "";
            txtAddress02.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            cmbJobTitle.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDet();
        }
        private void getOpertaorID()
        {
            try
            {
                sqlConnection.Open();
                string ID = null;
                String queryCurrentID = "select IDENT_CURRENT('Employee')";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                sqlConnection.Open();

                SqlCommand chkExistsData = new SqlCommand("select * from Employee where EmployeeID = 1", sqlConnection);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtEmployeeID.Text = "E" + (int.Parse(ID) + 1).ToString();
                else txtEmployeeID.Text = "E1";
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "BookingUI:getBookingID ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeUINewOperator_Load(object sender, EventArgs e)
        {
            getOpertaorID();
        }
    }
    }

