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
    public partial class VehicleUIEdit : UserControl
    {
        public VehicleUIEdit()
        {
            InitializeComponent();
        }

        private void VehicleUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want Delete selected Row?",
                 "Important",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
        }
    }
}
