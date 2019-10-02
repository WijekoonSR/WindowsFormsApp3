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
    public partial class PayrollUIPaySlip : Form
    {
        public PayrollUIPaySlip()
        {
            InitializeComponent();
        }

        private void PayrollUIPaySlip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseDataSet.Payroll_Staff' table. You can move, or remove it, as needed.
            this.Payroll_StaffTableAdapter.Fill(this.DatabaseDataSet.Payroll_Staff);

            this.reportViewer1.RefreshReport();

            /*using (DatabaseDataSet db = new DatabaseDataSet())
            {
               // Payroll_StaffBindingSource.DataSource = db.Payroll_Staff()
              // Microsoft.Reporting.WebForms.ReportParameter
            };
            //reportViewer1.LocalReport.set
            reportViewer1.RefreshReport();*/
        }

    }
}
