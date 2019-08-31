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
    public partial class CustomerUI : UserControl
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            customerUINew1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            customerUIEdit1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            customerUINew1.BringToFront();
        }
    }
}
