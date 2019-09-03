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
        String spareParts, date, issuedDate, shopName, address, email, ownerName;
        string assetsID;
        public AssetsUINew()
        {
            InitializeComponent();
            sqlConnection.Open();
            GetCurrentID();
            sqlConnection.Close();


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblIssuedDate_Click(object sender, EventArgs e)
        {

        }

        int quantity, invoiceNumber, contactNumber, OwnerContact;

        private void picBoxAttachNew_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("Path of file");
            picBoxAttachNew.Image = image;

        }

        float price;
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to clear all fields ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {

                ClearFields();
            }
        }

        SqlCommand sqlCommand;


        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            spareParts = txtSpareParts.Text.ToString();
            quantity = int.Parse(txtQuantity.Text);
            price = float.Parse(txtPrice.Text);
            date = dateNew.Value.ToString("yyyy/MM/dd");
            invoiceNumber = int.Parse(txtInvoiceNumber.Text);
            issuedDate = dateIssued.Value.ToString("yyyy/MM/dd");
            shopName = txtShopName.Text.ToString();
            address = txtAddress.Text.ToString();
            contactNumber = int.Parse(txtContactNo.Text);
            email = txtEmail.Text.ToString();
            ownerName = txtOwnerName.Text.ToString();
            OwnerContact = int.Parse(txtOwnContactNew.Text);


            String query = "insert into Assets_Maintenance(PurchasedSpareParts,Quantity,PurchaseDate,Price,InvoiceNumber,IssuedDate,ShopName,Address,ContactNumber,Email,OwnerName,OwnerContact)" +
                " Values('" + spareParts + "','" + quantity + "','" + date + "','" + price + "','" + invoiceNumber + "', '" + issuedDate + "','" + shopName + "','" + address + "','" + contactNumber + "','" + email + "','" + ownerName + "','" + OwnerContact + "')";


            sqlCommand = new SqlCommand(query, sqlConnection);
            int m = sqlCommand.ExecuteNonQuery();

            if (m == 0) {
                MessageBox.Show("Not Updated");
            }
            else {
                DialogResult DR = MessageBox.Show("Successfully Entered");
                ClearFields();
                if (DR == DialogResult.OK)
                {
                    GetCurrentID();
                }
            }
                sqlConnection.Close();
            }
        


        public void ClearFields()
        {
            
                txtSpareParts.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                dateNew.Value = DateTime.Now;
                txtInvoiceNumber.Clear();
                dateIssued.Value = DateTime.Now;
                txtShopName.Clear();
                txtAddress.Clear();
                txtContactNo.Clear();
                txtEmail.Clear();
                txtOwnerName.Clear();
                txtOwnContactNew.Clear();
            
        }

        public void GetCurrentID() {
            String queryCurrentID = "select IDENT_CURRENT('Assets_Maintenance') + 1";
            SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                assetsID = dataReader[0].ToString();
            }

            txtAssetsID.Text = "AM" + assetsID;
        }
    }
}
