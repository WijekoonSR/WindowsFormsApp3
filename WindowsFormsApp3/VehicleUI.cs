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
    public partial class VehicleUI : UserControl
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        private void VehicleUI_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            vehicleUINew1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            vehicleUIEdit1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            vehicleUIView1.BringToFront();
        }

        private void vehicleUINew1_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            VehicleUIReport vehicleUI = new VehicleUIReport();
            vehicleUI.Show();
            vehicleUI.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
