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
        String vID;


        String Model, VehicleClass, EngineType, Fueltype, VehicleCapacity, Colour, Weight, RegDate, RegNo, ChassisNo, YearOfManufac, VehicleType;
        

        int HiringRate;
        private void VehicleUINew_Load(object sender, EventArgs e)
        {

        }

        private void lblVehicleType_Click(object sender, EventArgs e)
        {

        }


        public VehicleUINew()
        {
            InitializeComponent();
            getVehicleID();
            dropdownVehicleType.AddItem("Excavators");
            dropdownVehicleType.AddItem("Backhoe Loaders");
            dropdownVehicleType.AddItem("Bulldozers");
            dropdownVehicleType.AddItem("Skid Steer Loaders");
            dropdownVehicleType.AddItem("Motor Graders");
            dropdownVehicleType.AddItem("Trenchers");




        }

        private void getVehicleID()
        {
            try
            {
                con.Open();
                String queryCurrentID = "select IDENT_CURRENT('Vehicles')";
                SqlCommand command = new SqlCommand(queryCurrentID, con);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    vID = dataReader[0].ToString();
                }
                con.Close();

                con.Open();
                SqlCommand chkExistsData = new SqlCommand("select * from Vehicles where VehicleID = 1", con);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtVehicleID.Text = "B" + (int.Parse(vID) + 1).ToString();
                else txtVehicleID.Text = "B1";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehicle UI");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChassisNo.Clear();
            txtEngineType.Clear();
            txtFuelType.Clear();
            
            txtWeight.Clear();
            txtModel.Clear();
            txtRegistrationNo.Clear();
            txtColour.Clear();
            txtVehicleCapacity.Clear();
            txtVehicleClass.Clear();
            txtYearOfManufacture.Clear();
           
            DateRegistration.Value = DateTime.Now;
            dropdownVehicleType.Text = null;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModel.Text == "")
                {
                    MessageBox.Show("Please Enter the Model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModel.Focus();
                }
                else if (txtVehicleCapacity.Text == "")
                {
                    MessageBox.Show("Please Enter the Vehical Capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVehicleCapacity.Focus();
                }
                else if (txtVehicleClass.Text == "")
                {
                    MessageBox.Show("Please Enter the Vehical Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVehicleClass.Focus();
                }
                else if (txtEngineType.Text == "")
                {
                    MessageBox.Show("Please Enter the Engine Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEngineType.Focus();
                }
                else if (txtFuelType.Text == "")
                {
                    MessageBox.Show("Please Enter the Fuel Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuelType.Focus();
                }
                else if (txtColour.Text == "")
                {
                    MessageBox.Show("Please Enter the Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtColour.Focus();
                }
                else if (txtWeight.Text == "")
                {
                    MessageBox.Show("Please Enter the Machine Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeight.Focus();
                }
                else if (txtRegistrationNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegistrationNo.Focus();
                }
                else if (txtChassisNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Chassis Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChassisNo.Focus();
                }
                else if (txtYearOfManufacture.Text == "")
                {
                    MessageBox.Show("Please Enter the Year Of Manufacture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtYearOfManufacture.Focus();
                }
               

                else
                {

                    con.Open();
                    VehicleType = dropdownVehicleType.selectedValue.ToString();
                    Model = txtModel.Text.ToString();
                    VehicleCapacity = txtVehicleCapacity.Text.ToString();
                    VehicleClass = txtVehicleClass.Text.ToString();
                    EngineType = txtEngineType.Text.ToString();
                    Fueltype = txtFuelType.Text.ToString();
                    Colour = txtColour.Text.ToString();
                    Weight = txtWeight.Text.ToString();
                    RegDate = DateRegistration.Value.ToString("yyyy/MM/dd");
                    RegNo = txtRegistrationNo.Text.ToString();
                    YearOfManufac = txtYearOfManufacture.Text.ToString();
                    ChassisNo = txtChassisNo.Text.ToString();
                


                    string query = "insert into Vehicles(VehicleType,Model,VehicleClass,EngineNo,FuelType,VehicleCapacity,Colour,Weights,RegistrationDate,RegistrationNo,YearOfManufacture,ChassiNo)" +
                        " values('" + VehicleType + "','" + Model + "','" + VehicleClass + "','" + EngineType + "', '" + Fueltype + "' ,'" + VehicleCapacity + "','" + Colour + "','" + Weight + "','" + RegDate + "','" + RegNo + "','" + YearOfManufac + "','" + ChassisNo + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    con.Close();
                }
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
