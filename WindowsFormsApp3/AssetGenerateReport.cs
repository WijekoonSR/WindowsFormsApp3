using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AssetGenerateReport : Form
    {
        ReportDocument report = new ReportDocument();
        SqlConnection con = new SqlConnection( @"Data Source = (localDB)\Backhoe_DB; Initial Catalog = Backhoe; Integrated Security = True");
        public AssetGenerateReport()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSrchID_Click(object sender, EventArgs e)
        {
            con.Open();
            //get db values to sqldata adapter
            SqlDataAdapter sda = new SqlDataAdapter("select * from Assets_Maintenance where AssetsMaintenanceID = '"+txtSearchId.Text.ToString()+"'",con); 
            DataSet ds = new DataSet();
            sda.Fill(ds,"Assets_Maintenance");
            con.Close();

            //load current path of executable report
            report.Load(Environment.CurrentDirectory + "//AssetsMaintenanceGenerateReport.rpt");
            report.SetDataSource(ds);

            AssetsMaintenanceGenerateReport1.SetDataSource(report);
        }

    }
}
