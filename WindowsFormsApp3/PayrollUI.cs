﻿using System;
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
            payrollUIEdit2.BringToFront();
        }
    }
}
