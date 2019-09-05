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
            getStaffID();
        }

        private void EmployeeUINewStaff_Load(object sender, EventArgs e)
        {
            getStaffID();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntConfirm_Click(object sender, EventArgs e)
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

            String EID = txtEmployeeID.Text;
            EID = Regex.Replace(EID, "[^0-9]", "");
            int ID = int.Parse(EID);

            string query = "insert into Employee(FirstName,Lastname,Gender,DOB,NIC,ContactNumber,Email,Address01,Address02,City,PostalCode,JobTitle) " +
                "values('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + NIC + "','" + ContactNum + "','" + email + "','" + address01 + "','" + address02 + "','" + city + "','" + postalCode + "','" + jobTitle + "')";

            //string query2 = "insert into "
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();

            string query02 = "insert into Staff(EmployeeID,Department,ALStream,subjects01,subjects02,subjects03,subjects04,subjects01Grade,subjects02Grade,subjects03Grade,subjects04Grade)"
            + "values('" +ID+"', '"+department + "','" + ALStream + "','" + ALsub01 + "','" + AlSub01sel + "','" + ALsub02 + "','" + AlSub02sel + "','" + ALsub03 + "','" + AlSub03sel + "','" + ALsub04 + "','" + AlSub04sel + "')";
                SqlCommand cmd2 = new SqlCommand(query02, sqlConnection);
                cmd2.ExecuteNonQuery();

            sqlConnection.Close();
          
            
            
            
            
            /*sqlConnection.Open();
            string query02 = "Exec AsignStaff'"+department + "','"+ALStream+"','"+ALsub01+"','"+AlSub01sel+"','"+ALsub02+"','"+AlSub02sel+"','"+ALsub03+"','"+AlSub03sel+"','"+ALsub04+"','"+AlSub04sel+"'";
            SqlCommand cmd2 = new SqlCommand(query02, sqlConnection);
            cmd2.ExecuteNonQuery();*/
            MessageBox.Show("Data Submitted");
            clearDet();
            getStaffID();
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
        private void getStaffID()
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void dateDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
