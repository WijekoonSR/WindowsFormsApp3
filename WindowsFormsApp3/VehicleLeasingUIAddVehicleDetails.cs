using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VehicleLeasingUIAddVehicleDetails : Form
    {
        static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(name);
        string Model, VehicleCapacity, EngineType, Fueltype;
        public VehicleLeasingUIAddVehicleDetails()
        {
            InitializeComponent();
        }

        private void VehicleLeasingUIAddVehicleDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            String searchID = VehicleLeasingUIAdd.search.ToString();
            string query = "select * from Vehicles where vehicleID = '" + searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader SDR = sqlCommand.ExecuteReader();
            while (SDR.Read())
            {

                Model = SDR["Model"].ToString();
                VehicleCapacity = SDR["VehicleCapacity"].ToString();
                EngineType = SDR["EngineType"].ToString();
                Fueltype = SDR["FuelType"].ToString();
            }
            con.Close();
            txtCapacity.Text = VehicleCapacity;
            txtEnginetype.Text = EngineType;
            txtFuelType.Text = Fueltype;
            txtModel.Text = Model;

        }
    }
}
