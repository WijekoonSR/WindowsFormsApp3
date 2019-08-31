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
    public partial class AssetsUIView : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(AssetsUINew.server);
        public AssetsUIView()
        {
           
            InitializeComponent();
            sqlConnection.Open();
            String query = "Select * from Assets_Maintenance";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvAssetsDetails.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void lblIssuedDate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
