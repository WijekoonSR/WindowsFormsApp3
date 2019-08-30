using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp3
{
    public partial class BookingUICheckCxValidity : Form
    {
        DateTime chkDate;
        public BookingUICheckCxValidity()
        {
            InitializeComponent();
            SqlConnection sqlConnection = new SqlConnection(BookingUINew.name);
            sqlConnection.Open();
            string customerID = BookingUINew.customerID;
            //ID Only takes integers convert and extract it into intger format
            customerID = Regex.Replace(customerID, "[^0-9]", "");

            String query = "select * from Customer where CustomerID = '"+ customerID+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read()) {
                richTxtCxName.Text = dataReader["name"].ToString();
                txtFrom.Text = dataReader["ContractStartDate"].ToString();
                txtTo.Text = dataReader["ContractEndDate"].ToString();
               // chkDate = Convert.ToDateTime(dataReader["ContractEndDate"]).Date; 

            }

            string date2 = DateTime.Now.ToString("dd-MM-yyyy");

            DateTime dateNow = Convert.ToDateTime(DateTime.Now.ToString("yyyy / MM / dd")).Date;
            DateTime dateTo = Convert.ToDateTime(chkDate.ToString("yyyy / MM / dd")).Date;
            TimeSpan timeSpan = dateTo - dateNow;
            if ((timeSpan.TotalDays) >= 0) {
                lblStatusView.Text = "Not Expired";
                lblStatusView.BackColor = System.Drawing.Color.Green;
            }
            else {
                lblStatusView.Text = "Expired";
                lblStatusView.BackColor = System.Drawing.Color.Red;
            } 

           sqlConnection.Close();
        }

        private void richTxtCxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
