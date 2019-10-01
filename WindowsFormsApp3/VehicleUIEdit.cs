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
    public partial class VehicleUIEdit : UserControl
    {
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(name);
        String vID;

        String Model, VehicleCapacity, VehicleClass, EngineType, Fueltype, Colour, Weight, RegDate, RegNo, ChassisNo, YearOfManufac, VehicleType;

        
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String searchID = txtSearch.Text.ToString();
            string query = "select * from Vehicles where vehicleID = '" + searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader SDR = sqlCommand.ExecuteReader();
            while (SDR.Read())
            {
                dropdownVehicleType.AddItem(SDR["VehicleType"].ToString());
                Model = SDR["Model"].ToString();
                VehicleClass = SDR["VehicleClass"].ToString();
                EngineType = SDR["EngineNo"].ToString();
                Fueltype = SDR["FuelType"].ToString();
                VehicleCapacity = SDR["VehicleCapacity"].ToString();
                Colour = SDR["colour"].ToString();
                Weight = SDR["Weights"].ToString();
                RegDate = SDR["RegistrationDate"].ToString();
                RegNo = SDR["RegistrationNo"].ToString();
                YearOfManufac = SDR["YearOfManufacture"].ToString();
                ChassisNo = SDR["ChassiNo"].ToString();
                
            }
            con.Close();
            txtModel.Text = Model;
            txtVehicleClass.Text = VehicleClass;
            txtEngineType.Text = EngineType;
            txtFuelType.Text = Fueltype;
            txtVehicleCapacity.Text = VehicleCapacity;
            txtColour.Text = Colour;
            txtWeight.Text = Weight;
            DateRegistration.Text = RegDate;
            txtRegistrationNo.Text = RegNo;
            txtYearOfManufacture.Text = YearOfManufac;
            txtChassisNo.Text = ChassisNo;

           





        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        int HiringRate;
        public VehicleUIEdit()
        {
            InitializeComponent();
        }

        private void VehicleUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int VehicleID = int.Parse(txtSearch.Text);
            try
            {
                con.Open();
                 string sql1 = "DELETE FROM Assets_Maintenance WHERE VehicleID ='" + VehicleID + "'";
                 string sql2 = "DELETE FROM Booking_Vehicle WHERE VehicleID ='" + VehicleID + "'";
                 string sql3 = "DELETE FROM Vehicle_Leasings WHERE vehicleID ='" + VehicleID + "' ";
                string sql4 = "DELETE FROM Vehicles WHERE VehicleID ='" + VehicleID + "'";
                 SqlCommand cmd1 = new SqlCommand(sql1, con);
                 SqlCommand cmd2 = new SqlCommand(sql2, con);
                 SqlCommand cmd3 = new SqlCommand(sql3, con);
                SqlCommand cmd4 = new SqlCommand(sql4, con);

                //cmd1.ExecuteNonQuery();
                // cmd2.ExecuteNonQuery();
               //  cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();


                MessageBox.Show("Data record delted!", "DB Connection with App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
                clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult result = MessageBox.Show("Do You Want Delete selected Row?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    con.Open();
                    string id = txtSearch.Text.ToString();
                    // SqlCommand command1 = new SqlCommand("delete from Booking_Vehicle where VehicleID = '" + id + "'", con);
                    SqlCommand command2 = new SqlCommand("delete from Vehicles where VehicleID  = '" + id + "'", con);
                    // command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    con.Close();
                }
            }
        }



        private void clear()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int VehicleID = int.Parse(txtSearch.Text);
            con.Open();

            Model = txtModel.Text.ToString();
            VehicleClass = txtVehicleClass.Text.ToString();
            EngineType = txtEngineType.Text.ToString();
            Fueltype = txtFuelType.Text.ToString();
            VehicleCapacity = txtVehicleCapacity.Text.ToString();
            Colour = txtColour.Text.ToString();
            Weight = txtWeight.Text.ToString();
            RegDate = DateRegistration.Value.ToString("yyyy/MM/dd");
            RegNo = txtRegistrationNo.Text.ToString();
            YearOfManufac = txtYearOfManufacture.Text.ToString();
            ChassisNo = txtChassisNo.Text.ToString();
            


            string query = " UPDATE Vehicles set Model ='" + Model + "', VehicleClass = '" + VehicleClass + "',EngineNo ='" + EngineType + "',Fueltype ='" + Fueltype + "',VehicleCapacity ='" + VehicleCapacity + "',Colour ='" + Colour + "',Weights ='" + Weight + "',RegistrationDate ='" + RegDate + "',RegistrationNo ='" + RegNo + "',YearOfManufacture ='" + YearOfManufac + "',ChassiNo ='" + ChassisNo + "'where VehicleID = '" + VehicleID + "' ";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            con.Close();

        }
    }
}
