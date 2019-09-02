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

        private SqlCommand sqlCommand, sqlComTem;

        public static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
         //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        
        public static string startDate, endDate;
        public static int hours;
        public static String customerID;

        protected int NoOfExcavator, NoBackhoeLoaders, NoBulldozers, NoSkidSteerLoaders, NoMotorGraders, NoTrenchers = 0;

        protected String Type1, Type2, Type3 = null;
        float TotalCharge;
        string BookingID;
        public BookingUINew()
        {
            try
            {
                InitializeComponent();
      
                    //open connection
                    sqlConnection.Open();
                    String Query = "select VehicleType From Vehicles GROUP BY VehicleType";
                    //sql command
                    sqlCommand = new SqlCommand(Query,sqlConnection);

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
                sqlConnection.Close();
                sqlConnection.Open();
                String queryCurrentID = "select IDENT_CURRENT('Bookings') + 1";
                SqlCommand command = new SqlCommand(queryCurrentID, sqlConnection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read()) {
                    BookingID = dataReader[0].ToString();
                }

                txtBookingID.Text = "B" + BookingID;
                    //initialized backhoe types and count
                        dropDownNoOfBackhoes1.Text = "0";
                        dropDownNoOfBackhoes2.Text = "0";
                        dropDownNoOfBackhoes3.Text = "0";

                        txtRatings1.Text = "0";
                        txtRatings2.Text = "0";
                        txtRatings3.Text = "0";

                /*                  String[] arr = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                                  foreach (String S in arr)
                                  {
                                  }
                                  //end add items to drop down
              */
                //closing db connection
                sqlConnection.Close();
                
               
            }
            catch (Exception e) {
                MessageBox.Show("Error", e.Message , MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BookingUINew_Load(object sender, EventArgs e)
        {

        }

        private void dropDownBackhoeTypes1_onItemSelected(object sender, EventArgs e)
        {
          Type1 = dropDownBackhoeTypes1.selectedValue;
          int count = 0;

            if (Type1 == "Excavator") count = NoOfExcavator;
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

        private void dropDownNoOfBackhoes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTotalCharge_Click(object sender, EventArgs e)
        {
            float BackhoeType1Ratings = float.Parse(txtRatings1.Text);
            float BackhoeType2Ratings = float.Parse(txtRatings2.Text);
            float BackhoeType3Ratings = float.Parse(txtRatings3.Text);
            float count1 = float.Parse(dropDownNoOfBackhoes1.Text);
            float count2 = float.Parse(dropDownNoOfBackhoes2.Text);
            float count3 = float.Parse(dropDownNoOfBackhoes3.Text);

            TotalCharge = (BackhoeType1Ratings * count1) + (BackhoeType2Ratings * count2) + (BackhoeType3Ratings * count3);
            txtTotalCharges.Text = TotalCharge.ToString();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            customerID = txtCustomerID.Text.ToString();
            BookingUICheckCxValidity bookingUICheckCxValidity = new BookingUICheckCxValidity();
            bookingUICheckCxValidity.Show();
        }

        private void dropDownBackhoeTypes2_onItemSelected(object sender, EventArgs e)
        {
            Type1 = dropDownBackhoeTypes1.selectedValue;
            int count = 0;

            if (Type1 == "Excavator") count = NoOfExcavator;
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

        private void lblCallerName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //get values from inputed date range
            startDate = dateStartDate.Value.ToString("yyyy/MM/dd");
            endDate = dateEndDate.Value.ToString("yyyy/MM/dd");

            //prompt BookingUINewCheckVehicles UI
            BookingUINewCheckVehicles bookingUINewCheckVehicles = new BookingUINewCheckVehicles();
            bookingUINewCheckVehicles.Show();
            string queryTemp = "exec procAvailableVehicles '"+startDate+"','"+endDate+"'";
            sqlComTem = new SqlCommand(queryTemp, sqlConnection);
            sqlComTem.ExecuteNonQuery();

            string query = "SELECT * FROM ##tblAvailableVehicles";
            sqlCommand = new SqlCommand(query,sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read()) {
                if (reader["Type"].ToString() == "Excavator") {
                    NoOfExcavator = Convert.ToInt32(reader["count"]);
                }
              else if (reader["Type"].ToString() == "Backhoe Loader")
                {
                    NoBackhoeLoaders = Convert.ToInt32(reader["count"].ToString());
                }
                else if (reader["Type"].ToString() == "Bulldozer")
                {
                    NoBulldozers = Convert.ToInt32(reader["count"].ToString());
                }
                else if (reader["Type"].ToString() == "Skid Steer Loader")
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

            sqlConnection.Close();
            MessageBox.Show(NoOfExcavator.ToString());
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
             {
                 sqlConnection.Open();
                string StartDate = dateStartDate.Value.ToString("yyyy/MM/dd");
                string EndDate = dateEndDate.Value.ToString("yyyy/MM/dd");
                int WorkingHours = int.Parse(txtWorkingHours.Text);


                String BackhoeType1 = dropDownBackhoeTypes1.Text.ToString();

                MessageBox.Show(BackhoeType1);
                float BackhoeType1Ratings = float.Parse(txtRatings1.Text);
                int BackhoeType1Count = int.Parse(dropDownNoOfBackhoes1.Text);

                String BackhoeType2 = dropDownBackhoeTypes2.Text; ;
                float BackhoeType2Ratings = float.Parse(txtRatings2.Text);
                int BackhoeType2Count = int.Parse(dropDownNoOfBackhoes2.Text);

                String BackhoeType3 = dropDownBackhoeTypes3.Text; ;
                float BackhoeType3Ratings = float.Parse(txtRatings3.Text);
                int BackhoeType3Count = int.Parse(dropDownNoOfBackhoes3.Text);
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

                SqlCommand sqlCommandInserted = new SqlCommand("Insert into Bookings(StartDate,EndDate,WorkingHours,BackhoeType1,BackhoeType1Ratings,BackhoeType1Count,BackhoeType2,BackhoeType2Ratings,BackhoeType2Count,BackhoeType3,BackhoeType3Ratings,BackhoeType3Count,CallerName,CalledDate,CallerNic,CallerNumber,TotalCharge,CustomerID)  " +
                    "Values(@StartDate, @EndDate ,@WorkingHours, @BackhoeType1, @BackhoeType1Ratings, @BackhoeType1Count, @BackhoeType2, @BackhoeType2Ratings, @BackhoeType2Count, @BackhoeType3, @BackhoeType3Ratings, @BackhoeType3Count, @CallerName, @CalledDate, @CallerNic, @CallerNumber, @TotalCharge, @CustomerID )", sqlConnection);
                sqlCommandInserted.Parameters.AddWithValue("@startDate", StartDate);
                sqlCommandInserted.Parameters.AddWithValue("@EndDate", EndDate);
                sqlCommandInserted.Parameters.AddWithValue("@WorkingHours", WorkingHours);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1", BackhoeType1);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1Ratings", BackhoeType1Ratings);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType1Count", BackhoeType1Count);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2", BackhoeType2);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2Ratings", BackhoeType2Ratings);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType2Count", BackhoeType2Count);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3", BackhoeType3);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3Ratings", BackhoeType3Ratings);
                sqlCommandInserted.Parameters.AddWithValue("@BackhoeType3Count", BackhoeType3Count);
                sqlCommandInserted.Parameters.AddWithValue("@CallerName", CallerName);
                sqlCommandInserted.Parameters.AddWithValue("@CalledDate", CalledDate);
                sqlCommandInserted.Parameters.AddWithValue("@CallerNic", CallerNic);
                sqlCommandInserted.Parameters.AddWithValue("@CallerNumber", CallerNumber);
                sqlCommandInserted.Parameters.AddWithValue("@TotalCharge", TotalCharge);
                sqlCommandInserted.Parameters.AddWithValue("@CustomerID", CustomerID);

                sqlCommandInserted.ExecuteNonQuery();

                sqlConnection.Close();
                MessageBox.Show("Entered Succesfully !", "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             catch (Exception e1) {
                 MessageBox.Show(e1.Message);
             }
        }

        private void dropDownBackhoeTypes3_onItemSelected(object sender, EventArgs e)
        {
            Type1 = dropDownBackhoeTypes3.selectedValue;
            int count = 0;

            if (Type1 == "Excavator") count = NoOfExcavator;
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
