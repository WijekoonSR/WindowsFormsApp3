namespace WindowsFormsApp3
{
    partial class VehicleUIEdit
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
            this.components = new System.ComponentModel.Container();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDateOfCommencement = new System.Windows.Forms.Label();
            this.txtHiringRate = new System.Windows.Forms.TextBox();
            this.lblHiringRate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMachineCat = new System.Windows.Forms.TextBox();
            this.lblMachineCategory = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.txtVehicleClass = new System.Windows.Forms.TextBox();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.lblVehicleClass = new System.Windows.Forms.Label();
            this.lblEngineType = new System.Windows.Forms.Label();
            this.lblVehicleCapacity = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.lblYearOfManufacture = new System.Windows.Forms.Label();
            this.DateRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.dropdownVehicleType = new Bunifu.Framework.UI.BunifuDropdown();
            this.DateCommencement = new System.Windows.Forms.DateTimePicker();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(392, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 37);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(487, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 37);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.DateCommencement);
            this.groupBox3.Controls.Add(this.lblDateOfCommencement);
            this.groupBox3.Controls.Add(this.txtHiringRate);
            this.groupBox3.Controls.Add(this.lblHiringRate);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(510, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 173);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiring Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblDateOfCommencement
            // 
            this.lblDateOfCommencement.AutoSize = true;
            this.lblDateOfCommencement.Location = new System.Drawing.Point(11, 90);
            this.lblDateOfCommencement.Name = "lblDateOfCommencement";
            this.lblDateOfCommencement.Size = new System.Drawing.Size(134, 13);
            this.lblDateOfCommencement.TabIndex = 19;
            this.lblDateOfCommencement.Text = "Date Of Commencemnet";
            // 
            // txtHiringRate
            // 
            this.txtHiringRate.Location = new System.Drawing.Point(163, 47);
            this.txtHiringRate.Name = "txtHiringRate";
            this.txtHiringRate.Size = new System.Drawing.Size(100, 22);
            this.txtHiringRate.TabIndex = 6;
            // 
            // lblHiringRate
            // 
            this.lblHiringRate.AutoSize = true;
            this.lblHiringRate.Location = new System.Drawing.Point(11, 47);
            this.lblHiringRate.Name = "lblHiringRate";
            this.lblHiringRate.Size = new System.Drawing.Size(65, 13);
            this.lblHiringRate.TabIndex = 2;
            this.lblHiringRate.Text = "Hiring Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtMachineCat);
            this.groupBox1.Controls.Add(this.lblMachineCategory);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.lblFuelType);
            this.groupBox1.Controls.Add(this.txtFuelType);
            this.groupBox1.Controls.Add(this.txtVehicleClass);
            this.groupBox1.Controls.Add(this.txtEngineType);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtVehicleCapacity);
            this.groupBox1.Controls.Add(this.lblVehicleClass);
            this.groupBox1.Controls.Add(this.lblEngineType);
            this.groupBox1.Controls.Add(this.lblVehicleCapacity);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(67, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 431);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // txtMachineCat
            // 
            this.txtMachineCat.Location = new System.Drawing.Point(206, 405);
            this.txtMachineCat.Name = "txtMachineCat";
            this.txtMachineCat.Size = new System.Drawing.Size(101, 22);
            this.txtMachineCat.TabIndex = 13;
            // 
            // lblMachineCategory
            // 
            this.lblMachineCategory.AutoSize = true;
            this.lblMachineCategory.Location = new System.Drawing.Point(28, 408);
            this.lblMachineCategory.Name = "lblMachineCategory";
            this.lblMachineCategory.Size = new System.Drawing.Size(102, 13);
            this.lblMachineCategory.TabIndex = 12;
            this.lblMachineCategory.Text = "Machine Category";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(206, 343);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(99, 22);
            this.txtStatus.TabIndex = 7;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(30, 278);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(56, 13);
            this.lblFuelType.TabIndex = 11;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(205, 278);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(100, 22);
            this.txtFuelType.TabIndex = 10;
            // 
            // txtVehicleClass
            // 
            this.txtVehicleClass.Location = new System.Drawing.Point(206, 152);
            this.txtVehicleClass.Name = "txtVehicleClass";
            this.txtVehicleClass.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleClass.TabIndex = 9;
            // 
            // txtEngineType
            // 
            this.txtEngineType.Location = new System.Drawing.Point(205, 212);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(100, 22);
            this.txtEngineType.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // txtVehicleCapacity
            // 
            this.txtVehicleCapacity.Location = new System.Drawing.Point(206, 94);
            this.txtVehicleCapacity.Name = "txtVehicleCapacity";
            this.txtVehicleCapacity.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleCapacity.TabIndex = 7;
            // 
            // lblVehicleClass
            // 
            this.lblVehicleClass.AutoSize = true;
            this.lblVehicleClass.Location = new System.Drawing.Point(30, 161);
            this.lblVehicleClass.Name = "lblVehicleClass";
            this.lblVehicleClass.Size = new System.Drawing.Size(70, 13);
            this.lblVehicleClass.TabIndex = 6;
            this.lblVehicleClass.Text = "Vehicle class";
            // 
            // lblEngineType
            // 
            this.lblEngineType.AutoSize = true;
            this.lblEngineType.Location = new System.Drawing.Point(28, 221);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(70, 13);
            this.lblEngineType.TabIndex = 5;
            this.lblEngineType.Text = "Engine Type";
            // 
            // lblVehicleCapacity
            // 
            this.lblVehicleCapacity.AutoSize = true;
            this.lblVehicleCapacity.Location = new System.Drawing.Point(28, 103);
            this.lblVehicleCapacity.Name = "lblVehicleCapacity";
            this.lblVehicleCapacity.Size = new System.Drawing.Size(90, 13);
            this.lblVehicleCapacity.TabIndex = 4;
            this.lblVehicleCapacity.Text = "Vehicle Capacity";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(28, 39);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(206, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.txtYearOfManufacture);
            this.groupBox2.Controls.Add(this.lblYearOfManufacture);
            this.groupBox2.Controls.Add(this.DateRegistration);
            this.groupBox2.Controls.Add(this.txtChassisNo);
            this.groupBox2.Controls.Add(this.txtRegistrationNo);
            this.groupBox2.Controls.Add(this.lblChassisNo);
            this.groupBox2.Controls.Add(this.lblRegistrationNo);
            this.groupBox2.Controls.Add(this.lblRegistrationDate);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(510, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 222);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Registration Details";
            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.Location = new System.Drawing.Point(194, 175);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(100, 22);
            this.txtYearOfManufacture.TabIndex = 20;
            // 
            // lblYearOfManufacture
            // 
            this.lblYearOfManufacture.AutoSize = true;
            this.lblYearOfManufacture.Location = new System.Drawing.Point(11, 178);
            this.lblYearOfManufacture.Name = "lblYearOfManufacture";
            this.lblYearOfManufacture.Size = new System.Drawing.Size(114, 13);
            this.lblYearOfManufacture.TabIndex = 19;
            this.lblYearOfManufacture.Text = "Year Of Manufacture";
            // 
            // DateRegistration
            // 
            this.DateRegistration.Location = new System.Drawing.Point(114, 36);
            this.DateRegistration.Name = "DateRegistration";
            this.DateRegistration.Size = new System.Drawing.Size(219, 22);
            this.DateRegistration.TabIndex = 18;
            this.DateRegistration.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // txtChassisNo
            // 
            this.txtChassisNo.Location = new System.Drawing.Point(194, 128);
            this.txtChassisNo.Name = "txtChassisNo";
            this.txtChassisNo.Size = new System.Drawing.Size(100, 22);
            this.txtChassisNo.TabIndex = 6;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(194, 82);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(100, 22);
            this.txtRegistrationNo.TabIndex = 5;
            this.txtRegistrationNo.TextChanged += new System.EventHandler(this.txtRegistrationNo_TextChanged);
            // 
            // lblChassisNo
            // 
            this.lblChassisNo.AutoSize = true;
            this.lblChassisNo.Location = new System.Drawing.Point(11, 131);
            this.lblChassisNo.Name = "lblChassisNo";
            this.lblChassisNo.Size = new System.Drawing.Size(64, 13);
            this.lblChassisNo.TabIndex = 2;
            this.lblChassisNo.Text = "Chassis No";
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(11, 85);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(89, 13);
            this.lblRegistrationNo.TabIndex = 1;
            this.lblRegistrationNo.Text = "Registration No";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(11, 42);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(97, 13);
            this.lblRegistrationDate.TabIndex = 0;
            this.lblRegistrationDate.Text = "Registration Date";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(581, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 37);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleType.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(62, 17);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(159, 29);
            this.lblVehicleType.TabIndex = 23;
            this.lblVehicleType.Text = " Vehicle Type";
            // 
            // dropdownVehicleType
            // 
            this.dropdownVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.dropdownVehicleType.ForeColor = System.Drawing.Color.White;
            this.dropdownVehicleType.Items = new string[0];
            this.dropdownVehicleType.Location = new System.Drawing.Point(227, 17);
            this.dropdownVehicleType.Name = "dropdownVehicleType";
            this.dropdownVehicleType.NomalColor = System.Drawing.SystemColors.HotTrack;
            this.dropdownVehicleType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownVehicleType.selectedIndex = -1;
            this.dropdownVehicleType.Size = new System.Drawing.Size(217, 35);
            this.dropdownVehicleType.TabIndex = 24;
            // 
            // DateCommencement
            // 
            this.DateCommencement.Location = new System.Drawing.Point(151, 89);
            this.DateCommencement.Name = "DateCommencement";
            this.DateCommencement.Size = new System.Drawing.Size(213, 22);
            this.DateCommencement.TabIndex = 20;
            this.DateCommencement.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleID.Location = new System.Drawing.Point(645, 17);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(88, 19);
            this.lblVehicleID.TabIndex = 25;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(740, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Location = new System.Drawing.Point(903, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // VehicleUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.dropdownVehicleType);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Name = "VehicleUIEdit";
            this.Size = new System.Drawing.Size(1069, 648);
            this.Load += new System.EventHandler(this.VehicleUIEdit_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDateOfCommencement;
        private System.Windows.Forms.TextBox txtHiringRate;
        private System.Windows.Forms.Label lblHiringRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMachineCat;
        private System.Windows.Forms.Label lblMachineCategory;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtVehicleClass;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtVehicleCapacity;
        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.Label lblVehicleCapacity;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.Label lblYearOfManufacture;
        private System.Windows.Forms.DateTimePicker DateRegistration;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblVehicleType;
        private Bunifu.Framework.UI.BunifuDropdown dropdownVehicleType;
        private System.Windows.Forms.DateTimePicker DateCommencement;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
