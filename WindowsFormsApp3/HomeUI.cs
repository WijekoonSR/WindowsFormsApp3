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
//using System.Threading;

namespace WindowsFormsApp3
{
    public partial class HomeUI : Form
    {
       
        Timer timer1 = new Timer();
        private String position;
        static String name = @"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True";
        //get sring db connection
        private SqlConnection sqlConnection = new SqlConnection(name);
        public HomeUI()
        {
            InitializeComponent();
            

            this.Location = new Point(0,0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            bookingUI1.BringToFront();
            
            // Creating Timer when loading form
            this.lblTime.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;


            //For developing
            //position = "Administration";
            accessLevels();

            if (position == "Administration" || CurrentUser.getUId() == "admin") { }
            else if (position.Trim() == "Assets Maintenace Manager")
            {
                assetsUI1.BringToFront();
                BookingsButton.Hide();
                CustomerButton.Hide();
                EmployeeButtton.Hide();
                VehicleButton.Hide();
                PayrollButton.Hide();
                LeasingButton.Hide();
            }
            else if (position.Trim() == "Employee Manager")
            {
                employeeUI1.BringToFront();
                assetsUI1.BringToFront();
                BookingsButton.Hide();
                CustomerButton.Hide();
                VehicleButton.Hide();
                PayrollButton.Hide();
                AssetsButton.Hide();
                LeasingButton.Hide();

            }
            else if (position.Trim() == "Vehicle Manager")
            {
                vehicleUI1.BringToFront();
                assetsUI1.BringToFront();
                BookingsButton.Hide();
                CustomerButton.Hide();
                EmployeeButtton.Hide();
                PayrollButton.Hide();
                AssetsButton.Hide();
                LeasingButton.Hide();

            }
            else if (position.Trim() == "Customer Manager")
            {
                assetsUI1.BringToFront();
                BookingsButton.Hide();
                EmployeeButtton.Hide();
                VehicleButton.Hide();
                PayrollButton.Hide();
                AssetsButton.Hide();
                customerUI1.BringToFront();
                LeasingButton.Hide();

            }
            else if (position.Trim() == "Bookings Manager")
            {
                bookingUI1.BringToFront();
                assetsUI1.BringToFront();
                CustomerButton.Hide();
                EmployeeButtton.Hide();
                VehicleButton.Hide();
                PayrollButton.Hide();
                AssetsButton.Hide();
                LeasingButton.Hide();

            }
            else if (position.Trim() == "Payroll Manager")
            {
                assetsUI1.BringToFront();
                BookingsButton.Hide();
                CustomerButton.Hide();
                EmployeeButtton.Hide();
                VehicleButton.Hide();
                AssetsButton.Hide();
                payrollUI1.BringToFront();
                LeasingButton.Hide();

            }
            else if (position.Trim() == "Vehicle Leasing Manager")
            {
                vehicleLeasingUI1.BringToFront();
                BookingsButton.Hide();
                CustomerButton.Hide();
                EmployeeButtton.Hide();
                VehicleButton.Hide();
                PayrollButton.Hide();
                AssetsButton.Hide();
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void accessLevels() {
            string Eid = CurrentUser.getEId();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Employee where EmployeeID = @eid", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@eid", Eid);
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            while (sdr.Read()) {
                position = sdr["JobTitle"].ToString();
            }
            sqlConnection.Close();
        }
        // Sliding Panels
        private void BookingsButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = BookingsButton.Height;
            SlidePanel.Top = BookingsButton.Top;
            bookingUI1.BringToFront();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = CustomerButton.Height;
            SlidePanel.Top = CustomerButton.Top;
            customerUI1.BringToFront();
        }

        private void EmployeeButtton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = EmployeeButtton.Height;
            SlidePanel.Top = EmployeeButtton.Top;
            employeeUI1.BringToFront();
        }

        private void VehicleButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = VehicleButton.Height;
            SlidePanel.Top = VehicleButton.Top;
            vehicleUI1.BringToFront();
        }

        private void PayrollButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = PayrollButton.Height;
            SlidePanel.Top = PayrollButton.Top; 
            payrollUI1.BringToFront();
        }

        private void BankLoansButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = LeasingButton.Height;
            SlidePanel.Top = LeasingButton.Top;
            vehicleLeasingUI1.BringToFront();
        }

        private void AssetsButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = AssetsButton.Height;
            SlidePanel.Top= AssetsButton.Top;
            assetsUI1.BringToFront();
        }


        // Icons in Top Right

        private void UserIcon_Click(object sender, EventArgs e)
        {
            userProfile1.Show();
            userProfile1.BringToFront();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //hide user UI
            userProfile1.Hide();
            //message box
            MessageBox.Show(      "            Developed By :  Wijekoon W.M.S.R " +
            Environment.NewLine + "                            Weerasooriya W.M.C.B." +
            Environment.NewLine + "                            Gunarathna K.A.G.I.P.T." +
            Environment.NewLine + "                            H. Sashini Madushi Pinto" +
            Environment.NewLine + "                            Gunawardhane G.H.N.M." +
            Environment.NewLine + "                            Amarasinghe R.M.G.H" +
            Environment.NewLine + "                            Weerasundara D.A.", " --- Created By ---",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void pictureBox8_Click_2(object sender, EventArgs e)
        {
            userProfile1.Hide();
            DialogResult DR =  MessageBox.Show("Exit Application ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (DR == DialogResult.OK) Application.Exit();
        }


        private void vehicleUI1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void userProfile1_Load(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void minimizedIcon_Click(object sender, EventArgs e)
        {
            userProfile1.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizedIcon_Click(object sender, EventArgs e)
        {
            userProfile1.Hide();
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTtime_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vehicleLeasingUI1_Load(object sender, EventArgs e)
        {

        }
    }
}
