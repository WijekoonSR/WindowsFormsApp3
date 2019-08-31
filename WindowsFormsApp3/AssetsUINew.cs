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
    public partial class AssetsUINew : UserControl
    {
        public static String server = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(server);
        String spareParts, date, issuedDate, shopName, address,  email, ownerName;
        int quantity;
        SqlCommand sqlCommand;

        public AssetsUINew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            
            spareParts = txtSpareParts.Text.ToString();
            date = dateNew.Value.ToString("dd/mm/yyyy");
            issuedDate = dateIssued.Value.ToString("dd/mm/yyyy");
            shopName = txtShopName.Text.ToString();
            address = txtAddress.Text.ToString();
            email = txtEmail.Text.ToString();
            ownerName = txtOwnerName.Text.ToString();

            //insert her##########################################
            sqlCommand = new SqlCommand("");
            sqlConnection.Close();
        }
    }
}
