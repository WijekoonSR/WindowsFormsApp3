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
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class CustomerUIEditExtendPeriod : Form
    {
        string endDate;
        string name = CustomerUINew.nameServer;
        string id;
        public CustomerUIEditExtendPeriod()
        {
            InitializeComponent();
         
        }

        private void CustomerUIEditExtendPeriod_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (SqlConnection sql = new SqlConnection(name))
            {
                sql.Open();
                id = txtCustomerID.Text.ToString();
                string query = "select * from Customer where CustomerID = '" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sql);
                SqlDataReader sqlData = sqlCommand.ExecuteReader();
                while (sqlData.Read()) {
                    name = sqlData["name"].ToString();
                    endDate =sqlData["ContractEndDate"].ToString();
                }
                sql.Close();

                txtName.Text = name;
                dtpDate.Value = Convert.ToDateTime(endDate);
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True"))
            {
                sql.Open();
                string newEndDate = dtpDate.Value.ToString("yyyy/MM/dd");
                id = txtCustomerID.Text.ToString();
                string query = "update Customer set ContractEndDate= '"+newEndDate+"' where CustomerID = '"+id+"'";
                SqlCommand sqlCommand = new SqlCommand(query, sql);
                int chk = sqlCommand.ExecuteNonQuery();
                sql.Close();
                if (chk > 0) {
                    DialogResult dr =MessageBox.Show("Extend the customer Contract period to : '"+newEndDate+"'", "Contract Period");
                    if (dr == DialogResult.OK) {
                        this.Close();
                    }
                }
            }
        }
    }
}
