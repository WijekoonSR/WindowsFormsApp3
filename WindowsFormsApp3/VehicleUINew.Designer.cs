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
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.lblYearOfManufacture = new System.Windows.Forms.Label();
            this.DateRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.txtVehicleClass = new System.Windows.Forms.TextBox();
            this.txtEngineType = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtVehicleCapacity = new System.Windows.Forms.TextBox();
            this.lblVehicleClass = new System.Windows.Forms.Label();
            this.lblEngineType = new System.Windows.Forms.Label();
            this.lblVehicleCapacity = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dropdownVehicleType = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(825, 32);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(117, 21);
            this.txtVehicleID.TabIndex = 25;
            this.txtVehicleID.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(596, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 33);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(496, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.Location = new System.Drawing.Point(194, 175);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(100, 22);
            this.txtYearOfManufacture.TabIndex = 20;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.BackColor = System.Drawing.Color.White;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVehicleID.Location = new System.Drawing.Point(726, 38);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(79, 16);
            this.lblVehicleID.TabIndex = 26;
            this.lblVehicleID.Text = "Vehicle ID";
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
            this.groupBox2.Location = new System.Drawing.Point(643, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 246);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Registration Details";
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
            this.groupBox1.Controls.Add(this.lblVehicleCapacity);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(135, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 412);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(206, 384);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(101, 22);
            this.txtWeight.TabIndex = 13;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(24, 393);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(67, 13);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight(Kg)";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(206, 331);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(99, 22);
            this.txtColour.TabIndex = 7;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(24, 218);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(56, 13);
            this.lblFuelType.TabIndex = 11;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(206, 215);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(100, 22);
            this.txtFuelType.TabIndex = 10;
            // 
            // txtVehicleClass
            // 
            this.txtVehicleClass.Location = new System.Drawing.Point(206, 94);
            this.txtVehicleClass.Name = "txtVehicleClass";
            this.txtVehicleClass.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleClass.TabIndex = 9;
            // 
            // txtEngineType
            // 
            this.txtEngineType.Location = new System.Drawing.Point(206, 156);
            this.txtEngineType.Name = "txtEngineType";
            this.txtEngineType.Size = new System.Drawing.Size(100, 22);
            this.txtEngineType.TabIndex = 8;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(24, 331);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(42, 13);
            this.lblColour.TabIndex = 3;
            this.lblColour.Text = "Colour";
            // 
            // txtVehicleCapacity
            // 
            this.txtVehicleCapacity.Location = new System.Drawing.Point(206, 275);
            this.txtVehicleCapacity.Name = "txtVehicleCapacity";
            this.txtVehicleCapacity.Size = new System.Drawing.Size(100, 22);
            this.txtVehicleCapacity.TabIndex = 7;
            // 
            // lblVehicleClass
            // 
            this.lblVehicleClass.AutoSize = true;
            this.lblVehicleClass.Location = new System.Drawing.Point(22, 103);
            this.lblVehicleClass.Name = "lblVehicleClass";
            this.lblVehicleClass.Size = new System.Drawing.Size(70, 13);
            this.lblVehicleClass.TabIndex = 6;
            this.lblVehicleClass.Text = "Vehicle class";
            // 
            // lblEngineType
            // 
            this.lblEngineType.AutoSize = true;
            this.lblEngineType.Location = new System.Drawing.Point(24, 159);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(62, 13);
            this.lblEngineType.TabIndex = 5;
            this.lblEngineType.Text = "Engine No";
            // 
            // lblVehicleCapacity
            // 
            this.lblVehicleCapacity.AutoSize = true;
            this.lblVehicleCapacity.Location = new System.Drawing.Point(22, 278);
            this.lblVehicleCapacity.Name = "lblVehicleCapacity";
            this.lblVehicleCapacity.Size = new System.Drawing.Size(112, 13);
            this.lblVehicleCapacity.TabIndex = 4;
            this.lblVehicleCapacity.Text = "Vehicle Capacity(CC)";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(24, 42);
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
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleType.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVehicleType.Location = new System.Drawing.Point(68, 25);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(159, 29);
            this.lblVehicleType.TabIndex = 18;
            this.lblVehicleType.Text = " Vehicle Type";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dropdownVehicleType
            // 
            this.dropdownVehicleType.BackColor = System.Drawing.Color.Transparent;
            this.dropdownVehicleType.ForeColor = System.Drawing.Color.White;
            this.dropdownVehicleType.Items = new string[0];
            this.dropdownVehicleType.Location = new System.Drawing.Point(252, 25);
            this.dropdownVehicleType.Name = "dropdownVehicleType";
            this.dropdownVehicleType.NomalColor = System.Drawing.SystemColors.HotTrack;
            this.dropdownVehicleType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropdownVehicleType.selectedIndex = -1;
            this.dropdownVehicleType.Size = new System.Drawing.Size(217, 35);
            this.dropdownVehicleType.TabIndex = 19;
            // 
            // VehicleUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.dropdownVehicleType);
            this.Name = "VehicleUINew";
            this.Size = new System.Drawing.Size(1069, 561);
            this.Load += new System.EventHandler(this.VehicleUINew_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label lblYearOfManufacture;
        private System.Windows.Forms.DateTimePicker DateRegistration;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtVehicleClass;
        private System.Windows.Forms.TextBox txtEngineType;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtVehicleCapacity;
        private System.Windows.Forms.Label lblVehicleClass;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.Label lblVehicleCapacity;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuDropdown dropdownVehicleType;
    }
}
