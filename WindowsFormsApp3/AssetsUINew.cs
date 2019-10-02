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
    public partial class AssetsUINew : UserControl
    {
       
        public static String server = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(server);
        String spareParts, date, issuedDate, shopName, address, email, ownerName, AssetsMaintenanceID, invoiceNumber, contactNumber, OwnerContact;
        int quantity;

        string assetsID;
        Bitmap AttachmentNew;
        public AssetsUINew()
        {
            try
            {
                InitializeComponent();
                txtAssetsID.Text= GetID();
            }
            catch (Exception e)
            {
                MessageBox.Show( e.Message, "AssetsUI1 ");
            }
 

        }


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

        


        public static bool MatchStringFromRegex(string str, string regexstr)
        {
            str = str.Trim();
            System.Text.RegularExpressions.Regex pattern = new System.Text.RegularExpressions.Regex(regexstr);
            return pattern.IsMatch(str);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }
        

        

        private void txtShopName_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    picBoxAttachNew.Image = Image.FromFile(ofd.FileName);
                }
            }   }

        private void picBoxAttachNew_Click(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Attachments";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           // try
           // {
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

                else if (IsNumber(txtQuantity.Text.ToString()) == false)
                {
                    MessageBox.Show("Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else if (picBoxAttachNew.Image.Size.IsEmpty)
                {
                    MessageBox.Show("Please Attach an Image of Invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picBoxAttachNew.Focus();
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
                else if (IsNumber(txtContactNo.Text.ToString()) == false)
                {
                    MessageBox.Show("Invalid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtEmail.Focus();
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
                    AssetsMaintenanceID = txtAssetsID.Text.ToString();
                    spareParts = txtSpareParts.Text.ToString();
                    quantity = int.Parse(txtQuantity.Text);
                    price = float.Parse(txtPrice.Text);
                    date = dateNew.Value.ToString("yyyy/MM/dd");
                    invoiceNumber = (txtInvoiceNumber.Text);
                    issuedDate = dateIssued.Value.ToString("yyyy/MM/dd");
                    shopName = txtShopName.Text.ToString();
                    address = txtAddress.Text.ToString();
                    contactNumber = txtContactNo.Text;
                    email = txtEmail.Text.ToString();
                    ownerName = txtOwnerName.Text.ToString();
                    OwnerContact = txtOwnContactNew.Text;

                    PictureBox picBoxAttachNew1 = picBoxAttachNew;
                    
                    String VehicleID = txtVehicleID.Text;
                   

                    String query = "insert into Assets_Maintenance(AssetsMaintenanceID,VehicleID,PurchasedSpareParts,Quantity,PurchaseDate,Price,AttachmentNew,InvoiceNumber,IssuedDate,ShopName,Address,ContactNumber,Email,OwnerName,OwnerContact)"+
                        "values(@AssetsMaintenanceID, @VehicleID, @PurchasedSpareParts, @Quantity, @PurchaseDate, @Price, @AttachmentNew, @InvoiceNumber, @IssuedDate, @ShopName, @Address, @ContactNumber, @Email, @OwnerName, @OwnerContact)";


                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@AssetsMaintenanceID",AssetsMaintenanceID);
                    sqlCommand.Parameters.AddWithValue("@VehicleID",VehicleID);
                    sqlCommand.Parameters.AddWithValue("@PurchasedSpareParts",spareParts);
                    sqlCommand.Parameters.AddWithValue("@Quantity",quantity);
                    sqlCommand.Parameters.AddWithValue("@PurchaseDate",issuedDate);
                    sqlCommand.Parameters.AddWithValue("@Price",price);
                    sqlCommand.Parameters.AddWithValue("@AttachmentNew",ConvertImageToBinary(picBoxAttachNew.Image));
                    sqlCommand.Parameters.AddWithValue("@InvoiceNumber",invoiceNumber);
                    sqlCommand.Parameters.AddWithValue("@IssuedDate",issuedDate);
                    sqlCommand.Parameters.AddWithValue("@ShopName",shopName);
                    sqlCommand.Parameters.AddWithValue("@Address",address);
                    sqlCommand.Parameters.AddWithValue("@ContactNumber",contactNumber);
                    sqlCommand.Parameters.AddWithValue("@Email",email);
                    sqlCommand.Parameters.AddWithValue("@OwnerName",ownerName);
                    sqlCommand.Parameters.AddWithValue("@OwnerContact",OwnerContact);

                    int m1 = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (m1 == 0)
                    {
                        MessageBox.Show("Not Updated");
                    }
                    else
                    {
                    setIdSql();
                    DialogResult DR = MessageBox.Show("Successfully Entered","Success",MessageBoxButtons.OK);
                        ClearFields();
                        if (DR == DialogResult.OK)
                        {
                            txtAssetsID.Text= GetID();
                        }
                    }

                }
            //}
          /*  catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AssetsUI3 ");
            }
            finally
            {
                sqlConnection.Close();
            }
        */

        }

    

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
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
                txtVehicleID.Clear();
                picBoxAttachNew.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void setIdSql()
        {
            //set when user tries to insert values to db ** confirmed
            sqlConnection.Open();
            SqlCommand com = new SqlCommand("select next VALUE FOR  Id_Assets", sqlConnection);
            com.ExecuteNonQuery();

            sqlConnection.Close();
        }
        private string GetID()
        {
            try
            {
                string ID = null;
                sqlConnection.Open();
                String queryCurrentID = "SELECT current_value FROM sys.sequences WHERE name = 'Id_Assets' ;";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                return "AM" + (int.Parse(ID));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Assets:getID ");
                return "Error";

            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
