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
    public partial class EmployeeReportForm : Form
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.DatabaseDataSet.Employee);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
