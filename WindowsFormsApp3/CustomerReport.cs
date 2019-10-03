using CrystalDecisions.CrystalReports.Engine;
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
    public partial class CustomerReport : Form
    {
        ReportDocument reportDocumnet = new ReportDocument();
        static string name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        SqlConnection con = new SqlConnection(name);
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Customer where CustomerID = '"+ txtId.Text+"'",con);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet,"Customer");
            con.Close();
            reportDocumnet.Load(Environment.CurrentDirectory + "\\CustomerReportGenerator.rpt");
            reportDocumnet.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = reportDocumnet;

        }
    }
}
