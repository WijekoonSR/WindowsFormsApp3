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
       

        String VehicleType,VehicleName, VehicleCapacity, VehicleClass, EngineType, Fueltype, Status, Specialization, RegDate, RegNo, ChassisNo;
        public VehicleUINew()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            con.Open();
            VehicleName = txtVehicleName.Text.ToString();

            VehicleCapacity = txtVehicleCapacity.Text.ToString();
            VehicleClass = txtEngineType.Text.ToString();
            /*
             EngineType
             Fueltype
             Status
             Specialization
             RegDate
             RegNo
             ChassisNo;
             */
            string  query = "insert into Vehicles values('" + VehicleType + "','" + VehicleName + "','" + VehicleCapacity + "', '" + EngineType +"' ,'" + Fueltype + "','" + Status + "','" +Specialization +"','" +RegDate +"','" + RegNo +"','" +ChassisNo+"')";
            SqlCommand sqlCommand = new SqlCommand();
        }
    }
}
