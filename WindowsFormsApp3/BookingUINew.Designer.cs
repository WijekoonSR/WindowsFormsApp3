namespace WindowsFormsApp3
{
    partial class BookingUINew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUINew));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBookingPeriod = new System.Windows.Forms.GroupBox();
            this.btnCheckVehicles = new System.Windows.Forms.Button();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWorkingHrs = new System.Windows.Forms.Label();
            this.groupBoxbackhoeDetails = new System.Windows.Forms.GroupBox();
            this.txtRatings3 = new System.Windows.Forms.TextBox();
            this.txtRatings2 = new System.Windows.Forms.TextBox();
            this.txtRatings1 = new System.Windows.Forms.TextBox();
            this.lblRatings = new System.Windows.Forms.Label();
            this.dropDownNoOfBackhoes3 = new System.Windows.Forms.ComboBox();
            this.dropDownNoOfBackhoes2 = new System.Windows.Forms.ComboBox();
            this.dropDownNoOfBackhoes1 = new System.Windows.Forms.ComboBox();
            this.dropDownBackhoeTypes3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDownBackhoeTypes2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDownBackhoeTypes1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblBackhoeType = new System.Windows.Forms.Label();
            this.lblNoOfBackhoes = new System.Windows.Forms.Label();
            this.groupBoxCallerDetails = new System.Windows.Forms.GroupBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.dateCaller = new System.Windows.Forms.DateTimePicker();
            this.txtCallerTpNo = new System.Windows.Forms.TextBox();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.lblCalledDateTime = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnTotalCharge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpBookingPeriod.SuspendLayout();
            this.groupBoxbackhoeDetails.SuspendLayout();
            this.groupBoxCallerDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(788, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 50);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(254)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(573, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBookingPeriod
            // 
            this.grpBookingPeriod.Controls.Add(this.btnCheckVehicles);
            this.grpBookingPeriod.Controls.Add(this.txtWorkingHours);
            this.grpBookingPeriod.Controls.Add(this.dateEndDate);
            this.grpBookingPeriod.Controls.Add(this.dateStartDate);
            this.grpBookingPeriod.Controls.Add(this.lblBookingDate);
            this.grpBookingPeriod.Controls.Add(this.label4);
            this.grpBookingPeriod.Controls.Add(this.lblWorkingHrs);
            this.grpBookingPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingPeriod.Location = new System.Drawing.Point(41, 78);
            this.grpBookingPeriod.Name = "grpBookingPeriod";
            this.grpBookingPeriod.Size = new System.Drawing.Size(448, 192);
            this.grpBookingPeriod.TabIndex = 21;
            this.grpBookingPeriod.TabStop = false;
            this.grpBookingPeriod.Text = "Booking Period";
            // 
            // btnCheckVehicles
            // 
            this.btnCheckVehicles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnCheckVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckVehicles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckVehicles.Location = new System.Drawing.Point(100, 137);
            this.btnCheckVehicles.Name = "btnCheckVehicles";
            this.btnCheckVehicles.Size = new System.Drawing.Size(198, 34);
            this.btnCheckVehicles.TabIndex = 39;
            this.btnCheckVehicles.Text = "Check Vehicles";
            this.btnCheckVehicles.UseVisualStyleBackColor = false;
            this.btnCheckVehicles.Click += new System.EventHandler(this.btnCheckVehicles_Click);
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Location = new System.Drawing.Point(178, 101);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(65, 22);
            this.txtWorkingHours.TabIndex = 16;
            // 
            // dateEndDate
            // 
            this.dateEndDate.Location = new System.Drawing.Point(177, 68);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(263, 22);
            this.dateEndDate.TabIndex = 15;
            this.dateEndDate.Value = new System.DateTime(2019, 9, 2, 0, 0, 0, 0);
            this.dateEndDate.ValueChanged += new System.EventHandler(this.dateEndDate_ValueChanged);
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(176, 30);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(264, 22);
            this.dateStartDate.TabIndex = 14;
            this.dateStartDate.Value = new System.DateTime(2019, 9, 2, 12, 43, 59, 0);
            this.dateStartDate.ValueChanged += new System.EventHandler(this.dateStartDate_ValueChanged);
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(19, 35);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(120, 16);
            this.lblBookingDate.TabIndex = 8;
            this.lblBookingDate.Text = "Booking Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Booking End Date";
            // 
            // lblWorkingHrs
            // 
            this.lblWorkingHrs.AutoSize = true;
            this.lblWorkingHrs.Location = new System.Drawing.Point(16, 104);
            this.lblWorkingHrs.Name = "lblWorkingHrs";
            this.lblWorkingHrs.Size = new System.Drawing.Size(149, 16);
            this.lblWorkingHrs.TabIndex = 9;
            this.lblWorkingHrs.Text = "Working Hours Per Day";
            // 
            // groupBoxbackhoeDetails
            // 
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings3);
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings2);
            this.groupBoxbackhoeDetails.Controls.Add(this.txtRatings1);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblRatings);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes3);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes2);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownNoOfBackhoes1);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes3);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes2);
            this.groupBoxbackhoeDetails.Controls.Add(this.dropDownBackhoeTypes1);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblBackhoeType);
            this.groupBoxbackhoeDetails.Controls.Add(this.lblNoOfBackhoes);
            this.groupBoxbackhoeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxbackhoeDetails.Location = new System.Drawing.Point(516, 78);
            this.groupBoxbackhoeDetails.Name = "groupBoxbackhoeDetails";
            this.groupBoxbackhoeDetails.Size = new System.Drawing.Size(515, 192);
            this.groupBoxbackhoeDetails.TabIndex = 20;
            this.groupBoxbackhoeDetails.TabStop = false;
            this.groupBoxbackhoeDetails.Text = "Backhoe Details";
            // 
            // txtRatings3
            // 
            this.txtRatings3.Location = new System.Drawing.Point(287, 149);
            this.txtRatings3.Name = "txtRatings3";
            this.txtRatings3.Size = new System.Drawing.Size(87, 22);
            this.txtRatings3.TabIndex = 24;
            this.txtRatings3.Text = "0";
            // 
            // txtRatings2
            // 
            this.txtRatings2.Location = new System.Drawing.Point(287, 104);
            this.txtRatings2.Name = "txtRatings2";
            this.txtRatings2.Size = new System.Drawing.Size(87, 22);
            this.txtRatings2.TabIndex = 23;
            this.txtRatings2.Text = "0";
            // 
            // txtRatings1
            // 
            this.txtRatings1.Location = new System.Drawing.Point(287, 62);
            this.txtRatings1.Name = "txtRatings1";
            this.txtRatings1.Size = new System.Drawing.Size(87, 22);
            this.txtRatings1.TabIndex = 22;
            this.txtRatings1.Text = "0";
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(269, 30);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(118, 16);
            this.lblRatings.TabIndex = 21;
            this.lblRatings.Text = "Ratings (Per Hour)";
            // 
            // dropDownNoOfBackhoes3
            // 
            this.dropDownNoOfBackhoes3.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes3.ForeColor = System.Drawing.Color.Black;
            this.dropDownNoOfBackhoes3.FormattingEnabled = true;
            this.dropDownNoOfBackhoes3.Location = new System.Drawing.Point(435, 148);
            this.dropDownNoOfBackhoes3.Name = "dropDownNoOfBackhoes3";
            this.dropDownNoOfBackhoes3.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes3.TabIndex = 20;
            this.dropDownNoOfBackhoes3.Text = "0";
            this.dropDownNoOfBackhoes3.SelectedIndexChanged += new System.EventHandler(this.dropDownNoOfBackhoes3_SelectedIndexChanged);
            // 
            // dropDownNoOfBackhoes2
            // 
            this.dropDownNoOfBackhoes2.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDownNoOfBackhoes2.FormattingEnabled = true;
            this.dropDownNoOfBackhoes2.Location = new System.Drawing.Point(435, 102);
            this.dropDownNoOfBackhoes2.Name = "dropDownNoOfBackhoes2";
            this.dropDownNoOfBackhoes2.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes2.TabIndex = 19;
            this.dropDownNoOfBackhoes2.Text = "0";
            this.dropDownNoOfBackhoes2.SelectedIndexChanged += new System.EventHandler(this.dropDownNoOfBackhoes2_SelectedIndexChanged);
            // 
            // dropDownNoOfBackhoes1
            // 
            this.dropDownNoOfBackhoes1.BackColor = System.Drawing.Color.White;
            this.dropDownNoOfBackhoes1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropDownNoOfBackhoes1.FormattingEnabled = true;
            this.dropDownNoOfBackhoes1.Location = new System.Drawing.Point(435, 58);
            this.dropDownNoOfBackhoes1.Name = "dropDownNoOfBackhoes1";
            this.dropDownNoOfBackhoes1.Size = new System.Drawing.Size(35, 24);
            this.dropDownNoOfBackhoes1.TabIndex = 18;
            this.dropDownNoOfBackhoes1.Text = "0";
            this.dropDownNoOfBackhoes1.SelectedIndexChanged += new System.EventHandler(this.dropDownNoOfBackhoes1_SelectedIndexChanged);
            // 
            // dropDownBackhoeTypes3
            // 
            this.dropDownBackhoeTypes3.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dropDownBackhoeTypes3.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes3.Items = new string[0];
            this.dropDownBackhoeTypes3.Location = new System.Drawing.Point(9, 149);
            this.dropDownBackhoeTypes3.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.dropDownBackhoeTypes3.Name = "dropDownBackhoeTypes3";
            this.dropDownBackhoeTypes3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes3.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes3.selectedIndex = -1;
            this.dropDownBackhoeTypes3.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes3.TabIndex = 14;
            this.dropDownBackhoeTypes3.onItemSelected += new System.EventHandler(this.dropDownBackhoeTypes3_onItemSelected);
            // 
            // dropDownBackhoeTypes2
            // 
            this.dropDownBackhoeTypes2.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dropDownBackhoeTypes2.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes2.Items = new string[0];
            this.dropDownBackhoeTypes2.Location = new System.Drawing.Point(9, 104);
            this.dropDownBackhoeTypes2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dropDownBackhoeTypes2.Name = "dropDownBackhoeTypes2";
            this.dropDownBackhoeTypes2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes2.selectedIndex = -1;
            this.dropDownBackhoeTypes2.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes2.TabIndex = 13;
            this.dropDownBackhoeTypes2.onItemSelected += new System.EventHandler(this.dropDownBackhoeTypes2_onItemSelected);
            // 
            // dropDownBackhoeTypes1
            // 
            this.dropDownBackhoeTypes1.BackColor = System.Drawing.Color.Transparent;
            this.dropDownBackhoeTypes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBackhoeTypes1.ForeColor = System.Drawing.Color.White;
            this.dropDownBackhoeTypes1.Items = new string[0];
            this.dropDownBackhoeTypes1.Location = new System.Drawing.Point(9, 62);
            this.dropDownBackhoeTypes1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dropDownBackhoeTypes1.Name = "dropDownBackhoeTypes1";
            this.dropDownBackhoeTypes1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dropDownBackhoeTypes1.selectedIndex = -1;
            this.dropDownBackhoeTypes1.Size = new System.Drawing.Size(216, 22);
            this.dropDownBackhoeTypes1.TabIndex = 12;
            this.dropDownBackhoeTypes1.onItemSelected += new System.EventHandler(this.dropDownBackhoeTypes1_onItemSelected);
            // 
            // lblBackhoeType
            // 
            this.lblBackhoeType.AutoSize = true;
            this.lblBackhoeType.Location = new System.Drawing.Point(6, 30);
            this.lblBackhoeType.Name = "lblBackhoeType";
            this.lblBackhoeType.Size = new System.Drawing.Size(97, 16);
            this.lblBackhoeType.TabIndex = 7;
            this.lblBackhoeType.Text = "Backhoe Type";
            // 
            // lblNoOfBackhoes
            // 
            this.lblNoOfBackhoes.AutoSize = true;
            this.lblNoOfBackhoes.Location = new System.Drawing.Point(403, 30);
            this.lblNoOfBackhoes.Name = "lblNoOfBackhoes";
            this.lblNoOfBackhoes.Size = new System.Drawing.Size(106, 16);
            this.lblNoOfBackhoes.TabIndex = 11;
            this.lblNoOfBackhoes.Text = "No Of Backhoes";
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
            this.groupBoxCallerDetails.Location = new System.Drawing.Point(41, 365);
            this.groupBoxCallerDetails.Name = "groupBoxCallerDetails";
            this.groupBoxCallerDetails.Size = new System.Drawing.Size(990, 112);
            this.groupBoxCallerDetails.TabIndex = 19;
            this.groupBoxCallerDetails.TabStop = false;
            this.groupBoxCallerDetails.Text = "Caller Details";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(178, 66);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(224, 22);
            this.txtNIC.TabIndex = 19;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(19, 72);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(39, 16);
            this.lblNIC.TabIndex = 18;
            this.lblNIC.Text = "NIC : ";
            // 
            // dateCaller
            // 
            this.dateCaller.Location = new System.Drawing.Point(612, 31);
            this.dateCaller.Name = "dateCaller";
            this.dateCaller.Size = new System.Drawing.Size(263, 22);
            this.dateCaller.TabIndex = 17;
            this.dateCaller.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // txtCallerTpNo
            // 
            this.txtCallerTpNo.Location = new System.Drawing.Point(612, 66);
            this.txtCallerTpNo.Name = "txtCallerTpNo";
            this.txtCallerTpNo.Size = new System.Drawing.Size(263, 22);
            this.txtCallerTpNo.TabIndex = 7;
            // 
            // txtCallerName
            // 
            this.txtCallerName.Location = new System.Drawing.Point(178, 31);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(224, 22);
            this.txtCallerName.TabIndex = 6;
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Location = new System.Drawing.Point(19, 37);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(54, 16);
            this.lblCallerName.TabIndex = 1;
            this.lblCallerName.Text = "Name : ";
            // 
            // lblCalledDateTime
            // 
            this.lblCalledDateTime.AutoSize = true;
            this.lblCalledDateTime.Location = new System.Drawing.Point(472, 37);
            this.lblCalledDateTime.Name = "lblCalledDateTime";
            this.lblCalledDateTime.Size = new System.Drawing.Size(98, 16);
            this.lblCalledDateTime.TabIndex = 5;
            this.lblCalledDateTime.Text = "Date And Time";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(472, 72);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(106, 16);
            this.lblMobileNo.TabIndex = 2;
            this.lblMobileNo.Text = "Mobile Number :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(38, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(168, 16);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Customer NIC / Contract ID ";
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Location = new System.Drawing.Point(219, 510);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.Size = new System.Drawing.Size(140, 20);
            this.txtTotalCharges.TabIndex = 26;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(616, 42);
            this.txtBookingID.MaxLength = 223;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(223, 20);
            this.txtBookingID.TabIndex = 28;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(513, 43);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(85, 16);
            this.lblBookingID.TabIndex = 27;
            this.lblBookingID.Text = "Boooking ID ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Location = new System.Drawing.Point(219, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 20);
            this.panel1.TabIndex = 38;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCustomerID.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerID.MaxLength = 223;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(223, 20);
            this.txtCustomerID.TabIndex = 33;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(223, 0);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(20, 20);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 36;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // btnTotalCharge
            // 
            this.btnTotalCharge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTotalCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTotalCharge.Location = new System.Drawing.Point(61, 500);
            this.btnTotalCharge.Name = "btnTotalCharge";
            this.btnTotalCharge.Size = new System.Drawing.Size(134, 39);
            this.btnTotalCharge.TabIndex = 40;
            this.btnTotalCharge.Text = "Total Charge";
            this.btnTotalCharge.UseVisualStyleBackColor = false;
            this.btnTotalCharge.Click += new System.EventHandler(this.btnTotalCharge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 70);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Details";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(178, 27);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(767, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 33);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address :";
            // 
            // BookingUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTotalCharge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBookingPeriod);
            this.Controls.Add(this.groupBoxbackhoeDetails);
            this.Controls.Add(this.groupBoxCallerDetails);
            this.Controls.Add(this.lblID);
            this.Name = "BookingUINew";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.BookingUINew_Load);
            this.grpBookingPeriod.ResumeLayout(false);
            this.grpBookingPeriod.PerformLayout();
            this.groupBoxbackhoeDetails.ResumeLayout(false);
            this.groupBoxbackhoeDetails.PerformLayout();
            this.groupBoxCallerDetails.ResumeLayout(false);
            this.groupBoxCallerDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBookingPeriod;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWorkingHrs;
        private System.Windows.Forms.GroupBox groupBoxbackhoeDetails;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes3;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes2;
        private System.Windows.Forms.ComboBox dropDownNoOfBackhoes1;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes3;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes2;
        private System.Windows.Forms.Label lblBackhoeType;
        private System.Windows.Forms.Label lblNoOfBackhoes;
        private System.Windows.Forms.GroupBox groupBoxCallerDetails;
        private System.Windows.Forms.DateTimePicker dateCaller;
        private System.Windows.Forms.TextBox txtCallerTpNo;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.Label lblCalledDateTime;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtRatings3;
        private System.Windows.Forms.TextBox txtRatings2;
        private System.Windows.Forms.TextBox txtRatings1;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button btnCheckVehicles;
        private Bunifu.Framework.UI.BunifuDropdown dropDownBackhoeTypes1;
        private System.Windows.Forms.Button btnTotalCharge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
    }
}
