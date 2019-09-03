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
    public partial class PayrollUI : UserControl
    {
        public PayrollUI()
        {
            InitializeComponent();
        }

        private void PayrollUI_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            payrollUINew1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           // payrollUIEdit2.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnOperater_Click(object sender, EventArgs e)
        {
            payrollUINew1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
           // payrollUIStaffNew1.BringToFront();
           
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            payrollUINew1.BringToFront();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            payrollUIStaffNew1.BringToFront();
        }

        private void btnEditOperator_Click(object sender, EventArgs e)
        {
            payrollUIEditOperater1.BringToFront();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            payrollUIEditStaff1.BringToFront();
        }

        private void btnEmployeeView_Click(object sender, EventArgs e)
        {
            payrollUIVeiw1.BringToFront();
        }

        private void payrollUIStaffNew1_Load(object sender, EventArgs e)
        {

        }

        private void payrollUINew1_Load(object sender, EventArgs e)
        {

        }
    }
}
