using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    partial class PayrollUIStaffNew
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollUIStaffNew));
            this.edtOtherAllowance = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.edtSalaryAdvance = new System.Windows.Forms.TextBox();
            this.edtETF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtEPF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtOT = new System.Windows.Forms.TextBox();
            this.edtBasicSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeValue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lberror1 = new System.Windows.Forms.Label();
            this.drpMonth = new Bunifu.Framework.UI.BunifuDropdown();
            this.label17 = new System.Windows.Forms.Label();
            this.drpOTRate = new Bunifu.Framework.UI.BunifuDropdown();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePayroll = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edtPossition = new System.Windows.Forms.TextBox();
            this.edtCity = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEPF = new System.Windows.Forms.Label();
            this.lblETF = new System.Windows.Forms.Label();
            this.lblSalaryAdvance = new System.Windows.Forms.Label();
            this.drpInsurance = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOtherAllowance = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.drpFoodAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpMedicalAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpHousingAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSetEmployeeID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtOtherAllowance
            // 
            this.edtOtherAllowance.Location = new System.Drawing.Point(159, 176);
            this.edtOtherAllowance.Name = "edtOtherAllowance";
            this.edtOtherAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtOtherAllowance.TabIndex = 16;
            this.edtOtherAllowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtOtherAllowance_KeyPress);
            this.edtOtherAllowance.Validated += new System.EventHandler(this.edtOtherAllowance_Validated);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Insurance";
            // 
            // edtSalaryAdvance
            // 
            this.edtSalaryAdvance.Location = new System.Drawing.Point(136, 25);
            this.edtSalaryAdvance.Name = "edtSalaryAdvance";
            this.edtSalaryAdvance.Size = new System.Drawing.Size(100, 20);
            this.edtSalaryAdvance.TabIndex = 4;
            this.edtSalaryAdvance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtSalaryAdvance_KeyDown);
            this.edtSalaryAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtSalaryAdvance_KeyPress);
            this.edtSalaryAdvance.Validated += new System.EventHandler(this.edtSalaryAdvance_Validated);
            // 
            // edtETF
            // 
            this.edtETF.Location = new System.Drawing.Point(136, 109);
            this.edtETF.Name = "edtETF";
            this.edtETF.Size = new System.Drawing.Size(100, 20);
            this.edtETF.TabIndex = 3;
            this.edtETF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtETF_KeyPress);
            this.edtETF.Validated += new System.EventHandler(this.edtETF_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salary Advance";
            // 
            // edtEPF
            // 
            this.edtEPF.Location = new System.Drawing.Point(136, 68);
            this.edtEPF.Name = "edtEPF";
            this.edtEPF.Size = new System.Drawing.Size(100, 20);
            this.edtEPF.TabIndex = 5;
            this.edtEPF.TextChanged += new System.EventHandler(this.edtEPF_TextChanged);
            this.edtEPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtEPF_KeyPress);
            this.edtEPF.Validated += new System.EventHandler(this.edtEPF_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "ETF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Other Allowance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Food Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Basic Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Over Time";
            // 
            // edtOT
            // 
            this.edtOT.Location = new System.Drawing.Point(161, 56);
            this.edtOT.Name = "edtOT";
            this.edtOT.Size = new System.Drawing.Size(100, 20);
            this.edtOT.TabIndex = 3;
            this.edtOT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtOT_KeyPress);
            this.edtOT.Validated += new System.EventHandler(this.edtOT_Validated);
            // 
            // edtBasicSalary
            // 
            this.edtBasicSalary.Location = new System.Drawing.Point(159, 32);
            this.edtBasicSalary.Name = "edtBasicSalary";
            this.edtBasicSalary.Size = new System.Drawing.Size(100, 20);
            this.edtBasicSalary.TabIndex = 4;
            this.edtBasicSalary.TextChanged += new System.EventHandler(this.edtBSalary_TextChanged);
            this.edtBasicSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtBasicSalary_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Housing Allowance";
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(876, 151);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(91, 23);
            this.btnChangeValue.TabIndex = 47;
            this.btnChangeValue.Text = "...";
            this.btnChangeValue.UseVisualStyleBackColor = true;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Medical Allowance";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lberror1);
            this.groupBox4.Controls.Add(this.drpMonth);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.drpOTRate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.edtOT);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(29, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(518, 87);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lberror1
            // 
            this.lberror1.AutoSize = true;
            this.lberror1.ForeColor = System.Drawing.Color.Red;
            this.lberror1.Location = new System.Drawing.Point(267, 59);
            this.lberror1.Name = "lberror1";
            this.lberror1.Size = new System.Drawing.Size(38, 13);
            this.lberror1.TabIndex = 22;
            this.lberror1.Text = "Invalid";
            // 
            // drpMonth
            // 
            this.drpMonth.BackColor = System.Drawing.Color.Transparent;
            this.drpMonth.ForeColor = System.Drawing.Color.White;
            this.drpMonth.Items = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Agu",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.drpMonth.Location = new System.Drawing.Point(163, 19);
            this.drpMonth.Name = "drpMonth";
            this.drpMonth.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpMonth.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpMonth.selectedIndex = -1;
            this.drpMonth.Size = new System.Drawing.Size(98, 20);
            this.drpMonth.TabIndex = 21;
            this.drpMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drpMonth_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Month";
            // 
            // drpOTRate
            // 
            this.drpOTRate.BackColor = System.Drawing.Color.Transparent;
            this.drpOTRate.ForeColor = System.Drawing.Color.White;
            this.drpOTRate.Items = new string[] {
        "1500",
        "1200"};
            this.drpOTRate.Location = new System.Drawing.Point(372, 56);
            this.drpOTRate.Name = "drpOTRate";
            this.drpOTRate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpOTRate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpOTRate.selectedIndex = -1;
            this.drpOTRate.Size = new System.Drawing.Size(98, 20);
            this.drpOTRate.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "OT Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "EPF";
            // 
            // dateTimePayroll
            // 
            this.dateTimePayroll.Location = new System.Drawing.Point(848, 27);
            this.dateTimePayroll.Name = "dateTimePayroll";
            this.dateTimePayroll.Size = new System.Drawing.Size(200, 20);
            this.dateTimePayroll.TabIndex = 46;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetEmployeeID);
            this.groupBox3.Controls.Add(this.edtPossition);
            this.groupBox3.Controls.Add(this.edtCity);
            this.groupBox3.Controls.Add(this.edtName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.edtEmployeeID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1066, 65);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            // 
            // edtPossition
            // 
            this.edtPossition.Location = new System.Drawing.Point(635, 19);
            this.edtPossition.Name = "edtPossition";
            this.edtPossition.Size = new System.Drawing.Size(100, 20);
            this.edtPossition.TabIndex = 29;
            // 
            // edtCity
            // 
            this.edtCity.Location = new System.Drawing.Point(903, 19);
            this.edtCity.Name = "edtCity";
            this.edtCity.Size = new System.Drawing.Size(100, 20);
            this.edtCity.TabIndex = 28;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(376, 19);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(100, 20);
            this.edtName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Possition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // edtEmployeeID
            // 
            this.edtEmployeeID.Location = new System.Drawing.Point(107, 19);
            this.edtEmployeeID.Name = "edtEmployeeID";
            this.edtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.edtEmployeeID.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEPF);
            this.groupBox2.Controls.Add(this.lblETF);
            this.groupBox2.Controls.Add(this.lblSalaryAdvance);
            this.groupBox2.Controls.Add(this.drpInsurance);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.edtSalaryAdvance);
            this.groupBox2.Controls.Add(this.edtETF);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edtEPF);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(529, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 208);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deductions";
            // 
            // lblEPF
            // 
            this.lblEPF.AutoSize = true;
            this.lblEPF.ForeColor = System.Drawing.Color.Red;
            this.lblEPF.Location = new System.Drawing.Point(260, 116);
            this.lblEPF.Name = "lblEPF";
            this.lblEPF.Size = new System.Drawing.Size(38, 13);
            this.lblEPF.TabIndex = 56;
            this.lblEPF.Text = "Invalid";
            // 
            // lblETF
            // 
            this.lblETF.AutoSize = true;
            this.lblETF.ForeColor = System.Drawing.Color.Red;
            this.lblETF.Location = new System.Drawing.Point(260, 71);
            this.lblETF.Name = "lblETF";
            this.lblETF.Size = new System.Drawing.Size(38, 13);
            this.lblETF.TabIndex = 55;
            this.lblETF.Text = "Invalid";
            // 
            // lblSalaryAdvance
            // 
            this.lblSalaryAdvance.AutoSize = true;
            this.lblSalaryAdvance.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryAdvance.Location = new System.Drawing.Point(260, 32);
            this.lblSalaryAdvance.Name = "lblSalaryAdvance";
            this.lblSalaryAdvance.Size = new System.Drawing.Size(38, 13);
            this.lblSalaryAdvance.TabIndex = 54;
            this.lblSalaryAdvance.Text = "Invalid";
            // 
            // drpInsurance
            // 
            this.drpInsurance.BackColor = System.Drawing.Color.Transparent;
            this.drpInsurance.ForeColor = System.Drawing.Color.White;
            this.drpInsurance.Items = new string[] {
        "750",
        "500"};
            this.drpInsurance.Location = new System.Drawing.Point(136, 157);
            this.drpInsurance.Name = "drpInsurance";
            this.drpInsurance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpInsurance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpInsurance.selectedIndex = -1;
            this.drpInsurance.Size = new System.Drawing.Size(98, 20);
            this.drpInsurance.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOtherAllowance);
            this.groupBox1.Controls.Add(this.lblBasicSalary);
            this.groupBox1.Controls.Add(this.drpFoodAllowance);
            this.groupBox1.Controls.Add(this.drpMedicalAllowance);
            this.groupBox1.Controls.Add(this.drpHousingAllowance);
            this.groupBox1.Controls.Add(this.edtOtherAllowance);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edtBasicSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 208);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Earnings";
            // 
            // lblOtherAllowance
            // 
            this.lblOtherAllowance.AutoSize = true;
            this.lblOtherAllowance.ForeColor = System.Drawing.Color.Red;
            this.lblOtherAllowance.Location = new System.Drawing.Point(282, 179);
            this.lblOtherAllowance.Name = "lblOtherAllowance";
            this.lblOtherAllowance.Size = new System.Drawing.Size(38, 13);
            this.lblOtherAllowance.TabIndex = 53;
            this.lblOtherAllowance.Text = "Invalid";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.ForeColor = System.Drawing.Color.Red;
            this.lblBasicSalary.Location = new System.Drawing.Point(285, 39);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(38, 13);
            this.lblBasicSalary.TabIndex = 50;
            this.lblBasicSalary.Text = "Invalid";
            // 
            // drpFoodAllowance
            // 
            this.drpFoodAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpFoodAllowance.ForeColor = System.Drawing.Color.White;
            this.drpFoodAllowance.Items = new string[] {
        "1500",
        "1750"};
            this.drpFoodAllowance.Location = new System.Drawing.Point(157, 141);
            this.drpFoodAllowance.Name = "drpFoodAllowance";
            this.drpFoodAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpFoodAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpFoodAllowance.selectedIndex = -1;
            this.drpFoodAllowance.Size = new System.Drawing.Size(98, 20);
            this.drpFoodAllowance.TabIndex = 25;
            // 
            // drpMedicalAllowance
            // 
            this.drpMedicalAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpMedicalAllowance.ForeColor = System.Drawing.Color.White;
            this.drpMedicalAllowance.Items = new string[] {
        "2000",
        "2200"};
            this.drpMedicalAllowance.Location = new System.Drawing.Point(157, 102);
            this.drpMedicalAllowance.Name = "drpMedicalAllowance";
            this.drpMedicalAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpMedicalAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpMedicalAllowance.selectedIndex = -1;
            this.drpMedicalAllowance.Size = new System.Drawing.Size(98, 20);
            this.drpMedicalAllowance.TabIndex = 24;
            // 
            // drpHousingAllowance
            // 
            this.drpHousingAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpHousingAllowance.ForeColor = System.Drawing.Color.White;
            this.drpHousingAllowance.Items = new string[] {
        "2000",
        "2500"};
            this.drpHousingAllowance.Location = new System.Drawing.Point(157, 68);
            this.drpHousingAllowance.Name = "drpHousingAllowance";
            this.drpHousingAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpHousingAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpHousingAllowance.selectedIndex = -1;
            this.drpHousingAllowance.Size = new System.Drawing.Size(98, 20);
            this.drpHousingAllowance.TabIndex = 23;
            this.drpHousingAllowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drpHousingAllowance_KeyPress);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "ADD";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(710, 509);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 42;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnSetEmployeeID
            // 
            this.btnSetEmployeeID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetEmployeeID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetEmployeeID.BorderRadius = 0;
            this.btnSetEmployeeID.ButtonText = "Set";
            this.btnSetEmployeeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetEmployeeID.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetEmployeeID.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetEmployeeID.Iconimage")));
            this.btnSetEmployeeID.Iconimage_right = null;
            this.btnSetEmployeeID.Iconimage_right_Selected = null;
            this.btnSetEmployeeID.Iconimage_Selected = null;
            this.btnSetEmployeeID.IconZoom = 90D;
            this.btnSetEmployeeID.IsTab = false;
            this.btnSetEmployeeID.Location = new System.Drawing.Point(213, 19);
            this.btnSetEmployeeID.Name = "btnSetEmployeeID";
            this.btnSetEmployeeID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetEmployeeID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSetEmployeeID.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetEmployeeID.selected = false;
            this.btnSetEmployeeID.Size = new System.Drawing.Size(85, 20);
            this.btnSetEmployeeID.TabIndex = 30;
            this.btnSetEmployeeID.Textcolor = System.Drawing.Color.White;
            this.btnSetEmployeeID.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetEmployeeID.Click += new System.EventHandler(this.btnSetEmployeeID_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(876, 189);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(91, 23);
            this.btnCal.TabIndex = 58;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // PayrollUIStaffNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePayroll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PayrollUIStaffNew";
            this.Size = new System.Drawing.Size(1069, 585);
            this.Load += new System.EventHandler(this.PayrollUIStaffNew_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void drpMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox edtOtherAllowance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox edtSalaryAdvance;
        private System.Windows.Forms.TextBox edtETF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtEPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtOT;
        private System.Windows.Forms.TextBox edtBasicSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeValue;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuDropdown drpOTRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePayroll;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetEmployeeID;
        private System.Windows.Forms.TextBox edtPossition;
        private System.Windows.Forms.TextBox edtCity;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuDropdown drpMonth;
        private Bunifu.Framework.UI.BunifuDropdown drpFoodAllowance;
        private Bunifu.Framework.UI.BunifuDropdown drpMedicalAllowance;
        private Bunifu.Framework.UI.BunifuDropdown drpHousingAllowance;
        private Bunifu.Framework.UI.BunifuDropdown drpInsurance;
        private System.Windows.Forms.Label lberror1;
        private System.Windows.Forms.Label lblEPF;
        private System.Windows.Forms.Label lblETF;
        private System.Windows.Forms.Label lblBasicSalary;
        private Label lblSalaryAdvance;
        private Label lblOtherAllowance;
        private Button btnCal;
    }
}
