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
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class AssetsUIEdit : UserControl
    {

        public static String server = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(server);
        String spareParts, date, issuedDate, shopName, address, email, ownerName;
        int quantity, invoiceNumber, contactNumber, OwnerContact;
        float price;

        private void picSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string searchID = txtAssetsID.Text.ToString();
            string query = "select * from Assets_Maintenance where AssetsMaintenanceID = '" + searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            while (sdr.Read())
            {
                spareParts = sdr["PurchasedSpareParts"].ToString();
                quantity = int.Parse(sdr["Quantity"].ToString());
                date = sdr["PurchaseDate"].ToString ();
                price = float.Parse(sdr["Price"].ToString());
                invoiceNumber = int.Parse(sdr["InvoiceNumber"].ToString());
                issuedDate = sdr["IssuedDate"].ToString();
                shopName = sdr["ShopName"].ToString();
                address = sdr["Address"].ToString();
                contactNumber = int.Parse(sdr["ContactNumber"].ToString ());
                email = sdr["Email"].ToString();
                ownerName = sdr["OwnerName"].ToString();
                OwnerContact = int.Parse(sdr["OwnerContact"].ToString()); 

            }
            sqlConnection.Close();

            txtSpareEdit.Text = spareParts;
            txtQuantityEdit.Text = quantity.ToString ();
            dateEdit.Text = date;
            txtPriceEdit.Text = price.ToString();
            txtInvoiceNumberEdit.Text = invoiceNumber.ToString();
            dateIssuedEdit.Text = issuedDate;
            txtShopNameEdit.Text = shopName;
            txtAddressEdit.Text = address;
            txtContactNoEdit.Text = contactNumber.ToString();
            txtEmail.Text = email;
            txtOwnerEdit.Text = ownerName;
            txtOwnContactEdit.Text = OwnerContact.ToString();


        }

        private void btnClearEdit_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        String assetsID;
        public AssetsUIEdit()
        {
            InitializeComponent();

        }

        private void AssetsUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void lblQuantityNew_Click(object sender, EventArgs e)
        {

        }

        private void lblAttachmentsEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblIssuedDate_Click(object sender, EventArgs e)
        {

        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string deletesql = "delete from Assets_Maintenance where AssetsMaintenanceID = '" + int.Parse(txtAssetsID.Text) + "'";
            SqlCommand command = new SqlCommand(deletesql,sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            
            MessageBox.Show("Delete Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();



                spareParts = txtSpareEdit.Text.ToString();
                quantity = int.Parse(txtQuantityEdit.Text);
                price = float.Parse(txtPriceEdit.Text);
                date = dateEdit.Value.ToString("yyyy/MM/dd");
                invoiceNumber = int.Parse(txtInvoiceNumberEdit.Text);
                issuedDate = dateIssuedEdit.Value.ToString("yyyy/MM/dd");
                shopName = txtShopNameEdit.Text.ToString();
                address = txtAddressEdit.Text.ToString();
                contactNumber = int.Parse(txtContactNoEdit.Text);
                email = txtEmail.Text.ToString();
                ownerName = txtOwnerEdit.Text.ToString();
                OwnerContact = int.Parse(txtOwnContactEdit.Text);

                //ID takes only integer values
                String ID = txtAssetsID.Text;
                ID = Regex.Replace(ID, "[^0-9]", "");
                int ID1 = int.Parse(ID);

                String query = "Update Assets_Maintenance set PurchasedSpareParts = '" + spareParts + "', Quantity = '" + quantity + "',PurchaseDate = '" + date + "',Price = '" + price + "',InvoiceNumber = '" + invoiceNumber + "', IssuedDate = '" + issuedDate + "', ShopName = '" + shopName + "', Address = '" + address + "',ContactNumber = '" + contactNumber + "', Email ='" + email + "', OwnerName = '" + ownerName + "', OwnerContact = '" + OwnerContact + "'";



                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int m = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (m == 0)
                {
                    MessageBox.Show("Not Updated");
                }
                else
                {
                    DialogResult DR = MessageBox.Show("Successfully Updated");
                    
                    if (DR == DialogResult.OK)
                    {
                        ClearFields();
                        GetCurrentID();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AssetsUI3 ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void txtPriceEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            try
            {
                txtSpareEdit.Clear();
                txtQuantityEdit.Clear();
                txtPriceEdit.Clear();
                dateEdit.Value = DateTime.Now;
                txtInvoiceNumberEdit.Clear();
                dateIssuedEdit.Value = DateTime.Now;
                txtShopNameEdit.Clear();
                txtAddressEdit.Clear();
                txtContactNoEdit.Clear();
                txtEmail.Clear();
                txtOwnerEdit.Clear();
                txtOwnContactEdit.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetCurrentID()
        {
            try
            {
                sqlConnection.Open();

                String queryCurrentID = "select  IDENT_CURRENT('Assets_Maintenance')";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    assetsID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                sqlConnection.Open();

                SqlCommand chkExistsData = new SqlCommand("select * from Assets_Maintenance where AssetsMaintenanceID = 1", sqlConnection);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtAssetsID.Text = "AM" + (int.Parse(assetsID) + 1).ToString();
                else txtAssetsID.Text = "AM1";

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AssetsUI 4");
            }
            finally
            {
                sqlConnection.Close();
            }
           
        }
    }
}
