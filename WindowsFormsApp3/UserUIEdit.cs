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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false}){
                if (ofd.ShowDialog() == DialogResult.OK) {
                    filename = ofd.FileName;
                    lblFileName.Text = filename;
                    picUser.Image = Image.FromFile(filename);
                }
        }
        }

        byte[] ConvertImageToBinary(Image img) {
            using (MemoryStream ms = new MemoryStream()) {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BackhoeEntities db = new BackhoeEntities() ) {
                User user = new User() { FileName = filename, UserPic = ConvertImageToBinary(picUser.Image) };//userpic in db
                db.Users.Add(user);
                db.SaveChangesAsync();
                MessageBox.Show("Picture Saced","Success", MessageBoxButtons.OK);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            using (BackhoeEntities DB = new BackhoeEntities()) {
                list = DB.Users.ToList();
                foreach(User user in list){
                    ListViewItem item = new ListViewItem(user.FileName);
                    listView.Items.Add(item);
                }
            }
        }
        Image ConvertBinaryToIamge(byte[] data) {
            using (MemoryStream ms = new MemoryStream(data)) {
                return Image.FromStream(ms);
            }
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null) {
                picUser.Image = ConvertBinaryToIamge(list[listView.FocusedItem.Index].UserPic);
            }
        }
    }
}
