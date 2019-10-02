using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class UserUIEdit : UserControl
    {
        String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        string userID = CurrentUser.userID;
        string employeeId = CurrentUser.employeeID;
        string filename;
        public UserUIEdit()
        {
            InitializeComponent();
            txtEmployeeID.Text = employeeId.ToString();
            txtUserID.Text = userID.ToString();

            SqlConnection sql = new SqlConnection(name);
            sql.Open();
            String query = "select * from Users where UserID = @uId";
            SqlCommand com = new SqlCommand(query,sql);
            com.Parameters.AddWithValue("@uId", 1);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read()) {
                txtPassword.Text = sdr["password"].ToString();
                txtReEnterPasword.Text = sdr["password"].ToString();
                txtPicName.Text = sdr["FileName"].ToString();
                picUser.Image = ConvertBinaryToIamge((byte[])sdr["UserPic"]);
            }
            sql.Close();
        }


        private void btnChangeUserPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    lblFileName.Text = filename;
                    picUser.Image = Image.FromFile(filename);
                }
            }
        }

        Image ConvertBinaryToIamge(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInputs() == true)
            {
               /* using (BackhoeEntities db = new BackhoeEntities())
                {
                    //userdetail store in model entity
                    UserDetail user = new UserDetail() { FileName = txtPicName.Text.ToString(), UserPic = ConvertImageToBinary(picUser.Image), ALLUsersID = userID };//userpic in db
                    db.UserDetails.Add(user);
                    db.SaveChangesAsync();
                    MessageBox.Show("Picture Saved", "Success", MessageBoxButtons.OK);
                }
                */

                SqlConnection sql = new SqlConnection(name);
                sql.Open();
                String query = "update Users set password = @pw,UserPic = @pic,FileName = @fname where EmployeeID = @eId ";
                SqlCommand sqlCommand = new SqlCommand(query, sql);
                sqlCommand.Parameters.AddWithValue("@pw", txtPassword.Text.ToString());
                sqlCommand.Parameters.AddWithValue("@pic", ConvertImageToBinary(picUser.Image));
                sqlCommand.Parameters.AddWithValue("@fname", txtPassword.Text.ToString());
                sqlCommand.Parameters.AddWithValue("@eId",int.Parse(txtEmployeeID.Text.ToString()));
                sqlCommand.ExecuteNonQuery();
                sql.Close();
            }
        }

        private bool checkInputs()
        {
            if (txtPicName.Text == " ")
            {
                MessageBox.Show("Enter Picture Name");
                txtPicName.Focus();
                return false;
            }
            else if (txtPassword.Text == " ")
            {
                MessageBox.Show("Enter Password");
                txtPassword.Focus();
                return false;
            }
            else if (txtReEnterPasword.Text == " ")
            {
                MessageBox.Show("Enter re-Password");
                txtReEnterPasword.Focus();
                return false;
            }
           else if (txtPassword.Text == txtReEnterPasword.Text)
            {
                MessageBox.Show("Password are not matching");
                txtReEnterPasword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    /*    public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
      */
      
        
        


        private void UserUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = " ";
            txtPicName.Text = " ";
            txtReEnterPasword.Text = " ";

   /*         SqlConnection sql = new SqlConnection(name);
            sql.Open();

            String query = "select * from UserDetails where UserID = 3";
            SqlCommand sqlCommand = new SqlCommand(query, sql);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {

                // System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                // picUser.Image = System.Drawing.Image.FromStream(ms);
                //byte[] byteBLOBData = (byte[])reader["UserPic"];
                //picUser.Image = ConvertBinaryToIamge(byteBLOBData);
                byte[] byteBLOBData = (byte[])reader["UserPic"];
                picUser.Image = ConvertBinaryToIamge(byteBLOBData);
            }

            sql.Close();
    */ 
    }


        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void picUser_Click(object sender, EventArgs e)
        {

        }
    }
}
