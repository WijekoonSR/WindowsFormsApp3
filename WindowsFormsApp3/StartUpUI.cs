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
    public partial class StartUpUI : Form
    {
        public StartUpUI()
        {
            InitializeComponent();
        }

        private void StartUpUI_Load(object sender, EventArgs e)
        {

        }

        private void btnExistingUser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
