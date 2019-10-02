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
    public partial class CustomerUIView : UserControl
    {
        public static string sqlname = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(sqlname);

        //SqlConnection con = new SqlConnection(CustomerUINew.nameServer);
        public CustomerUIView()
        {
            InitializeComponent();
          
            setDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // sqlConnection.Open();
                string SearchID = txtCustomerID.Text;
                String cmd = "SELECT * from Customer where CustomerID = '" + SearchID + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvCustomerDetails.DataSource = dataTable;
                //SqlCommand command = new SqlCommand();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching" + ex);
            }
            finally {
                sqlConnection.Close();
            }
        }
            
        private void dgvCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerUIView_Load(object sender, EventArgs e)
        {
            setDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setDataGridView();
        }

        private void setDataGridView() {
            try
            {
                sqlConnection.Open();
                String customerID = btnSearch.Text;
                string query_Search = "SELECT * FROM Customer WHERE CustomerID = '" + customerID + "'";

                SqlDataAdapter SDR = new SqlDataAdapter("Select * from Customer", sqlConnection);
                DataTable dataTable = new DataTable();
                SDR.Fill(dataTable);
                dgvCustomerDetails.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to delete data ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (DR == DialogResult.OK)
            {
                sqlConnection.Open();
                string id = txtCustomerID.Text.ToString();
                SqlCommand command = new SqlCommand("delete from Customer  where CustomerID  = '" + id + "'",sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
