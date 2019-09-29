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
        string filename;
        List<User> list;
        public UserUIEdit()
        {
            InitializeComponent();
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
            /*using (BackhoeEntities db = new BackhoeEntities() ) {
                 User user = new User() { FileName = filename, UserPic = ConvertImageToBinary(picUser.Image) };//userpic in db
                 db.Users.Add(user);
                 db.SaveChangesAsync();
                 MessageBox.Show("Picture Saved","Success", MessageBoxButtons.OK);
             }
            */
            String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
            SqlConnection sql = new SqlConnection(name);
            sql.Open();
            string query = "insert into Users(UserPic) values(@id)";
            SqlCommand sqlCommand = new SqlCommand(query, sql);
            sqlCommand.Parameters.AddWithValue("@id", ConvertImageToBinary(picUser.Image));
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            using (BackhoeEntities DB = new BackhoeEntities())
            {
                list = DB.Users.ToList();
                foreach (User user in list)
                {
                    ListViewItem item = new ListViewItem(user.FileName);
                    listView.Items.Add(item);
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
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                picUser.Image = ConvertBinaryToIamge(list[listView.FocusedItem.Index].UserPic);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

            SqlConnection sql = new SqlConnection(name);
            sql.Open();

            String query = "select * from Users where UserID = 3";
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
        }

        private void UserUIEdit_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}
