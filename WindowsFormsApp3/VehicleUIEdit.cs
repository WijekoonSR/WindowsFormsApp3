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

        String Model, VehicleCapacity, VehicleClass, EngineType, Fueltype, Status, MachineCategory, RegDate, RegNo, ChassisNo, YearOfManufac, DateOfCom, VehicleType;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            String searchID = txtSearch.Text.ToString();
            string query = "select * from Vehicles where vehicleID = '" + searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader SDR = sqlCommand.ExecuteReader();
            while (SDR.Read())
            {
                
                Model =SDR["Model"].ToString();
                VehicleCapacity = SDR["VehicleCapacity"].ToString();
                VehicleClass = SDR["VehicleClass"].ToString();
                EngineType = SDR["EngineType"].ToString();
                Fueltype = SDR["FuelType"].ToString();
                Status = SDR["Status"].ToString();
                MachineCategory = SDR["MachineCategory"].ToString();
                RegDate = SDR["RegistrationDate"].ToString();
                RegNo = SDR["RegistrationNo"].ToString();
                YearOfManufac = SDR["YearOfManufacture"].ToString();
                ChassisNo = SDR["ChassisNo"].ToString();
                HiringRate = int.Parse(SDR["HiringRate"].ToString());
                DateOfCom = SDR["DateOfCommencemnet"].ToString();
            }
            con.Close();
            txtModel.Text = Model;
            txtVehicleCapacity.Text = VehicleCapacity;
            txtVehicleClass.Text = VehicleClass;
            txtEngineType.Text = EngineType;
            txtFuelType.Text = Fueltype;
            txtStatus.Text = Status;
            txtMachineCat.Text = MachineCategory;
            DateRegistration.Text = RegDate;
            txtRegistrationNo.Text = RegNo;
            txtYearOfManufacture.Text = YearOfManufac;
            txtChassisNo.Text = ChassisNo;
            txtHiringRate.Text = HiringRate.ToString();
            DateCommencement.Text = DateOfCom;





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
            DialogResult result = MessageBox.Show("Do You Want Delete selected Row?", "Important", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                con.Open();
                string id = txtSearch.Text.ToString();
                SqlCommand command1 = new SqlCommand("delete from Booking_Vehicle where VehicleID = '" + id + "'", con);
                SqlCommand command2 = new SqlCommand("delete from Vehicles where VehicleID  = '" + id + "'", con);
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
  
            Model = txtModel.Text.ToString();
            VehicleCapacity = txtVehicleCapacity.Text.ToString();
            VehicleClass = txtVehicleClass.Text.ToString();
            EngineType = txtEngineType.Text.ToString();
            Fueltype = txtFuelType.Text.ToString();
            Status = txtStatus.Text.ToString();
            MachineCategory = txtMachineCat.Text.ToString();
            RegDate = DateRegistration.Value.ToString("yyyy/MM/dd");
            RegNo = txtRegistrationNo.Text.ToString();
            YearOfManufac = txtYearOfManufacture.Text.ToString();
            ChassisNo = txtChassisNo.Text.ToString();
            HiringRate = int.Parse(txtHiringRate.Text.ToString());
            DateOfCom = DateCommencement.Value.ToString("yyyy/MM/dd");


            string query =" UPDATE Vehicles set Model ='" + Model + "',VehicleCapacity = '" + VehicleCapacity+ "',VehicleClass = '"+ VehicleClass + "',EngineType ='"+EngineType+ "',Fueltype ='"+Fueltype+ "',Status ='"+Status+ "',MachineCategory ='" + MachineCategory+"',RegistrationDate ='"+ RegDate +"',RegistrationNo ='"+RegNo +"',ChassisNo ='"+ChassisNo +"',YearOfManufacture ='"+YearOfManufac+"',HiringRate ='"+HiringRate+"',DateOfCommencemnet ='"+DateOfCom+"'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            con.Close();

        }
    }
}
