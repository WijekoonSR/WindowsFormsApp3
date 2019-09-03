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

        SqlConnection con = new SqlConnection(CustomerUINew.nameServer);
        public CustomerUIView()
        {
            InitializeComponent();
            setDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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
                con.Open();
                String customerID = btnSearch.Text;
                string query_Search = "SELECT * FROM Customer WHERE CustomerID = '" + customerID + "'";

                SqlDataAdapter SDR = new SqlDataAdapter("Select * from Customer", con);
                DataTable dataTable = new DataTable();
                SDR.Fill(dataTable);
                dgvCustomerDetails.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
