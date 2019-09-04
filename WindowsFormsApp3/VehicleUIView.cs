﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VehicleUIView : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(VehicleUINew.name);
        public VehicleUIView()
        {
            InitializeComponent();
            sqlConnection.Open();
            String query = "Select * from Vehicles";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable datTable  = new DataTable();
            sqlAdapter.Fill(datTable);
            dgvView.DataSource = datTable;
            sqlConnection.Close();




        }

        private void VehicleUIView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string searchID = txtSearch.Text;
                String cmd = "Select * from Vehicles where vehicleID = '" + searchID + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
                DataTable dataTable = new DataTable();
                dgvView.DataSource = dataTable;
                sqlConnection.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error Searching" + ex);
             }
             finally
             {
                 sqlConnection.Close();
             }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want Delete selected Row?",
                "Important",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
