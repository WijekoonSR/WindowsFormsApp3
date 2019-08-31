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
            using (con) {
                con.Open();
                SqlDataAdapter SDR = new SqlDataAdapter("Select * from Customer", con);
                DataTable dataTable = new DataTable();
                SDR.Fill(dataTable);
                dgvCustomerDetails.DataSource = dataTable;
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
