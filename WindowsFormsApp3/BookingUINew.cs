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
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace WindowsFormsApp3
{
    public partial class BookingUINew : UserControl
    {
        //sqlcommands
        private SqlCommand sqlCommand, sqlComTem;
        //connection server string name
        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get string db connection
        private SqlConnection sqlConnection = new SqlConnection(name);

        public static string startDate, endDate;
        public static int hours;
        public static String customerID;

        int countdrop1 = 0, countdrop2 = 0, countdrop3 = 0; // To Check How many items selected from dropdown

        protected int NoOfExcavator, NoBackhoeLoaders, NoBulldozers, NoSkidSteerLoaders, NoMotorGraders, NoTrenchers = 0;


        protected String Type1 = "Excavators", Type2 = "Excavators", Type3 = "Excavators";
        float TotalCharge;
        public BookingUINew()
        {
            try
            {
                InitializeComponent();

                //open connection
                sqlConnection.Open();
                String Query = "select VehicleType From Vehicles GROUP BY VehicleType";
                //sql command
                sqlCommand = new SqlCommand(Query, sqlConnection);

                //Read data
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //add items to dropdownlist from db
                while (sqlDataReader.Read())
                {
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        //to convert int to string SDR.Getvalue(i).ToString()
                        dropDownBackhoeTypes1.AddItem(sqlDataReader.GetValue(i).ToString());
                        dropDownBackhoeTypes2.AddItem(sqlDataReader.GetValue(i).ToString());
                        dropDownBackhoeTypes3.AddItem(sqlDataReader.GetValue(i).ToString());
                    }
                }
                //closing db connection
                sqlConnection.Close();

                //get current booking ID to BookingID text field
                getBookingID();
                dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "BookingUI:BookingUINew ",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void getBookingID()
        {
            try
            {
                sqlConnection.Open();
                string BookingID = null;
                String queryCurrentID = "select IDENT_CURRENT('Bookings')";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    BookingID = dataReader[0].ToString();
                }
                sqlConnection.Close();
                sqlConnection.Open();

                SqlCommand chkExistsData = new SqlCommand("select * from Bookings where BookingID = 1", sqlConnection);
                SqlDataReader SDR = chkExistsData.ExecuteReader();
                if (SDR.HasRows) txtBookingID.Text = "B" + (int.Parse(BookingID) + 1).ToString();
                else txtBookingID.Text = "B1";
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "BookingUI:getBookingID ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void BookingUINew_Load(object sender, EventArgs e)
        {
            dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles

        }

        private void dropDownBackhoeTypes1_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                dropDownItemsRemove();
                Type1 = dropDownBackhoeTypes1.selectedValue;
                int count = 0;

                if (Type1 == "Excavators") count = NoOfExcavator;
                else if (Type1 == "Backhoe Loaders") count = NoBackhoeLoaders;
                else if (Type1 == "Bulldozers") count = NoBulldozers;
                else if (Type1 == "Skid Steer Loaders") count = NoSkidSteerLoaders;
                else if (Type1 == "Motor Grader") count = NoMotorGraders;
                else if (Type1 == "Trenchers") count = NoTrenchers;
                else count = 0;
                MessageBox.Show("Avaiable : " + count.ToString(), Type1);
                for (int j = 0; j <= count; j++)
                {
                    dropDownNoOfBackhoes1.Items.Add(j);
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:dropDownBackhoeTypes1_onItemSelected ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void dropDownBackhoeTypes2_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                dropDownItemsRemove();
                Type2 = dropDownBackhoeTypes2.selectedValue;
                int count = 0;

                if (Type2 == "Excavators") count = NoOfExcavator;
                else if (Type2 == "Backhoe Loaders") count = NoBackhoeLoaders;
                else if (Type2 == "Bulldozers") count = NoBulldozers;
                else if (Type2 == "Skid Steer Loaders") count = NoSkidSteerLoaders;
                else if (Type2 == "Motor Grader") count = NoMotorGraders;
                else if (Type2 == "Trenchers") count = NoTrenchers;
                else count = 0;

                MessageBox.Show("Available : " + count.ToString(), Type2);

                for (int j = 0; j <= count; j++)
                {
                    dropDownNoOfBackhoes2.Items.Add(j);
                }


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:dropDownBackhoeTypes2_onItemSelected ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void dropDownBackhoeTypes3_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                dropDownItemsRemove();
                int count = 0;
                Type3 = dropDownBackhoeTypes2.selectedValue;
                if (Type3 == "Excavators") count = NoOfExcavator;
                else if (Type3 == "Backhoe Loaders") count = NoBackhoeLoaders;
                else if (Type3 == "Bulldozers") count = NoBulldozers;
                else if (Type3 == "Skid Steer Loaders") count = NoSkidSteerLoaders;
                else if (Type3 == "Motor Graders") count = NoMotorGraders;
                else if (Type3 == "Trenchers") count = NoTrenchers;
                else count = 0;
                MessageBox.Show("Avaiable : " + count.ToString(), Type3);
                for (int j = 0; j <= count; j++)
                {
                    dropDownNoOfBackhoes3.Items.Add(j);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:dropDownBackhoeTypes3_onItemSelected ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do You want to clear all fields ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DR == DialogResult.OK) clearAllFields();

        }

        //
        private void dropDownNoOfBackhoes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            countdrop1 = int.Parse(dropDownNoOfBackhoes1.Text);
        }
        private void dropDownNoOfBackhoes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            countdrop2 = int.Parse(dropDownNoOfBackhoes2.Text);
        }
        private void dropDownNoOfBackhoes3_SelectedIndexChanged(object sender, EventArgs e)
        {
            countdrop3 = int.Parse(dropDownNoOfBackhoes3.Text);
        }

        private void btnTotalCharge_Click(object sender, EventArgs e)
        {
            try
            {
                float BackhoeType1Ratings = float.Parse(txtRatings1.Text.ToString());
                float BackhoeType2Ratings = float.Parse(txtRatings2.Text.ToString());
                float BackhoeType3Ratings = float.Parse(txtRatings3.Text.ToString());
                float count1 = float.Parse(dropDownNoOfBackhoes1.Text.ToString());
                float count2 = float.Parse(dropDownNoOfBackhoes2.Text.ToString());
                float count3 = float.Parse(dropDownNoOfBackhoes3.Text.ToString());

                TotalCharge = (BackhoeType1Ratings * count1) + (BackhoeType2Ratings * count2) + (BackhoeType3Ratings * count3);
                txtTotalCharges.Text = TotalCharge.ToString();
                dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:btnTotalCharge_Click ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            customerID = txtCustomerID.Text.ToString();
            BookingUICheckCxValidity bookingUICheckCxValidity = new BookingUICheckCxValidity();
            bookingUICheckCxValidity.Show();
        }


        private void dateStartDate_ValueChanged(object sender, EventArgs e)
        {
            dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles

        }

        private void btnCheckVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                dropDownItemsRemove();
                sqlConnection.Open();
                //get values from inputed date range
                startDate = dateStartDate.Value.ToString("yyyy/MM/dd");
                endDate = dateEndDate.Value.ToString("yyyy/MM/dd");

                //executed procAvailableVehicles in sql for getting avaible vehicles
                string queryTemp = "exec procAvailableVehicles '" + startDate + "','" + endDate + "'";
                sqlComTem = new SqlCommand(queryTemp, sqlConnection);
                sqlComTem.ExecuteNonQuery();

                //get all avaible vehicles
                string query = "SELECT * FROM ##tblAvailableVehicles";
                sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                //read data from query
                while (reader.Read())
                {
                    if (reader["Type"].ToString() == "Excavators")
                    {
                        NoOfExcavator = Convert.ToInt32(reader["count"]);
                    }
                    else if (reader["Type"].ToString() == "Backhoe Loaders")
                    {
                        NoBackhoeLoaders = Convert.ToInt32(reader["count"].ToString());
                    }
                    else if (reader["Type"].ToString() == "Bulldozers")
                    {
                        NoBulldozers = Convert.ToInt32(reader["count"].ToString());
                    }
                    else if (reader["Type"].ToString() == "Skid Steer Loaders")
                    {
                        NoSkidSteerLoaders = Convert.ToInt32(reader["count"].ToString());
                    }
                    else if (reader["Type"].ToString() == "Motor Grader")
                    {
                        NoMotorGraders = Convert.ToInt32(reader["count"].ToString());
                    }
                    else if (reader["Type"].ToString() == "Trenchers")
                    {
                        NoTrenchers = Convert.ToInt32(reader["count"].ToString());
                    }


                }

                //prompt BookingUINewCheckVehicles UI
                BookingUINewCheckVehicles bookingUINewCheckVehicles = new BookingUINewCheckVehicles();
                bookingUINewCheckVehicles.Show();

                sqlConnection.Close();

           }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:btnCheckVehicles_Click ");
            }
           finally
            {
                sqlConnection.Close();
            }
        }

        private void dateEndDate_ValueChanged(object sender, EventArgs e)
        {
            dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
           {
                Boolean i = validation();
                if (i == true)
                {
                    sqlConnection.Open();
                    string StartDate = dateStartDate.Value.ToString("yyyy/MM/dd");
                    string EndDate = dateEndDate.Value.ToString("yyyy/MM/dd");
                    int WorkingHours = int.Parse(txtWorkingHours.Text);

                    float BackhoeType1Ratings = float.Parse(txtRatings1.Text);
                    int BackhoeType1Count = int.Parse(dropDownNoOfBackhoes1.Text);

                    float BackhoeType2Ratings = float.Parse(txtRatings2.Text);
                    int BackhoeType2Count = int.Parse(dropDownNoOfBackhoes2.Text);

                    float BackhoeType3Ratings = float.Parse(txtRatings3.Text);
                    int BackhoeType3Count = int.Parse(dropDownNoOfBackhoes3.Text);

                    //address
                    String Address = txtAddress.Text;
                    //Caller Details
                    String CallerName = txtCallerName.Text;
                    String CalledDate = dateCaller.Value.ToString("yyyy/MM/dd");
                    String CallerNic = txtNIC.Text;
                    int CallerNumber = int.Parse(txtCallerTpNo.Text);
                    //Fee
                    float fee = TotalCharge;

                    //ID Only takes integers convert it into intger format
                    String ID = txtCustomerID.Text;
                    ID = Regex.Replace(ID, "[^0-9]", "");
                    int CustomerID = int.Parse(ID);

                    SqlCommand sqlCommandInserted = new SqlCommand("Insert into Bookings(StartDate,EndDate,WorkingHours,BackhoeType1,BackhoeType1Ratings,BackhoeType1Count,BackhoeType2,BackhoeType2Ratings,BackhoeType2Count,BackhoeType3,BackhoeType3Ratings,BackhoeType3Count,Address ,CallerName,CalledDate,CallerNic,CallerNumber,TotalCharge,CustomerID)  " +
                        "Values(@StartDate, @EndDate ,@WorkingHours, @BackhoeType1, @BackhoeType1Ratings, @BackhoeType1Count, @BackhoeType2, @BackhoeType2Ratings, @BackhoeType2Count, @BackhoeType3, @BackhoeType3Ratings, @BackhoeType3Count,@Address, @CallerName, @CalledDate, @CallerNic, @CallerNumber, @TotalCharge, @CustomerID )", sqlConnection);
                    sqlCommandInserted.Parameters.AddWithValue("@startDate", StartDate);
                    sqlCommandInserted.Parameters.AddWithValue("@EndDate", EndDate);
                    sqlCommandInserted.Parameters.AddWithValue("@WorkingHours", WorkingHours);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1", Type1);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1Ratings", BackhoeType1Ratings);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1Count", BackhoeType1Count);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2", Type2);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2Ratings", BackhoeType2Ratings);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2Count", BackhoeType2Count);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3", Type3);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3Ratings", BackhoeType3Ratings);
                    sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3Count", BackhoeType3Count);
                    sqlCommandInserted.Parameters.AddWithValue("@Address", Address);
                    sqlCommandInserted.Parameters.AddWithValue("@CallerName", CallerName);
                    sqlCommandInserted.Parameters.AddWithValue("@CalledDate", CalledDate);
                    sqlCommandInserted.Parameters.AddWithValue("@CallerNic", CallerNic);
                    sqlCommandInserted.Parameters.AddWithValue("@CallerNumber", CallerNumber);
                    sqlCommandInserted.Parameters.AddWithValue("@TotalCharge", TotalCharge);
                    sqlCommandInserted.Parameters.AddWithValue("@CustomerID", CustomerID);


                    //execute sql query
                    int valid = sqlCommandInserted.ExecuteNonQuery();

                    sqlConnection.Close();

                    //check  whether vehicles have been added to booking
                    if (BackhoeType1Count > 0) insertBooking_vehicle(BackhoeType1Count, Type1);
                    else if (BackhoeType2Count > 0) insertBooking_vehicle(BackhoeType2Count, Type2);
                    else if (BackhoeType3Count > 0) insertBooking_vehicle(BackhoeType3Count, Type3);

                    if (valid > 0)
                    {
                        MessageBox.Show("Entered Succesfully !", "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAllFields();
                        getBookingID();
                    }
                    else
                    {
                        MessageBox.Show("Data Inserted Failed", "BookingUI:btnSave_Click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dropTable(); // drop ##tblAvailableVehicles table whenever creating new checks on avaiable vehicles
                }
            }
            catch (Exception e1)
            {
               MessageBox.Show(e1.Message);
            }
            finally
            {
                
               sqlConnection.Close();
         }
     }

        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }


        private void insertBooking_vehicle(int count, string Type)
        {
            try
            {
                int[] arr1 = new int[count];
                for (int i = 0; i < count; i++)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(name))
                    {
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand("exec assignBooking_Vehicle '" + startDate + "', '" + endDate + "', '" + Type + "'", sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:insertBooking_vehicle ");
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        private void clearAllFields()
        {
            txtNIC.Clear();
            dateStartDate.Value = DateTime.Now;
            dateEndDate.Value = DateTime.Now;
            txtWorkingHours.Clear();
            txtRatings1.Clear();
            txtRatings2.Clear();
            txtRatings3.Clear();
            dropDownNoOfBackhoes1.Text = "0";
            dropDownNoOfBackhoes1.Text = "0";
            dropDownNoOfBackhoes1.Text = "0";
            txtCallerName.Clear();
            txtCallerTpNo.Clear();
            txtTotalCharges.Clear();
            txtNIC.Clear();
            dateCaller.Value = DateTime.Now;
            dropDownItemsRemove();
        }

        private void dropTable() {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("drop table if exists ##tblAvailableVehicles", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "BookingUI:dateEndDate_ValueChanged ");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void dropDownItemsRemove() {
            dropDownNoOfBackhoes1.Items.Clear();
            dropDownNoOfBackhoes2.Items.Clear();
            dropDownNoOfBackhoes3.Items.Clear();
        }

        private Boolean validation() {
            if (txtCustomerID.Text.ToString() == "") {
                MessageBox.Show("Insert Customer ID");
                txtCustomerID.Focus();
                return false;
            }

            else if (txtWorkingHours.Text.ToString() == "") {
                MessageBox.Show("Insert Working Hours");
                txtWorkingHours.Focus();
                return false;
            }
            else if (txtCallerName.Text.ToString() == "") {
                MessageBox.Show("Insert Caller Name");
                txtCallerName.Focus();
                return false;
            }
            else if (txtNIC.Text.ToString() == "") {
                MessageBox.Show("Insert NIC");
                txtNIC.Focus();
                return false;
            }
            else if (txtCallerTpNo.Text.ToString() == "") {
                MessageBox.Show("Insert Caller Telephone Number");
                txtCallerTpNo.Focus();
                return false;
            }

            else if (IsNumber(txtCallerTpNo.Text.ToString()) == false) {
                MessageBox.Show("Invalid Telephone Number");
                txtCallerTpNo.Focus();
                return false;
            }
            else if (dropDownBackhoeTypes1.selectedIndex.Equals(-1))
            {
                MessageBox.Show("Insert at least one vehicle type type to make a booking");
                dropDownBackhoeTypes1.Focus();
                return false;
            }
            else if (txtRatings1.Text.ToString() == "") {
                MessageBox.Show("Insert ratings");
                txtRatings1.Focus();
                return false;
            }

            else if (IsNumber(txtRatings1.Text.ToString()) == false) {
                MessageBox.Show("Invalid input check it..");
                txtRatings1.Focus();
                return false;
            }
            else if (dropDownNoOfBackhoes1.SelectedIndex.Equals(-1)) {

                MessageBox.Show("Insert at least one vehicle type type to make a booking");
                dropDownNoOfBackhoes1.Focus();
                return false;
            }
            else if (IsNumber(txtRatings2.Text.ToString()) == false)
            {
                MessageBox.Show("Invalid input check it..");
                txtRatings2.Focus();
                return false;
            }
            else if (IsNumber(txtRatings3.Text.ToString()) == false)
            {
                MessageBox.Show("Invalid input check it..");
                txtRatings3.Focus();
                return false;
            }


            return true;
        }
    }
}
    


/*   //Establish db connection
                DbConnection dbConnection = new DbConnection();
                //open db connection
                dbConnection.startConnection();

                //String query
                String query = "select BookingID From Bookings"; //set query

                //get sql connection
                sqlConnection = dbConnection.getDbConnection();

                //set sql command
                sqlCommand = dbSqlBooking.setSqlCommand(query, sqlConnection);

                //read data
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();*/
