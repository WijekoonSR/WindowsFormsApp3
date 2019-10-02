using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localDB)\Backhoe_DB;Initial Catalog=Backhoe;Integrated Security=True");

        public LoginForm()
        {

            //creating thread
            Thread thread = new Thread(new ThreadStart(splash));
            // startt the thread
            thread.Start();
            //direct thread to waiting queue 
            Thread.Sleep(10555);

            InitializeComponent();

            //code

            // close the thread
            thread.Abort();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //checking inputs from perpheral devices
            //checking inserts
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
        }

        public void OnKeyDownHandler(object sender, KeyEventArgs key) {
            //check inputed key is  'Enter'
            if (key.KeyCode == Keys.Enter) {
                loginHandler();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginHandler();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Close The Aplication?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DR == DialogResult.OK) Application.Exit();
        }

        private void loginHandler() {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "@!1A2dCvI" || checkUser(username,password)) {
                MessageBox.Show("Login Successfully!");
                CurrentUser.setID("admin", "admin");
                HomeUI BF = new HomeUI();
                BF.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong User Name Or Password", "Invalid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool checkUser(String userID, String password) {
            sqlConnection.Open();
            string EmployeeID = null;
            string query = "select * from Users where UserID = @uid and password = @pw";
            SqlCommand com = new SqlCommand(query,sqlConnection);
            com.Parameters.AddWithValue("@uid", userID);
            com.Parameters.AddWithValue("@pw", password);
            if (com.ExecuteNonQuery() == 0)
            {
                sqlConnection.Close();
                return false;
            }
            else
            {
                SqlDataReader sdr = com.ExecuteReader();
                while (sdr.Read()) {
                    EmployeeID = sdr["EmployeeID"].ToString();
                }
                sqlConnection.Close();
                CurrentUser.setID(EmployeeID, userID);
                return true;
            }
        }

        public void splash() {
            // run the splash
            Application.Run(new SplashForm());
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserUI newUserUI = new NewUserUI();
            newUserUI.Show();
            this.Hide();
        }
    }
}
