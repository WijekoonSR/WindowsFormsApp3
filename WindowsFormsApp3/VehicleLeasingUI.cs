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
    public partial class VehicleLeasingUI : UserControl
    {
        public VehicleLeasingUI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            vehicleLeasingUIAdd1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            vehicleLeasingUIEdit1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            vehicleLeasingUIView1.BringToFront();
        }
    }
}
