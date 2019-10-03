using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class NewUserUI : Form
    {
        string userID = null;
        string dbUserId = null;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
        public NewUserUI()
        {
            InitializeComponent();
            getUserID();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            if (checkInputs() == true) {
                try {

                    setIdSql();
                    sqlConnection.Open();
                    string query = "insert into Users(UserID,UserPic,FileName,password,EmployeeID)" +
                        " values(@UserID,@UserPic,@FileName,@password,@EmployeeID)";
                    SqlCommand com = new SqlCommand(query,sqlConnection);
                    com.Parameters.AddWithValue("@UserID", dbUserId);
                    com.Parameters.AddWithValue("@UserPic", ImageToByte(picUser.Image));
                    com.Parameters.AddWithValue("@FileName", txtFileName.Text.ToString());
                    com.Parameters.AddWithValue("@password", txtPassword.Text.ToString());
                    com.Parameters.AddWithValue("@EmployeeID",int.Parse(TxtEmployeeID.Text.ToString()));
                    int rows = com.ExecuteNonQuery();
                    if (rows > 0 ) {
                       DialogResult dr =  MessageBox.Show("Registered Succefully", "Welcome" + userID,MessageBoxButtons.OK );
                        if (dr == DialogResult.OK) {
                            
                            CurrentUser.setID(TxtEmployeeID.Text, txtUserID.Text);
                            HomeUI home = new HomeUI();
                            home.Show();
                            this.Close();
                        }
                    }
                    sqlConnection.Close();
                }
                catch (Exception er) {
                    MessageBox.Show(er.Message);
                }
            } 
        }
        private void setIdSql() {
            //set when user tries to insert values to db ** confirmed
            sqlConnection.Open();
            SqlCommand com = new SqlCommand("select next VALUE FOR  Id_Users", sqlConnection);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read()) {
                dbUserId = sdr[0].ToString();
            }

            sqlConnection.Close();
        }
        private void getUserID()
        {
            try
            {
                sqlConnection.Open();
                String queryCurrentID = "SELECT current_value FROM sys.sequences WHERE name = 'Id_Users' ;";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    userID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                txtUserID.Text = "U" + (int.Parse(userID));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "UserUI:getUserID ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private bool checkInputs() {
            if (txtFileName.Text == "") {
                MessageBox.Show("Input File Name For Picture");
                txtFileName.Focus();
                return false;
            }
            else if (TxtEmployeeID.Text == "") {
                MessageBox.Show("Input Employee ID");
                TxtEmployeeID.Focus();
                return false;
            }
            else if (txtPassword.Text == "") {
                MessageBox.Show("Input Password");
                txtPassword.Focus();
                return false;
            }
            else if (txtPassword.Text.ToString().Length < 4 ) {
                MessageBox.Show("Password must have at least 4 characters");
                txtPassword.Focus();
                return false;
            }
            else if (txtReEnterPW.Text == "")
            {
                MessageBox.Show("Re-Enter Password");
                txtReEnterPW.Focus();
                return false;
            }
            else if (!txtPassword.Text.ToString().Equals(txtReEnterPW.Text.ToString())) {
                MessageBox.Show("Re-Enter Password is not matching with password", "Please check Password!");
                txtReEnterPW.Focus();
                return false;
            }
            else {
                return checkEmployeeAvaiability();
            }
        }

        private bool checkEmployeeAvaiability()
        {
            sqlConnection.Open();
            string query = "select * from Employee";
            SqlCommand com = new SqlCommand(query, sqlConnection);
            com.Parameters.AddWithValue("@id", TxtEmployeeID.Text.ToString());
            int rows = com.ExecuteNonQuery();
            MessageBox.Show(rows.ToString());
          sqlConnection.Close();
            if (rows < 0)
            {
                MessageBox.Show("Employee is Not Avaiable", "Please check Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEmployeeID.Focus();
                return false;
            }
            else
            {
                MessageBox.Show("Employee is Avaiable", "Please check Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }

        byte[] ImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void btnAddPrfPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    picUser.Image = Image.FromFile(filename);
                }
            }

        }
        private void NewUserUI_Load(object sender, EventArgs e)
        {
        }

       
        private void lblAddProfPic_Click(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }


    

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void txtReEnterPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReEnterPW_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
