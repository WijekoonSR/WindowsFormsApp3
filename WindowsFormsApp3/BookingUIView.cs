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
    public partial class BookingUIView : UserControl
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public BookingUIView()
        {
            InitializeComponent();
            String name = BookingUINew.name;//vehicleleasinnew.
            using (sqlConnection = new SqlConnection(name)) {
                string query = "select * from Bookings";
                SqlDataAdapter SDA = new SqlDataAdapter(query,sqlConnection);
                DataTable dtbl = new DataTable();
                SDA.Fill(dtbl);

                dgvBookingsView.DataSource = dtbl;//datagrid vie name

            }
        }

        private void BookingUIView_Load(object sender, EventArgs e)
        {
            String name = BookingUINew.name;
            using (sqlConnection = new SqlConnection(name))
            {

            }
        }
        private void dgvBookingsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0,0,this.Size);
            printPreviewDialog1.ShowDialog();
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
    }
}
