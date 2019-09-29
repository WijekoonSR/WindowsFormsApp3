using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void UserNewUI_Load(object sender, EventArgs e)
        {
            if (UserProfile.chkViewOrEdit == 0)
            {
                userUIView1.BringToFront();
            }
            else if (UserProfile.chkViewOrEdit == 1)
            {
                userUIEdit1.BringToFront();
            }
         }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }
    }
}
