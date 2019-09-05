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
    public partial class VehicleLeasingUIView : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(VehicleLeasingUIAdd.serverName);
        public VehicleLeasingUIView()
        {
            try
            {
                InitializeComponent();
                getleasingdetails();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void getleasingdetails() {
          try { 
            sqlConnection.Open();
            String name = VehicleLeasingUIAdd.serverName;

            String query = "Select * from Vehicle_Leasings";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dtb1 = new DataTable();
            SDA.Fill(dtb1);

            dgvVehicleLeasing.DataSource = dtb1;


            sqlConnection.Close();

           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void VehicleLeasingUIView_Load(object sender, EventArgs e)
        {
            getleasingdetails();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                String name = VehicleLeasingUIAdd.serverName;

                String query = "Select * from Vehicle_Leasings where VehicleLeasingsID = '" + int.Parse(txtLeasingID.Text.ToString()) + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                DataTable dtb1 = new DataTable();
                SDA.Fill(dtb1);

                dgvVehicleLeasing.DataSource = dtb1;


                sqlConnection.Close();
            }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getleasingdetails();
        }
    }
}
