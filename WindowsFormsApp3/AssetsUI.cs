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
    public partial class AssetsUI : UserControl
    {
        public AssetsUI()
        {
            InitializeComponent();
        }

        private void AssetsUI_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            assetsUIView1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          assetsUIEdit1.BringToFront();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            assetsUINew1.BringToFront();
        }

        private void assetsUINew1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
