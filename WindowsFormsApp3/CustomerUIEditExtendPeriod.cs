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
        int id;
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
                id = int.Parse(txtCustomerID.Text.ToString());
                string query = "select '" + name + "' = name, '" + endDate + "' = ContractEndDate from Customer where CustomerID = '"+id +"'";
                SqlCommand sqlCommand = new SqlCommand(query,sql);
                sqlCommand.ExecuteNonQuery();
                sql.Close();
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection(name))
            {
                sql.Open();
                string newEndDate = dtpDate.Value.ToString("yyyy/MM/dd");
                id = int.Parse(txtCustomerID.Text.ToString());
                string query = "update Customer set ContractEndDate= '"+newEndDate+"' where CustomerID = '"+id+"'";
                SqlCommand sqlCommand = new SqlCommand(query, sql);
                sqlCommand.ExecuteNonQuery();
                sql.Close();
            }
        }
    }
}
