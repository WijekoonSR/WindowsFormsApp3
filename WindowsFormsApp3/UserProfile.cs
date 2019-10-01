using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UserProfile : UserControl
    {
        public static int chkViewOrEdit;// asssign a value when button click; identify which button clicked
        public UserProfile()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void btnViewprof_Click(object sender, EventArgs e)
        {
            chkViewOrEdit = 0;
            UserUI userNewUI = new UserUI();
            userNewUI.Show();
            this.Hide();

        }

        private void btnEditProf_Click(object sender, EventArgs e)
        {
            chkViewOrEdit = 1;
            UserUI userNewUI = new UserUI();
            userNewUI.Show();
            this.Hide();
        }

        private void btnLogOut_Click_2(object sender, EventArgs e)
        {
            DialogResult DR =  MessageBox.Show(" Log Out ?", "Question", MessageBoxButtons.OKCancel);
            if (DR == DialogResult.OK) {
                LoginForm LG = new LoginForm();
                LG.Show();
                this.Hide();
            }
        }
    }
}
