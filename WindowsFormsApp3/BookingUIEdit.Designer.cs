namespace WindowsFormsApp3
{
    partial class BookingUIEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUIEdit));
            this.lblID = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblCalledDateTime = new System.Windows.Forms.Label();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.txtCallerTpNo = new System.Windows.Forms.TextBox();
            this.dateCaller = new System.Windows.Forms.DateTimePicker();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.groupBoxCallerDetails = new System.Windows.Forms.GroupBox();
            this.lblWorkingHrs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.groupBoxBookingPeriod = new System.Windows.Forms.GroupBox();
            this.btnCheckVehicles = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNoOfBackhoes = new System.Windows.Forms.Label();
            this.lblBackhoeType = new System.Windows.Forms.Label();
            this.lblRatings = new System.Windows.Forms.Label();
            this.txtRatings1 = new System.Windows.Forms.TextBox();
            this.txtRatings2 = new System.Windows.Forms.TextBox();
            this.txtRatings3 = new System.Windows.Forms.TextBox();
            this.txtBackhoeT1 = new System.Windows.Forms.TextBox();
            this.txtBackhoeT2 = new System.Windows.Forms.TextBox();
            this.txtBackhoeT3 = new System.Windows.Forms.TextBox();
            this.txtNoOfbckhoes1 = new System.Windows.Forms.TextBox();
            this.txtNoOfbckhoes2 = new System.Windows.Forms.TextBox();
            this.groupBoxBackhoeDetails = new System.Windows.Forms.GroupBox();
            this.txtNoOfbckhoes3 = new System.Windows.Forms.TextBox();
            this.groupBoxCallerDetails.SuspendLayout();
            this.groupBoxBookingPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxBackhoeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(53, 52);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 20);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "Booking ID";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(629, 89);
            this.lblMobileNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(132, 20);
            this.lblMobileNo.TabIndex = 2;
            this.lblMobileNo.Text = "Mobile Number :";
            // 
            // lblCalledDateTime
            // 
            this.lblCalledDateTime.AutoSize = true;
            this.lblCalledDateTime.Location = new System.Drawing.Point(629, 46);
            this.lblCalledDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalledDateTime.Name = "lblCalledDateTime";
            this.lblCalledDateTime.Size = new System.Drawing.Size(121, 20);
            this.lblCalledDateTime.TabIndex = 5;
            this.lblCalledDateTime.Text = "Date And Time";
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Location = new System.Drawing.Point(25, 46);
            this.lblCallerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(68, 20);
            this.lblCallerName.TabIndex = 1;
            this.lblCallerName.Text = "Name : ";
            // 
            // txtCallerName
            // 
            this.txtCallerName.Location = new System.Drawing.Point(237, 38);
            this.txtCallerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(297, 26);
            this.txtCallerName.TabIndex = 6;
            // 
            // txtCallerTpNo
            // 
            this.txtCallerTpNo.Location = new System.Drawing.Point(816, 81);
            this.txtCallerTpNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallerTpNo.Name = "txtCallerTpNo";
            this.txtCallerTpNo.Size = new System.Drawing.Size(349, 26);
            this.txtCallerTpNo.TabIndex = 7;
            // 
            // dateCaller
            // 
            this.dateCaller.Location = new System.Drawing.Point(816, 38);
            this.dateCaller.Margin = new System.Windows.Forms.Padding(4);
            this.dateCaller.Name = "dateCaller";
            this.dateCaller.Size = new System.Drawing.Size(349, 26);
            this.dateCaller.TabIndex = 17;
            this.dateCaller.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(25, 89);
            this.lblNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(52, 20);
            this.lblNIC.TabIndex = 18;
            this.lblNIC.Text = "NIC : ";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(237, 81);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(297, 26);
            this.txtNIC.TabIndex = 19;
            // 
            // groupBoxCallerDetails
            // 
            this.groupBoxCallerDetails.Controls.Add(this.txtNIC);
            this.groupBoxCallerDetails.Controls.Add(this.lblNIC);
            this.groupBoxCallerDetails.Controls.Add(this.dateCaller);
            this.groupBoxCallerDetails.Controls.Add(this.txtCallerTpNo);
            this.groupBoxCallerDetails.Controls.Add(this.txtCallerName);
            this.groupBoxCallerDetails.Controls.Add(this.lblCallerName);
            this.groupBoxCallerDetails.Controls.Add(this.lblCalledDateTime);
            this.groupBoxCallerDetails.Controls.Add(this.lblMobileNo);
            this.groupBoxCallerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCallerDetails.Location = new System.Drawing.Point(55, 438);
            this.groupBoxCallerDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCallerDetails.Name = "groupBoxCallerDetails";
            this.groupBoxCallerDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCallerDetails.Size = new System.Drawing.Size(1320, 138);
            this.groupBoxCallerDetails.TabIndex = 28;
            this.groupBoxCallerDetails.TabStop = false;
            this.groupBoxCallerDetails.Text = "Caller Details";
            // 
            // lblWorkingHrs
            // 
            this.lblWorkingHrs.AutoSize = true;
            this.lblWorkingHrs.Location = new System.Drawing.Point(23, 166);
            this.lblWorkingHrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingHrs.Name = "lblWorkingHrs";
            this.lblWorkingHrs.Size = new System.Drawing.Size(187, 20);
            this.lblWorkingHrs.TabIndex = 9;
            this.lblWorkingHrs.Text = "Working Hours Per Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Booking End Date";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(25, 43);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(151, 20);
            this.lblBookingDate.TabIndex = 8;
            this.lblBookingDate.Text = "Booking Start Date";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(235, 37);
            this.dateStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(351, 26);
            this.dateStartDate.TabIndex = 14;
            // 
            // dateEndDate
            // 
            this.dateEndDate.Location = new System.Drawing.Point(236, 100);
            this.dateEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(349, 26);
            this.dateEndDate.TabIndex = 15;
            this.dateEndDate.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Location = new System.Drawing.Point(236, 159);
            this.txtWorkingHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(85, 26);
            this.txtWorkingHours.TabIndex = 16;
            // 
            // groupBoxBookingPeriod
            // 
            this.groupBoxBookingPeriod.Controls.Add(this.btnCheckVehicles);
            this.groupBoxBookingPeriod.Controls.Add(this.txtWorkingHours);
            this.groupBoxBookingPeriod.Controls.Add(this.dateEndDate);
            this.groupBoxBookingPeriod.Controls.Add(this.dateStartDate);
            this.groupBoxBookingPeriod.Controls.Add(this.lblBookingDate);
            this.groupBoxBookingPeriod.Controls.Add(this.label4);
            this.groupBoxBookingPeriod.Controls.Add(this.lblWorkingHrs);
            this.groupBoxBookingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBookingPeriod.Location = new System.Drawing.Point(55, 96);
            this.groupBoxBookingPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBookingPeriod.Name = "groupBoxBookingPeriod";
            this.groupBoxBookingPeriod.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBookingPeriod.Size = new System.Drawing.Size(597, 288);
            this.groupBoxBookingPeriod.TabIndex = 30;
            this.groupBoxBookingPeriod.TabStop = false;
            this.groupBoxBookingPeriod.Text = "Booking Period";
            // 
            // btnCheckVehicles
            // 
            this.btnCheckVehicles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnCheckVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckVehicles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckVehicles.Location = new System.Drawing.Point(135, 214);
            this.btnCheckVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckVehicles.Name = "btnCheckVehicles";
            this.btnCheckVehicles.Size = new System.Drawing.Size(264, 42);
            this.btnCheckVehicles.TabIndex = 40;
            this.btnCheckVehicles.Text = "Check Vehicles";
            this.btnCheckVehicles.UseVisualStyleBackColor = false;
            this.btnCheckVehicles.Click += new System.EventHandler(this.btnCheckVehicles_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(254)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(551, 608);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 62);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(841, 608);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(264, 62);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(76, 625);
            this.lblTotalCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(138, 25);
            this.lblTotalCharge.TabIndex = 34;
            this.lblTotalCharge.Text = "Total Charge";
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Location = new System.Drawing.Point(292, 628);
            this.txtTotalCharges.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.Size = new System.Drawing.Size(185, 22);
            this.txtTotalCharges.TabIndex = 35;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBookingID.Location = new System.Drawing.Point(0, 0);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.MaxLength = 223;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(296, 22);
            this.txtBookingID.TabIndex = 33;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(297, 0);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(27, 25);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 36;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBookingID);
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Location = new System.Drawing.Point(197, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 25);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCustomerID);
            this.panel2.Location = new System.Drawing.Point(937, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 25);
            this.panel2.TabIndex = 40;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerID.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.MaxLength = 223;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(324, 22);
            this.txtCustomerID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Customer NIC / Contract ID ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1135, 608);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 62);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNoOfBackhoes
            // 
            this.lblNoOfBackhoes.AutoSize = true;
            this.lblNoOfBackhoes.Location = new System.Drawing.Point(537, 44);
            this.lblNoOfBackhoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfBackhoes.Name = "lblNoOfBackhoes";
            this.lblNoOfBackhoes.Size = new System.Drawing.Size(132, 20);
            this.lblNoOfBackhoes.TabIndex = 11;
            this.lblNoOfBackhoes.Text = "No Of Backhoes";
            // 
            // lblBackhoeType
            // 
            this.lblBackhoeType.AutoSize = true;
            this.lblBackhoeType.Location = new System.Drawing.Point(8, 44);
            this.lblBackhoeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackhoeType.Name = "lblBackhoeType";
            this.lblBackhoeType.Size = new System.Drawing.Size(115, 20);
            this.lblBackhoeType.TabIndex = 7;
            this.lblBackhoeType.Text = "Backhoe Type";
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(359, 44);
            this.lblRatings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(151, 20);
            this.lblRatings.TabIndex = 21;
            this.lblRatings.Text = "Ratings (Per Hour)";
            // 
            // txtRatings1
            // 
            this.txtRatings1.Location = new System.Drawing.Point(383, 107);
            this.txtRatings1.Margin = new System.Windows.Forms.Padding(4);
            this.txtRatings1.Name = "txtRatings1";
            this.txtRatings1.Size = new System.Drawing.Size(115, 26);
            this.txtRatings1.TabIndex = 22;
            // 
            // txtRatings2
            // 
            this.txtRatings2.Location = new System.Drawing.Point(383, 159);
            this.txtRatings2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRatings2.Name = "txtRatings2";
            this.txtRatings2.Size = new System.Drawing.Size(115, 26);
            this.txtRatings2.TabIndex = 23;
            // 
            // txtRatings3
            // 
            this.txtRatings3.Location = new System.Drawing.Point(383, 214);
            this.txtRatings3.Margin = new System.Windows.Forms.Padding(4);
            this.txtRatings3.Name = "txtRatings3";
            this.txtRatings3.Size = new System.Drawing.Size(115, 26);
            this.txtRatings3.TabIndex = 24;
            // 
            // txtBackhoeT1
            // 
            this.txtBackhoeT1.Location = new System.Drawing.Point(12, 103);
            this.txtBackhoeT1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackhoeT1.Name = "txtBackhoeT1";
            this.txtBackhoeT1.Size = new System.Drawing.Size(223, 26);
            this.txtBackhoeT1.TabIndex = 25;
            // 
            // txtBackhoeT2
            // 
            this.txtBackhoeT2.Location = new System.Drawing.Point(12, 159);
            this.txtBackhoeT2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackhoeT2.Name = "txtBackhoeT2";
            this.txtBackhoeT2.Size = new System.Drawing.Size(223, 26);
            this.txtBackhoeT2.TabIndex = 26;
            this.txtBackhoeT2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBackhoeT3
            // 
            this.txtBackhoeT3.Location = new System.Drawing.Point(8, 214);
            this.txtBackhoeT3.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackhoeT3.Name = "txtBackhoeT3";
            this.txtBackhoeT3.Size = new System.Drawing.Size(223, 26);
            this.txtBackhoeT3.TabIndex = 27;
            this.txtBackhoeT3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNoOfbckhoes1
            // 
            this.txtNoOfbckhoes1.Location = new System.Drawing.Point(556, 107);
            this.txtNoOfbckhoes1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfbckhoes1.Name = "txtNoOfbckhoes1";
            this.txtNoOfbckhoes1.Size = new System.Drawing.Size(81, 26);
            this.txtNoOfbckhoes1.TabIndex = 28;
            // 
            // txtNoOfbckhoes2
            // 
            this.txtNoOfbckhoes2.Location = new System.Drawing.Point(556, 162);
            this.txtNoOfbckhoes2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfbckhoes2.Name = "txtNoOfbckhoes2";
            this.txtNoOfbckhoes2.Size = new System.Drawing.Size(81, 26);
            this.txtNoOfbckhoes2.TabIndex = 29;
            // 
            // groupBoxBackhoeDetails
            // 
            this.groupBoxBackhoeDetails.Controls.Add(this.txtNoOfbckhoes3);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtNoOfbckhoes2);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtNoOfbckhoes1);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtBackhoeT3);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtBackhoeT2);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtBackhoeT1);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtRatings3);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtRatings2);
            this.groupBoxBackhoeDetails.Controls.Add(this.txtRatings1);
            this.groupBoxBackhoeDetails.Controls.Add(this.lblRatings);
            this.groupBoxBackhoeDetails.Controls.Add(this.lblBackhoeType);
            this.groupBoxBackhoeDetails.Controls.Add(this.lblNoOfBackhoes);
            this.groupBoxBackhoeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBackhoeDetails.Location = new System.Drawing.Point(688, 96);
            this.groupBoxBackhoeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBackhoeDetails.Name = "groupBoxBackhoeDetails";
            this.groupBoxBackhoeDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBackhoeDetails.Size = new System.Drawing.Size(687, 288);
            this.groupBoxBackhoeDetails.TabIndex = 29;
            this.groupBoxBackhoeDetails.TabStop = false;
            this.groupBoxBackhoeDetails.Text = "Backhoe Details";
            // 
            // txtNoOfbckhoes3
            // 
            this.txtNoOfbckhoes3.Location = new System.Drawing.Point(556, 214);
            this.txtNoOfbckhoes3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfbckhoes3.Name = "txtNoOfbckhoes3";
            this.txtNoOfbckhoes3.Size = new System.Drawing.Size(81, 26);
            this.txtNoOfbckhoes3.TabIndex = 30;
            // 
            // BookingUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxBookingPeriod);
            this.Controls.Add(this.groupBoxBackhoeDetails);
            this.Controls.Add(this.groupBoxCallerDetails);
            this.Controls.Add(this.lblID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingUIEdit";
            this.Size = new System.Drawing.Size(1425, 716);
            this.Load += new System.EventHandler(this.BookingUIEdit_Load);
            this.groupBoxCallerDetails.ResumeLayout(false);
            this.groupBoxCallerDetails.PerformLayout();
            this.groupBoxBookingPeriod.ResumeLayout(false);
            this.groupBoxBookingPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxBackhoeDetails.ResumeLayout(false);
            this.groupBoxBackhoeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Label lblCalledDateTime;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.TextBox txtCallerTpNo;
        private System.Windows.Forms.DateTimePicker dateCaller;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.GroupBox groupBoxCallerDetails;
        private System.Windows.Forms.Label lblWorkingHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.GroupBox groupBoxBookingPeriod;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckVehicles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNoOfBackhoes;
        private System.Windows.Forms.Label lblBackhoeType;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.TextBox txtRatings1;
        private System.Windows.Forms.TextBox txtRatings2;
        private System.Windows.Forms.TextBox txtRatings3;
        private System.Windows.Forms.TextBox txtBackhoeT1;
        private System.Windows.Forms.TextBox txtBackhoeT2;
        private System.Windows.Forms.TextBox txtBackhoeT3;
        private System.Windows.Forms.TextBox txtNoOfbckhoes1;
        private System.Windows.Forms.TextBox txtNoOfbckhoes2;
        private System.Windows.Forms.GroupBox groupBoxBackhoeDetails;
        private System.Windows.Forms.TextBox txtNoOfbckhoes3;
    }
}
