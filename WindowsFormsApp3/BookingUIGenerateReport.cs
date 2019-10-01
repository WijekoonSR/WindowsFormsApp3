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
        String sql;
        ReportDocument rdocument = new ReportDocument();
        public BookingUIGenerateReport()
        {
            InitializeComponent();
        }

        private void BookingUIGenerateReport_Load(object sender, EventArgs e)
        {
            /*
            SqlConnection cnn = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
            String query = "select * from Bookings";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,sqlConnection);
            DataSet dataSet = new System.Data.DataSet();
            sqlDataAdapter.Fill(dataSet);
            BookingsReport1.SetDataSource(dataSet);*/

           /* SqlConnection cnn = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
            cnn.Open();
            sql = "SELECT * FROM Bookings group by ";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DatabaseDataSet ds = new DatabaseDataSet();// database name from imported values when creating report **left to right**
            dscmd.Fill(ds);
            MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
            cnn.Close();

            BookingsReport objRpt = new BookingsReport();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();*/
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
    }
}
