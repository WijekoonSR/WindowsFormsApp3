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
            getData();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
          try { 
            sqlConnection.Open();
            string searchid = txtIDView.Text;
            String cmd = "Select * from Assets_Maintenance where AssetsMaintenanceID ='" + searchid + "' ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvAssetsDetails.DataSource = dataTable;
            SqlCommand command = new SqlCommand();
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
            getData();
        }

        private void getData() {
            try {
                sqlConnection.Open();
                String query = "Select * from Assets_Maintenance";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvAssetsDetails.DataSource = dataTable;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string date = dateIssuedDate.Value.ToString("yyyy/MM/dd");
                String cmd = "Select * from Assets_Maintenance where IssuedDate ='" + date + "' ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvAssetsDetails.DataSource = dataTable;
                SqlCommand command = new SqlCommand();
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

        private void btnSearchIssuedDate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string date = datePurchaseDate.Value.ToString("yyyy/MM/dd");
                String cmd = "Select * from Assets_Maintenance where PurchaseDate ='" + date + "' ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvAssetsDetails.DataSource = dataTable;
                SqlCommand command = new SqlCommand();
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

        private void dgvAssetsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
