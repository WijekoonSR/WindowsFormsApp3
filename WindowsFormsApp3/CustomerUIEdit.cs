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
    
    public partial class CustomerUIEdit : UserControl
    {
        string name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        public CustomerUIEdit()
        {
            InitializeComponent();
            SqlConnection sqlConnection = new SqlConnection(name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerUIEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerUIEditExtendPeriod customerUIEditExtendPeriod = new CustomerUIEditExtendPeriod();
            customerUIEditExtendPeriod.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(name);
                sqlConnection.Open();
                String deletesql = "delete from Customer WHERE CustomerID = '" + txtcutomerID + "'";
                SqlCommand com = new SqlCommand(deletesql, sqlConnection);
                com.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Delete Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error whiling delete" + ex);
            }
           
        }
    }
}
