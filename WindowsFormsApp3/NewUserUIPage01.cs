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
    public partial class NewUserUIPage01 : UserControl
    {
        public static string userID, password;
        public NewUserUIPage01()
        {
            InitializeComponent();
        }

        private void newUserUIPage021_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string chkPassword;
            userID = txtUserID.Text.ToString();
            password = txtPassword.Text.ToString();
            chkPassword = txtReEnterPW.Text.ToString();
            if (password != chkPassword)
            {
                DialogResult DR = MessageBox.Show("Password is not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (DR == DialogResult.OK)
                {
                    txtPassword.Focus();
                }
            }
            else
            {
                userID = txtUserID.Text.ToString();
                password = txtPassword.Text.ToString();
                newUserUIPage021.BringToFront();
            }
        }
    }
}
