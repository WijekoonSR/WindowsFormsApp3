using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class VehicleUINew : UserControl
    {

        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(name);


        String Model, VehicleCapacity, VehicleClass, EngineType, Fueltype, Status, MachineCategory, RegDate, RegNo, ChassisNo, YearOfManufac, HiringRate, DateOfCom, VehicleType;
        public VehicleUINew()
        {
            InitializeComponent();
            dropdownVehicleType.AddItem("Excavator");
            dropdownVehicleType.AddItem("Backhoe Loaders");
            dropdownVehicleType.AddItem("Bulldozers");
            dropdownVehicleType.AddItem("Skid Steer Loaders");
            dropdownVehicleType.AddItem("Motor Grade");
            dropdownVehicleType.AddItem("Trenchers");




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChassisNo.Clear();
            txtDateOfCom.Clear();
            txtEngineType.Clear();
            txtFuelType.Clear();
            txtHiringRate.Clear();
            txtMachineCat.Clear();
            txtModel.Clear();
            txtRegistrationNo.Clear();
            txtStatus.Clear();
            txtVehicleCapacity.Clear();
            txtVehicleClass.Clear();
            txtYearOfManufacture.Clear();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblVehicleCapacity_Click(object sender, EventArgs e)
        {

        }

        private void VehicleUINew_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                VehicleType = dropdownVehicleType.selectedValue.ToString();
                Model = txtModel.Text.ToString();
                VehicleCapacity = txtVehicleCapacity.Text.ToString();
                VehicleClass = txtVehicleClass.Text.ToString();
                EngineType = txtEngineType.Text.ToString();
                Fueltype = txtFuelType.Text.ToString();
                Status = txtStatus.Text.ToString();
                MachineCategory = txtMachineCat.Text.ToString();
                RegDate = DateRegistration.Value.ToString("yyyy/MM/dd");
                RegNo = txtRegistrationNo.Text.ToString();
                ChassisNo = txtChassisNo.Text.ToString();
                HiringRate = txtHiringRate.Text.ToString();
                DateOfCom = txtDateOfCom.Text.ToString();



                string query = "insert into Vehicles(VehicleType,Model,VehicleCapacity,VehicleClass,EngineType,FuelType,Status,MachineCategory,RegistrationDate,RegistrationNo,ChassisNo,YearOfManufacture,HiringRate,DateOfCommencemnet) values('" + VehicleType + "','" + Model + "','" + VehicleCapacity + "', '" + EngineType + "' ,'" + Fueltype + "','" + Status + "','" + DateOfCom + "','" + RegDate + "','" + RegNo + "','" + ChassisNo + "','" + HiringRate + "','" + YearOfManufac + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}