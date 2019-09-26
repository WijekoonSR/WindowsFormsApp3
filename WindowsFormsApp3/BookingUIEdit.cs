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
    public partial class BookingUIEdit : UserControl
    {
        protected int NoOfExcavator, NoBackhoeLoaders, NoBulldozers, NoSkidSteerLoaders, NoMotorGraders, NoTrenchers = 0;
        string searchID;
        SqlConnection sql = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
        string StartDate, EndDate, WorkingHours, BackhoeType1, BackhoeType1Ratings, BackhoeType1Count, BackhoeType2, BackhoeType2Ratings, BackhoeType2Count, BackhoeType3, BackhoeType3Ratings, BackhoeType3Count, CallerName, CalledDate, CallerNic, CallerNumber, TotalCharge, CustomerID;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to delete data ?", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            if (DR == DialogResult.OK)
            {
                sql.Open();
                string id = txtBookingID.Text.ToString();
                SqlCommand command = new SqlCommand("delete from Booking_Vehicle where BookingID = '" + id + "'",sql);
                command.ExecuteNonQuery();
                sql.Close();
                clearAllFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnCheckVehicles_Click(object sender, EventArgs e)
        {
            sql.Open();
            //get values from inputed date range
            StartDate = dateStartDate.Value.ToString("yyyy/MM/dd");
            EndDate = dateEndDate.Value.ToString("yyyy/MM/dd");

            //executed procAvailableVehicles in sql for getting avaible vehicles
            string queryTemp = "exec procAvailableVehicles '" + StartDate + "','" + EndDate + "'";
            SqlCommand  sqlComTem = new SqlCommand(queryTemp, sql);
            sqlComTem.ExecuteNonQuery();

            //get all avaible vehicles
            string query = "SELECT * FROM ##tblAvailableVehicles";
            SqlCommand sqlCommand = new SqlCommand(query, sql);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            //read data from query
            while (reader.Read())
            {
                if (reader["Type"].ToString() == "Excavator")
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

            sql.Close();
        }

        public BookingUIEdit()
        {
            InitializeComponent();
        }

        private void BookingUIEdit_Load(object sender, EventArgs e)
        {
            
            

         }

        private void picSearch_Click_1(object sender, EventArgs e)
        {
            sql.Open();
            searchID = txtBookingID.Text.ToString();
            string query = "select *  from Bookings where BookingID = '"+ searchID + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sql);
            SqlDataReader SDR = sqlCommand.ExecuteReader();
            while (SDR.Read()) {
                StartDate = SDR["StartDate"].ToString();
                EndDate = SDR["EndDate"].ToString();
                WorkingHours = SDR["WorkingHours"].ToString();
                BackhoeType1 = SDR["BackhoeType1"].ToString();
                BackhoeType1Ratings = SDR["BackhoeType1Ratings"].ToString();
                BackhoeType1Count = SDR["BackhoeType1Count"].ToString();
                BackhoeType2 = SDR["BackhoeType2"].ToString();
                BackhoeType2Ratings = SDR["BackhoeType2Ratings"].ToString();
                BackhoeType2Count = SDR["BackhoeType2Count"].ToString();
                BackhoeType3 = SDR["BackhoeType3"].ToString();
                BackhoeType3Ratings = SDR["BackhoeType3Ratings"].ToString();
                BackhoeType3Count = SDR["BackhoeType3Count"].ToString();
                CallerName = SDR["CallerName"].ToString();
                CalledDate = SDR["CalledDate"].ToString();
                CallerNic = SDR["CallerNic"].ToString();
                CallerNumber = SDR["CallerNumber"].ToString();
                TotalCharge = SDR["TotalCharge"].ToString();
                CustomerID = SDR["CustomerID"].ToString();
            }
            sql.Close();
            txtCallerTpNo.Text = CallerNumber;
            dateStartDate.Value =Convert.ToDateTime( StartDate);
            dateEndDate.Value = Convert.ToDateTime(EndDate);
            txtWorkingHours.Text = WorkingHours.ToString();
            txtWorkingHours.Text = WorkingHours.ToString();

            txtBackhoeT1.Text = BackhoeType1;
            txtRatings1.Text = BackhoeType1Ratings.ToString();
            txtNoOfbckhoes1.Text = BackhoeType1Count;

            txtBackhoeT2.Text = BackhoeType2;
            txtRatings2.Text = BackhoeType2Ratings.ToString();
            txtNoOfbckhoes2.Text = BackhoeType2Count;

            txtBackhoeT3.Text = BackhoeType3;
            txtRatings3.Text = BackhoeType3Ratings.ToString();
            txtNoOfbckhoes3.Text = BackhoeType3Count;


            txtCallerName.Text = CallerName.ToString();
            dateCaller.Value = Convert.ToDateTime(CalledDate);

            txtNIC.Text = CallerNic.ToString();
            txtCallerName.Text = CallerNumber.ToString();
            txtTotalCharges.Text = TotalCharge.ToString();
            txtCustomerID.Text = CustomerID.ToString();
            txtTotalCharges.Text = TotalCharge;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            sql.Open();

            string StartDate = dateStartDate.Value.ToString("yyyy/MM/dd");
            string EndDate = dateEndDate.Value.ToString("yyyy/MM/dd");
            int WorkingHours = int.Parse(txtWorkingHours.Text);

            float BackhoeType1Ratings = float.Parse(txtRatings1.Text);
            int BackhoeType1Count = int.Parse(txtNoOfbckhoes1.Text);

            float BackhoeType2Ratings = float.Parse(txtRatings2.Text);
            int BackhoeType2Count = int.Parse(txtNoOfbckhoes2.Text);

            float BackhoeType3Ratings = float.Parse(txtRatings3.Text);
            int BackhoeType3Count = int.Parse(txtNoOfbckhoes3.Text);
            //Caller Details
            String CallerName = txtCallerName.Text;
            String CalledDate = dateCaller.Value.ToString("yyyy/MM/dd");
            String CallerNic = txtNIC.Text;
            int CallerNumber = int.Parse(txtCallerTpNo.Text);
            //Fee
            float fee = float.Parse(txtTotalCharges.Text);
            

            string query = "update Bookings set  StartDate ='"+StartDate+ "', EndDate = '"+ EndDate + "',WorkingHours='"+WorkingHours+ "',BackhoeType1='"+BackhoeType1+ "', BackhoeType1Ratings ='"+ BackhoeType1Ratings+ "', BackhoeType1Count = '"+BackhoeType1Count+ "', BackhoeType2 ='"+BackhoeType2+ "',BackhoeType2Ratings = '"+BackhoeType2Ratings+ "',BackhoeType2Count ='"+BackhoeType2Count+ "',BackhoeType3= '"+BackhoeType3+ "',BackhoeType3Ratings ='"+BackhoeType3Ratings+ "',BackhoeType3Count =  '"+BackhoeType3Count+ "',CallerName ='"+CallerName+ "',CalledDate ='"+ CalledDate + "',CallerNic = '"+CallerNic+ "', CallerNumber ='"+CallerNumber+ "', TotalCharge = '"+fee+ "' where BookingID = '" + searchID+ "'";
            SqlCommand com = new SqlCommand(query,sql);
            int i = com.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Succesfully Updated");
            }
            else {
                MessageBox.Show("Not Updated");
            }
            sql.Close();
            clearAllFields();
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
            txtNoOfbckhoes1.Clear();
            txtNoOfbckhoes2.Clear();
            txtNoOfbckhoes3.Clear();
            txtCallerName.Clear();
            txtCallerTpNo.Clear();
            txtTotalCharges.Clear();
            txtNIC.Clear();
            dateCaller.Value = DateTime.Now;
            txtBackhoeT1.Clear();
            txtBackhoeT2.Clear();
            txtBackhoeT3.Clear();
            txtBookingID.Clear();
            
        }

        private Boolean validation()
        {
            if (txtCustomerID.Text.ToString() == "")
            {
                MessageBox.Show("Insert Customer ID");
                txtCustomerID.Focus();
                return false;
            }

            else if (txtWorkingHours.Text.ToString() == "")
            {
                MessageBox.Show("Insert Working Hours");
                txtWorkingHours.Focus();
                return false;
            }
            else if (txtCallerName.Text.ToString() == "")
            {
                MessageBox.Show("Insert Caller Name");
                txtCallerName.Focus();
                return false;
            }
            else if (txtNIC.Text.ToString() == "")
            {
                MessageBox.Show("Insert NIC");
                txtNIC.Focus();
                return false;
            }
            else if (txtCallerTpNo.Text.ToString() == "")
            {
                MessageBox.Show("Insert Caller Telephone Number");
                txtCallerTpNo.Focus();
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


            return true;
        }

        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }

    }
}
