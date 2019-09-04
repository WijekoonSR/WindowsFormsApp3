using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BookingUIEdit : UserControl
    {
        public BookingUIEdit()
        {
            InitializeComponent();
        }

        private void BookingUIEdit_Load(object sender, EventArgs e)
        {
            string query = "select StartDate, EndDate, WorkingHours, BackhoeType1, BackhoeType1Ratings, BackhoeType1Count, BackhoeType2, BackhoeType2Ratings, BackhoeType2Count, BackhoeType3, BackhoeType3Ratings, BackhoeType3Count, CallerName, CalledDate, CallerNic, CallerNumber, TotalCharge, CustomerID from Bookings";
            

         }

        private void picSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
