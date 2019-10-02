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

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            Slider.Left = btnNew.Left;
            customerUINew.BringToFront();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Slider.Left = btnEdit.Left;
            customerUIEdit.BringToFront();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            Slider.Left = btnView.Left;
            customerUIView.BringToFront();

        }

        private void customerUINew2_Load(object sender, EventArgs e)
        {
                
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Slider.Left = btnReport.Left;
            CustomerReport customerReport = new CustomerReport();
            customerReport.Show();
            customerReport.BringToFront();
        }
    }
}
