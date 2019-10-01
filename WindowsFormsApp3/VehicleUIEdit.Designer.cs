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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.lblYearOfManufacture = new System.Windows.Forms.Label();
            this.DateRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.txtVehicleClass = new System.Windows.Forms.TextBox();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.dropdownVehicleType = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblModel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVehicleClass = new System.Windows.Forms.Label();
            this.lblEngineType = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblVehicleCapacity = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(520, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 260);
            this.groupBox2.TabIndex = 32;
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
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(206, 405);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(101, 22);
            this.txtWeight.TabIndex = 13;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(28, 408);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 13);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight(Kg)";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(206, 343);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(99, 22);
            this.txtColour.TabIndex = 7;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(30, 221);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(56, 13);
            this.lblFuelType.TabIndex = 11;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(205, 212);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(100, 22);
            this.txtFuelType.TabIndex = 10;
            // 
            // txtVehicleClass
            // 
            this.txtVehicleClass.Location = new System.Drawing.Point(206, 92);
            this.txtVehicleClass.Name = "txtVehicleClass";
            this.txtVehicleClass.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleClass.TabIndex = 9;
            // 
            // txtEngineType
            // 
            this.txtEngineType.Location = new System.Drawing.Point(205, 151);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(100, 22);
            this.txtEngineType.TabIndex = 8;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(30, 346);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(42, 13);
            this.lblColour.TabIndex = 3;
            this.lblColour.Text = "Colour";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleID.Location = new System.Drawing.Point(655, 49);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(88, 19);
            this.lblVehicleID.TabIndex = 36;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // dropdownVehicleType
            // 
            this.dropdownVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.dropdownVehicleType.ForeColor = System.Drawing.Color.White;
            this.dropdownVehicleType.Items = new string[0];
            this.dropdownVehicleType.Location = new System.Drawing.Point(237, 49);
            this.dropdownVehicleType.Name = "dropdownVehicleType";
            this.dropdownVehicleType.NomalColor = System.Drawing.SystemColors.HotTrack;
            this.dropdownVehicleType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownVehicleType.selectedIndex = -1;
            this.dropdownVehicleType.Size = new System.Drawing.Size(217, 35);
            this.dropdownVehicleType.TabIndex = 35;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleType.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(72, 49);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(159, 29);
            this.lblVehicleType.TabIndex = 34;
            this.lblVehicleType.Text = " Vehicle Type";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(816, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 37);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Location = new System.Drawing.Point(913, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtVehicleCapacity
            // 
            this.txtVehicleCapacity.Location = new System.Drawing.Point(205, 279);
            this.txtVehicleCapacity.Name = "txtVehicleCapacity";
            this.txtVehicleCapacity.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleCapacity.TabIndex = 7;
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
            this.btnUpdate.Location = new System.Drawing.Point(586, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 37);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(701, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 37);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(750, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.txtColour);
            this.groupBox1.Controls.Add(this.lblFuelType);
            this.groupBox1.Controls.Add(this.txtFuelType);
            this.groupBox1.Controls.Add(this.txtVehicleClass);
            this.groupBox1.Controls.Add(this.txtEngineType);
            this.groupBox1.Controls.Add(this.lblColour);
            this.groupBox1.Controls.Add(this.txtVehicleCapacity);
            this.groupBox1.Controls.Add(this.lblVehicleClass);
            this.groupBox1.Controls.Add(this.lblEngineType);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.lblVehicleCapacity);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(77, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 431);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // lblVehicleClass
            // 
            this.lblVehicleClass.AutoSize = true;
            this.lblVehicleClass.Location = new System.Drawing.Point(28, 101);
            this.lblVehicleClass.Name = "lblVehicleClass";
            this.lblVehicleClass.Size = new System.Drawing.Size(70, 13);
            this.lblVehicleClass.TabIndex = 6;
            this.lblVehicleClass.Text = "Vehicle class";
            // 
            // lblEngineType
            // 
            this.lblEngineType.AutoSize = true;
            this.lblEngineType.Location = new System.Drawing.Point(28, 151);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(70, 13);
            this.lblEngineType.TabIndex = 5;
            this.lblEngineType.Text = "Engine Type";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(206, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 3;
            // 
            // lblVehicleCapacity
            // 
            this.lblVehicleCapacity.AutoSize = true;
            this.lblVehicleCapacity.Location = new System.Drawing.Point(28, 282);
            this.lblVehicleCapacity.Name = "lblVehicleCapacity";
            this.lblVehicleCapacity.Size = new System.Drawing.Size(90, 13);
            this.lblVehicleCapacity.TabIndex = 4;
            this.lblVehicleCapacity.Text = "Vehicle Capacity";
            // 
            // VehicleUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.dropdownVehicleType);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "VehicleUIEdit";
            this.Size = new System.Drawing.Size(1069, 648);
            this.Load += new System.EventHandler(this.VehicleUIEdit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.Label lblYearOfManufacture;
        private System.Windows.Forms.DateTimePicker DateRegistration;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtVehicleClass;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblVehicleID;
        private Bunifu.Framework.UI.BunifuDropdown dropdownVehicleType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtVehicleCapacity;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblVehicleCapacity;
    }
}
