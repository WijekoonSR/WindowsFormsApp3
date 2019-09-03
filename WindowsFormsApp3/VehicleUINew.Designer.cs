namespace WindowsFormsApp3
{
    partial class VehicleUINew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleUINew));
            this.lblVehicleType = new System.Windows.Forms.Label();
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
            this.dropdownVehicleType = new Bunifu.Framework.UI.BunifuDropdown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.lblYearOfManufacture = new System.Windows.Forms.Label();
            this.DateRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateOfCommencement = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfCommencement = new System.Windows.Forms.Label();
            this.txtHiringRate = new System.Windows.Forms.TextBox();
            this.lblHiringRate = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblVehicleType.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(24, 28);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(159, 29);
            this.lblVehicleType.TabIndex = 2;
            this.lblVehicleType.Text = " Vehicle Type";
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
            this.groupBox1.Location = new System.Drawing.Point(91, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 412);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // txtMachineCat
            // 
            this.txtMachineCat.Location = new System.Drawing.Point(203, 384);
            this.txtMachineCat.Name = "txtMachineCat";
            this.txtMachineCat.Size = new System.Drawing.Size(101, 22);
            this.txtMachineCat.TabIndex = 13;
            // 
            // lblMachineCategory
            // 
            this.lblMachineCategory.AutoSize = true;
            this.lblMachineCategory.Location = new System.Drawing.Point(28, 393);
            this.lblMachineCategory.Name = "lblMachineCategory";
            this.lblMachineCategory.Size = new System.Drawing.Size(102, 13);
            this.lblMachineCategory.TabIndex = 12;
            this.lblMachineCategory.Text = "Machine Category";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(205, 328);
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
            this.txtFuelType.Location = new System.Drawing.Point(204, 269);
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
            this.lblStatus.Location = new System.Drawing.Point(30, 331);
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
            // dropdownVehicleType
            // 
            this.dropdownVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.dropdownVehicleType.ForeColor = System.Drawing.Color.White;
            this.dropdownVehicleType.Items = new string[0];
            this.dropdownVehicleType.Location = new System.Drawing.Point(208, 28);
            this.dropdownVehicleType.Name = "dropdownVehicleType";
            this.dropdownVehicleType.NomalColor = System.Drawing.Color.Goldenrod;
            this.dropdownVehicleType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownVehicleType.selectedIndex = -1;
            this.dropdownVehicleType.Size = new System.Drawing.Size(217, 35);
            this.dropdownVehicleType.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.groupBox2.Location = new System.Drawing.Point(604, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 222);
            this.groupBox2.TabIndex = 10;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(452, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(552, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.dateOfCommencement);
            this.groupBox3.Controls.Add(this.lblDateOfCommencement);
            this.groupBox3.Controls.Add(this.txtHiringRate);
            this.groupBox3.Controls.Add(this.lblHiringRate);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(604, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 165);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiring Details";
            // 
            // dateOfCommencement
            // 
            this.dateOfCommencement.Location = new System.Drawing.Point(151, 83);
            this.dateOfCommencement.Name = "dateOfCommencement";
            this.dateOfCommencement.Size = new System.Drawing.Size(196, 22);
            this.dateOfCommencement.TabIndex = 20;
            this.dateOfCommencement.Value = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
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
            this.txtHiringRate.Location = new System.Drawing.Point(194, 44);
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
            // txtVehicleID
            // 
            this.txtVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(781, 35);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(117, 21);
            this.txtVehicleID.TabIndex = 16;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.BackColor = System.Drawing.Color.Black;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVehicleID.Location = new System.Drawing.Point(682, 41);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(79, 16);
            this.lblVehicleID.TabIndex = 17;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // VehicleUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dropdownVehicleType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVehicleType);
            this.Name = "VehicleUINew";
            this.Size = new System.Drawing.Size(1069, 561);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtVehicleCapacity;
        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.Label lblVehicleCapacity;
        private Bunifu.Framework.UI.BunifuDropdown dropdownVehicleType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtVehicleClass;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label lblMachineCategory;
        private System.Windows.Forms.TextBox txtMachineCat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker DateRegistration;
        private System.Windows.Forms.Label lblYearOfManufacture;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDateOfCommencement;
        private System.Windows.Forms.TextBox txtHiringRate;
        private System.Windows.Forms.Label lblHiringRate;
        private System.Windows.Forms.DateTimePicker dateOfCommencement;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label lblVehicleID;
    }
}
