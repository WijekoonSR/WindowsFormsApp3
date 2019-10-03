using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PayrollUICalculater : Form
    {
        double result = 0;
        String operation = "";
        bool isOperation = false;
        public PayrollUICalculater()
        {
            InitializeComponent();
        }

        private void buton_click(object sender, EventArgs e)
        {
            if(txtCalArea.Text == "0" || isOperation)
            {
                txtCalArea.Clear();
            }
            isOperation = false;
            Button button = (Button)sender;
            txtCalArea.Text = txtCalArea.Text+button.Text;
        }

        private void operater_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operation = button.Text;

                lblOperation.Text = result + "" + operation;
                isOperation = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(txtCalArea.Text);
                lblOperation.Text = result + "" + operation;
                isOperation = true;
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCalArea.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalArea.Text = "0";
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtCalArea.Text = (result + double.Parse(txtCalArea.Text)).ToString();
                    break;

                case "-":
                    txtCalArea.Text = (result - double.Parse(txtCalArea.Text)).ToString();
                    break;

                case "*":
                    txtCalArea.Text = (result * double.Parse(txtCalArea.Text)).ToString();
                    break;

                case "/":
                    txtCalArea.Text = (result / double.Parse(txtCalArea.Text)).ToString();
                    break;

                default:
                    break;

            }
            result = double.Parse(txtCalArea.Text);
            lblOperation.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

