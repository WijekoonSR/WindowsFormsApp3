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
    public partial class NewUserUIPage02 : UserControl
    {
        string un, pw; 
        public NewUserUIPage02()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomeUI homeUI = new HomeUI();
            homeUI.Show();
            this.Hide();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            HomeUI homeUI = new HomeUI();
            homeUI.Show();
            this.Hide();
        }

        void insertUser() {


        }
    }
}
