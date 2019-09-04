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
using PagedList;

namespace WindowsFormsApp3
{
    public partial class BookingUIView : UserControl
    {
        DataTable dtbl;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public BookingUIView()
        {
            InitializeComponent();
            setDatagridView();

        }


        private void BookingUIView_Load(object sender, EventArgs e)
        {
            setDatagridView();

        }
        private void dgvBookingsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvBookingsView.Height;
            dgvBookingsView.Height = dgvBookingsView.RowCount * dgvBookingsView.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvBookingsView.Width, dgvBookingsView.Height);
            dgvBookingsView.DrawToBitmap(bmp, new Rectangle(0, 0, dgvBookingsView.Width, dgvBookingsView.Height));
            dgvBookingsView.Height = height;
            printPreviewDialog1.ShowDialog();
        }

 

        void setDatagridView(){
            String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name))
            {
                string query = "select * from Bookings";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        private void bookingsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name))
            {
                int id = int.Parse(txtBookingID.Text.ToString());
                string query = "select * from Bookings where BookingID = '"+id+"'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setDatagridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name))
            {
                string startDate = dtpStartDate.Value.ToString("dd/MM/yyyy");
                string endDate = dtpEndDate.Value.ToString("dd/MM/yyyy");
                string query = "select * from Bookings where StartDate  = '" + startDate + "'and EndDate = '" + endDate + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
/*String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name))
            {
                string query = "select * from Bookings where StartDate  = '" + startDate + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;
            }
            */
        }
    }
}
