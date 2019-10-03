using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class VehicleUIReport : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");
        ReportDocument report = new ReportDocument();
        public VehicleUIReport()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSrchID_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Vehicles where  VehicleID = '"+ txtID.Text.ToString()+"'",sql);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Vehicles");
            report.Load(Environment.CurrentDirectory + "//VehicleDetailsReport.rpt");
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = report;
            sql.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
