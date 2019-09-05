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
    public partial class EmployeeUI : UserControl
    {
        public EmployeeUI()
        {
            InitializeComponent();
            employeeUINewOperator1.BringToFront();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            employeeUINewOperator1.BringToFront();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            employeeUINewStaff1.BringToFront();
        }

        private void btnEditOperator_Click(object sender, EventArgs e)
        {
            employeeUIEditOperator1.BringToFront();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            employeeUIEditStaff1.BringToFront();
        }

        private void btnEmployeeView_Click(object sender, EventArgs e)
        {
            employeeUIView1.BringToFront();
        }

        private void employeeUIView1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            employeeUIViewStaff1.BringToFront();
        }
    }
}
