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
    public partial class EmployeeUINewStaff : UserControl
    {
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        public EmployeeUINewStaff()
        {
            InitializeComponent();
            txtEmployeeID.Text = GetID();
        }

        private void EmployeeUINewStaff_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = GetID();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Equals(""))
            {
                MessageBox.Show("please Enter Employee ID");
            }
            else if (txtFName.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtLName.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtNIC.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtContact.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtAddress01.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtAddress02.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtCity.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }
            else if (txtPostalCode.Text.Equals(""))
            {
                MessageBox.Show("Error");
            }

            else
            {

                sqlConnection.Open();
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                string gender = cmbGender.Text;
                string dob = dateDOB.Value.ToString("yyyy/MM/dd");
                string NIC = txtNIC.Text;
                string ContactNum = txtContact.Text;
                string email = txtEmail.Text;
                string address01 = txtAddress01.Text;
                string address02 = txtAddress02.Text;
                string city = txtCity.Text;
                string postalCode = txtPostalCode.Text;
                string jobTitle = cmbJobTitle.Text;
                string department = cmbDepartment.Text;
                string ALStream = cmbALSelect.Text;
                string ALsub01 = txtSubject01.Text;
                string AlSub01sel = cmbSubject01.Text;
                string ALsub02 = txtSubject02.Text;
                string AlSub02sel = cmbSubject02.Text;
                string ALsub03 = txtSubject03.Text;
                string AlSub03sel = cmbSubject03.Text;
                string ALsub04 = txtSubject04.Text;
                string AlSub04sel = cmbSubject04.Text;

                String eid = txtEmployeeID.Text;
               

                string query = "insert into Employee(EmployeeID,FirstName,Lastname,Gender,DOB,NIC,ContactNumber,Email,Address01,Address02,City,PostalCode,JobTitle) " +
                    "values('" + eid + "','" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + NIC + "','" + ContactNum + "','" + email + "','" + address01 + "','" + address02 + "','" + city + "','" + postalCode + "','" + jobTitle + "')";

                //string query2 = "insert into "
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();

                string query02 = "insert into Staff(StaffID,EmployeeID,Department,ALStream,subjects01,subjects02,subjects03,subjects04,subjects01Grade,subjects02Grade,subjects03Grade,subjects04Grade)"
                + "values('" + eid + "', '" + department + "','" + ALStream + "','" + ALsub01 + "','" + AlSub01sel + "','" + ALsub02 + "','" + AlSub02sel + "','" + ALsub03 + "','" + AlSub03sel + "','" + ALsub04 + "','" + AlSub04sel + "')";
                SqlCommand cmd2 = new SqlCommand(query02, sqlConnection);
                cmd2.ExecuteNonQuery();

                sqlConnection.Close();





                /*sqlConnection.Open();
                string query02 = "Exec AsignStaff'"+department + "','"+ALStream+"','"+ALsub01+"','"+AlSub01sel+"','"+ALsub02+"','"+AlSub02sel+"','"+ALsub03+"','"+AlSub03sel+"','"+ALsub04+"','"+AlSub04sel+"'";
                SqlCommand cmd2 = new SqlCommand(query02, sqlConnection);
                cmd2.ExecuteNonQuery();*/
                MessageBox.Show("Data Submitted");
                clearDet();
                setIdSql();
                txtEmployeeID.Text = GetID(); 
               
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDet();
        }
        public void clearDet()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            cmbGender.Text = "";
            dateDOB.Text = "";
            txtNIC.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress01.Text = "";
            txtAddress02.Text = "";
            txtCity.Text = "";
            txtPostalCode.Text = "";
            cmbJobTitle.Text = "";
            cmbALSelect.Text = "";
            txtSubject01.Text = "";
            cmbSubject01.Text = "";
            txtSubject02.Text = "";
            cmbSubject02.Text = "";
            txtSubject03.Text = "";
            cmbSubject03.Text = "";
            txtSubject04.Text = "";
            cmbSubject04.Text = "";



        }

        private void setIdSql()
        {
            //set when user tries to insert values to db ** confirmed
            sqlConnection.Open();
            SqlCommand com = new SqlCommand("select next VALUE FOR  Id_Employee", sqlConnection);
            com.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private string GetID()
        {
            try
            {
                string ID = null;
                sqlConnection.Open();
                String queryCurrentID = "SELECT current_value FROM sys.sequences WHERE name = 'Id_Employee' ;";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                return "E" + (int.Parse(ID));

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
        private void dateDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject02_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
