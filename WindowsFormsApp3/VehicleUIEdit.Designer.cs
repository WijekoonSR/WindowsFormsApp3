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
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.txtVehicleClass = new System.Windows.Forms.TextBox();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.lblVehicleClass = new System.Windows.Forms.Label();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblEngineType = new System.Windows.Forms.Label();
            this.lblVehicleCapacity = new System.Windows.Forms.Label();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(11, 85);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(80, 13);
            this.lblRegistrationNo.TabIndex = 1;
            this.lblRegistrationNo.Text = "Registration No";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(11, 42);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(89, 13);
            this.lblRegistrationDate.TabIndex = 0;
            this.lblRegistrationDate.Text = "Registration Date";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(140, 234);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(99, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(28, 193);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(54, 13);
            this.lblFuelType.TabIndex = 11;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(140, 193);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(100, 20);
            this.txtFuelType.TabIndex = 10;
            // 
            // txtVehicleClass
            // 
            this.txtVehicleClass.Location = new System.Drawing.Point(139, 113);
            this.txtVehicleClass.Name = "txtVehicleClass";
            this.txtVehicleClass.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleClass.TabIndex = 9;
            // 
            // txtEngineType
            // 
            this.txtEngineType.Location = new System.Drawing.Point(139, 155);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(100, 20);
            this.txtEngineType.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // txtVehicleCapacity
            // 
            this.txtVehicleCapacity.Location = new System.Drawing.Point(139, 78);
            this.txtVehicleCapacity.Name = "txtVehicleCapacity";
            this.txtVehicleCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleCapacity.TabIndex = 7;
            // 
            // lblVehicleClass
            // 
            this.lblVehicleClass.AutoSize = true;
            this.lblVehicleClass.Location = new System.Drawing.Point(26, 116);
            this.lblVehicleClass.Name = "lblVehicleClass";
            this.lblVehicleClass.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleClass.TabIndex = 6;
            this.lblVehicleClass.Text = "Vehicle class";
            // 
            // txtChassisNo
            // 
            this.txtChassisNo.Location = new System.Drawing.Point(127, 131);
            this.txtChassisNo.Name = "txtChassisNo";
            this.txtChassisNo.Size = new System.Drawing.Size(100, 20);
            this.txtChassisNo.TabIndex = 6;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(128, 85);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNo.TabIndex = 5;
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(128, 39);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationDate.TabIndex = 4;
            // 
            // lblChassisNo
            // 
            this.lblChassisNo.AutoSize = true;
            this.lblChassisNo.Location = new System.Drawing.Point(11, 131);
            this.lblChassisNo.Name = "lblChassisNo";
            this.lblChassisNo.Size = new System.Drawing.Size(60, 13);
            this.lblChassisNo.TabIndex = 2;
            this.lblChassisNo.Text = "Chassis No";
            // 
            // lblEngineType
            // 
            this.lblEngineType.AutoSize = true;
            this.lblEngineType.Location = new System.Drawing.Point(28, 155);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(67, 13);
            this.lblEngineType.TabIndex = 5;
            this.lblEngineType.Text = "Engine Type";
            // 
            // lblVehicleCapacity
            // 
            this.lblVehicleCapacity.AutoSize = true;
            this.lblVehicleCapacity.Location = new System.Drawing.Point(26, 81);
            this.lblVehicleCapacity.Name = "lblVehicleCapacity";
            this.lblVehicleCapacity.Size = new System.Drawing.Size(86, 13);
            this.lblVehicleCapacity.TabIndex = 4;
            this.lblVehicleCapacity.Text = "Vehicle Capacity";
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.Location = new System.Drawing.Point(28, 39);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(73, 13);
            this.lblVehicleName.TabIndex = 2;
            this.lblVehicleName.Text = "Vehicle Name";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Location = new System.Drawing.Point(139, 36);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(490, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpecialization);
            this.groupBox1.Controls.Add(this.lblSpecialization);
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
            this.groupBox1.Controls.Add(this.lblVehicleName);
            this.groupBox1.Controls.Add(this.txtVehicleName);
            this.groupBox1.Location = new System.Drawing.Point(18, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 347);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChassisNo);
            this.groupBox2.Controls.Add(this.txtRegistrationNo);
            this.groupBox2.Controls.Add(this.txtRegistrationDate);
            this.groupBox2.Controls.Add(this.lblChassisNo);
            this.groupBox2.Controls.Add(this.lblRegistrationNo);
            this.groupBox2.Controls.Add(this.lblRegistrationDate);
            this.groupBox2.Location = new System.Drawing.Point(518, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 347);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Registration Details";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(139, 297);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(101, 20);
            this.txtSpecialization.TabIndex = 15;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(26, 304);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(72, 13);
            this.lblSpecialization.TabIndex = 14;
            this.lblSpecialization.Text = "Specialization";
            // 
            // VehicleUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "VehicleUIEdit";
            this.Size = new System.Drawing.Size(1069, 648);
            this.Load += new System.EventHandler(this.VehicleUIEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtVehicleClass;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtVehicleCapacity;
        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.Label lblVehicleCapacity;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
    }
}
