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
    public partial class BookingUINewCheckVehicles : Form
    {
        public BookingUINewCheckVehicles()
        {
            try
            {
                InitializeComponent();
                String dateStartDate = BookingUINew.startDate;
                String dateEndDate = BookingUINew.endDate;
                int WorkingHours = BookingUINew.hours;

                using (SqlConnection sql = new SqlConnection(BookingUINew.name))
                {
                    sql.Open();
  //                  string queryInit = "exec procAvailableVehicles '"+dateStartDate+"', '"+dateEndDate + "'";
                    string query = "SELECT * FROM ##tblAvailableVehicles";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sql);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dgvAvaiableVehicles.DataSource = dataTable;
                    sql.Close();

                }
            }
            catch (Exception e) {

            }
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAvaiableVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
