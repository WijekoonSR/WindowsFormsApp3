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
    public partial class PayrollUISetAllowance : UserControl
    {
        
        public PayrollUISetAllowance()
        {
            InitializeComponent();
        }

        private void btnNewOTRate_Click(object sender, EventArgs e)
        {
            //if(drpHousingAllowance.Items.Count > 0 )//&& !(String.IsNullOrEmpty(drpHousingAllowance.ToString())))
            //{

            //}
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int HousingAllowance = Convert.ToInt32(edtSetHousingAllowance.Text);
            int MedicalAllowance = Convert.ToInt32(edtSetMedicalAllowance.Text);
            int FoodAllowance = Convert.ToInt32(edtSetFoodAllowance.Text);
            drpHousingAllowance.AddItem(HousingAllowance.ToString());
            drpMedicalAllowance.AddItem(MedicalAllowance.ToString());
            drpFoodAllowance.AddItem(FoodAllowance.ToString());

            
        }

        private void drpHousingAllowance_onItemSelected(object sender, EventArgs e)
        {
            MessageBox.Show(drpHousingAllowance.ToString());
        }

        private void drpMedicalAllowance_onItemSelected(object sender, EventArgs e)
        {
            MessageBox.Show(drpMedicalAllowance.ToString());
        }

        private void drpFoodAllowance_onItemSelected(object sender, EventArgs e)
        {
            MessageBox.Show(drpFoodAllowance.ToString());
        }
    }
}
