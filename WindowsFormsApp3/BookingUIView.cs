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
    public partial class BookingUIView : UserControl
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public BookingUIView()
        {
            InitializeComponent();
            String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name)) {
                string query = "select * from Bookings";
                SqlDataAdapter SDA = new SqlDataAdapter(query,sqlConnection);
                DataTable dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;

            }
        }

        private void BookingUIView_Load(object sender, EventArgs e)
        {

        }

        private void dgvBookingsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
