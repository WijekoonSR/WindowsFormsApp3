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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class AssetsUIEdit : UserControl
    {

        public static String server = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(server);
        String spareParts, date, issuedDate, shopName, address, email, ownerName, AssetsMaintenanceID, invoiceNumber, contactNumber, OwnerContact,vid;
        int quantity;
        float price;
        Image pic;
        private void picSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string searchID = txtAssetsID.Text.ToString();
            string query = "select * from Assets_Maintenance where AssetsMaintenanceID = '" + searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            while (sdr.Read())
            { 
                vid = sdr["VehicleID"].ToString();
                spareParts = sdr["PurchasedSpareParts"].ToString();
                quantity = int.Parse(sdr["Quantity"].ToString());
                date = sdr["PurchaseDate"].ToString ();
                price = float.Parse(sdr["Price"].ToString());
                invoiceNumber =sdr["InvoiceNumber"].ToString();
                issuedDate = sdr["IssuedDate"].ToString();
                shopName = sdr["ShopName"].ToString();
                address = sdr["Address"].ToString();
                contactNumber = sdr["ContactNumber"].ToString ();
                email = sdr["Email"].ToString();
                ownerName = sdr["OwnerName"].ToString();
                OwnerContact = sdr["OwnerContact"].ToString();
                pic = ConvertBinaryToIamge( (byte[])sdr["AttachmentNew"]);
            }
            sqlConnection.Close();

            picBoxAttachEdit.Image = pic;
            txtVehicleIDEdit.Text = vid;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picBoxAttachEdit_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    picBoxAttachEdit.Image = Image.FromFile(ofd.FileName);
                }
            }
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

            string deletesql = "delete from Assets_Maintenance where AssetsMaintenanceID = '" +txtAssetsID.Text + "'";
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
                invoiceNumber = txtInvoiceNumberEdit.Text;
                issuedDate = dateIssuedEdit.Value.ToString("yyyy/MM/dd");
                shopName = txtShopNameEdit.Text.ToString();
                address = txtAddressEdit.Text.ToString();
                contactNumber = txtContactNoEdit.Text;
                email = txtEmail.Text.ToString();
                ownerName = txtOwnerEdit.Text.ToString();
                OwnerContact = txtOwnContactEdit.Text;

                //ID takes only integer values
                String ID1 = txtAssetsID.Text;
                

                String query = "Update Assets_Maintenance set PurchasedSpareParts = '" + spareParts + "', Quantity = '" + quantity + "',PurchaseDate = '" + date + "',Price = '" + price 
                    + "',InvoiceNumber = '" + invoiceNumber + "', IssuedDate = '" + issuedDate + "', ShopName = '" + shopName + "', Address = '" + address + "',ContactNumber = '" + contactNumber + "', Email ='" + email + "', OwnerName = '" + ownerName + "', OwnerContact = '" + OwnerContact + "' where AssetsMaintenanceID = '" + ID1+"'";



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

        Image ConvertBinaryToIamge(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
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
                picBoxAttachEdit.Image = null;
                txtAssetsID.Clear();
                txtVehicleIDEdit.Clear();
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
