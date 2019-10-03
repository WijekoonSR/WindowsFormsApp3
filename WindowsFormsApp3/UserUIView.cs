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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class UserUIView : UserControl
    {
        String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        public UserUIView()
        {
            InitializeComponent();
            txtEmployeeID.Text = CurrentUser.getEId();
            txtUserID.Text = CurrentUser.getUId();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void UserUIView_Load(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection(name);
            sql.Open();
            String query = "select * from Users where UserID = @uId";
            SqlCommand com = new SqlCommand(query, sql);
            com.Parameters.AddWithValue("@uId", 1);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    picUser.Image = ConvertBinaryToIamge((byte[])sdr["UserPic"]);
                }

            }
            sql.Close();
        }
        Image ConvertBinaryToIamge(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
