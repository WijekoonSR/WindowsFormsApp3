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
    public partial class PayrollUIOperaterChangeOTRates : Form
    {
        public PayrollUIOperaterChangeOTRates()
        {
            InitializeComponent();
        }

        private void btnSetOtRates_Click(object sender, EventArgs e)
        {
            payrollUIOperaterSetOTRates1.BringToFront();
        }

        private void btnAddNewOTRates_Click(object sender, EventArgs e)
        {
            payrollUIOperaterAddOTRates1.BringToFront();
        }
    }
}
