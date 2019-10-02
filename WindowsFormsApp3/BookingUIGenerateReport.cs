using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp3
{
    public partial class BookingUIGenerateReport : Form
    {
        ReportDocument rdocument = new ReportDocument();
        public BookingUIGenerateReport()
        {
            InitializeComponent();
        }

        private void BookingUIGenerateReport_Load(object sender, EventArgs e)
        {
          
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnIdSrch_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
            string query = "SELECT * FROM Bookings where BookingID = '"+ txtBookingIdSrch.Text.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,cnn);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet, "Bookings");

            String path = Environment.CurrentDirectory;
            rdocument.Load( path+ "//BookingsReport.rpt"); // " C:\Users\Supun Randima\Desktop\Final ITP With Github\WindowsFormsApp3\WindowsFormsApp3\BookingsReport.rpt ");
            rdocument.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = rdocument;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
