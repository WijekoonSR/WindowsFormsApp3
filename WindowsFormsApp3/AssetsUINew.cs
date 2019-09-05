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
    public partial class AssetsUINew : UserControl
    {
        public static String server = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(server);
        String spareParts, date, issuedDate, shopName, address, email, ownerName;
        string assetsID;
        public AssetsUINew()
        {
            try
            {
                InitializeComponent();
                GetCurrentID();
            }
            catch (Exception e)
            {
                MessageBox.Show( e.Message, "AssetsUI1 ");
            }
 

        }

        int quantity, invoiceNumber, contactNumber, OwnerContact;

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool isValidEmailAddress(String s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            else
            {
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(s) && !s.EndsWith(".");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

        }

        private void picBoxAttachNew_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("Path of file");
            picBoxAttachNew.Image = image;

        }

        float price;
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to clear all fields ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {

                    ClearFields();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "AssetsUI 2");
            }
        }

        SqlCommand sqlCommand;

        public object Response { get; private set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSpareParts.Text == "")
                {
                    MessageBox.Show("Please Enter the Purchased Spare Part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSpareParts.Focus();
                }
                else if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Please Enter the Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                }
                else if (dateNew.Text == "")
                {
                    MessageBox.Show("Please Enter the Purchased date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateNew.Focus();
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please Enter the Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                }
                else if (txtInvoiceNumber.Text == "")
                {
                    MessageBox.Show("Please Enter the Invoice Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInvoiceNumber.Focus();
                }
                else if (dateIssued.Text == "")
                {
                    MessageBox.Show("Please Enter the Issued date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateIssued.Focus();
                }
                else if (txtShopName.Text == "")
                {
                    MessageBox.Show("Please Enter the Shop Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtShopName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter the Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddress.Focus();
                }
                else if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please Enter the Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContactNo.Focus();
                }

                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please Enter the Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                  
                }
               
               else  if (isValidEmailAddress(txtEmail.Text.ToString()) == false)
                {
                    MessageBox.Show("This is not a valid Email address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (txtOwnerName.Text == "")
                {
                    MessageBox.Show("Please Enter the Owner Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOwnerName.Focus();
                }
                else if (txtOwnContactNew.Text == "")
                {
                    MessageBox.Show("Please Enter the Owner Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOwnContactNew.Focus();
                }

                else
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

                    //ID takes only integer values
                    String ID = txtVehicleID.Text;
                    ID = Regex.Replace(ID, "[^0-9]", "");
                    int VehicleID = int.Parse(ID);

                    String query = "insert into Assets_Maintenance(VehicleID,PurchasedSpareParts,Quantity,PurchaseDate,Price,InvoiceNumber,IssuedDate,ShopName,Address,ContactNumber,Email,OwnerName,OwnerContact)" +
                        " Values('" + VehicleID + "' ,'" + spareParts + "','" + quantity + "','" + date + "','" + price + "','" + invoiceNumber + "', '" + issuedDate + "','" + shopName + "','" + address + "','" + contactNumber + "','" + email + "','" + ownerName + "','" + OwnerContact + "')";


                    sqlCommand = new SqlCommand(query, sqlConnection);
                    int m1 = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (m1 == 0)
                    {
                        MessageBox.Show("Not Updated");
                    }
                    else
                    {
                        DialogResult DR = MessageBox.Show("Successfully Entered");
                        ClearFields();
                        if (DR == DialogResult.OK)
                        {
                            GetCurrentID();
                        }
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
        


        private void ClearFields()
        {
            try
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
