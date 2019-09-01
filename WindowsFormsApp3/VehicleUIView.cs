using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VehicleUIView : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(VehicleUINew.name);
        public VehicleUIView()
        {
            InitializeComponent();
            sqlConnection.Open();
            String query = "Select * from Vehicles";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable datTable  = new DataTable();
            sqlAdapter.Fill(datTable);
            dgvView.DataSource = datTable;





        }

        private void VehicleUIView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
