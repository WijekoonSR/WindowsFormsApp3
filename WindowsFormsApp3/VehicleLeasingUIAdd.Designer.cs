namespace WindowsFormsApp3
{
    partial class VehicleLeasingUIAdd
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
            this.lblVehicleLeasingID = new System.Windows.Forms.Label();
            this.txtVehicleLeasingID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.lblBankode = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateEndLeasingDate = new System.Windows.Forms.DateTimePicker();
            this.DateStartLeasingDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalLeasingAmount = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtLeasingPeriod = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblEndLeasingDate = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblStartLeasingDate = new System.Windows.Forms.Label();
            this.lblLeasingPeriod = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblTotalLeasingAmount = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtVid = new System.Windows.Forms.TextBox();
            this.lblVid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleLeasingID
            // 
            this.lblVehicleLeasingID.AutoSize = true;
            this.lblVehicleLeasingID.Location = new System.Drawing.Point(68, 37);
            this.lblVehicleLeasingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleLeasingID.Name = "lblVehicleLeasingID";
            this.lblVehicleLeasingID.Size = new System.Drawing.Size(129, 17);
            this.lblVehicleLeasingID.TabIndex = 0;
            this.lblVehicleLeasingID.Text = "Vehicle Leasing ID ";
            // 
            // txtVehicleLeasingID
            // 
            this.txtVehicleLeasingID.Location = new System.Drawing.Point(235, 33);
            this.txtVehicleLeasingID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVehicleLeasingID.Name = "txtVehicleLeasingID";
            this.txtVehicleLeasingID.ReadOnly = true;
            this.txtVehicleLeasingID.Size = new System.Drawing.Size(132, 22);
            this.txtVehicleLeasingID.TabIndex = 1;
            this.txtVehicleLeasingID.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBankCode);
            this.groupBox1.Controls.Add(this.txtBranch);
            this.groupBox1.Controls.Add(this.lblBankode);
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.lblBank);
            this.groupBox1.Location = new System.Drawing.Point(159, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(359, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Details";
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(104, 156);
            this.txtBankCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(132, 22);
            this.txtBankCode.TabIndex = 6;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(104, 100);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(132, 22);
            this.txtBranch.TabIndex = 5;
            this.txtBranch.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            // 
            // lblBankode
            // 
            this.lblBankode.AutoSize = true;
            this.lblBankode.Location = new System.Drawing.Point(8, 160);
            this.lblBankode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankode.Name = "lblBankode";
            this.lblBankode.Size = new System.Drawing.Size(77, 17);
            this.lblBankode.TabIndex = 3;
            this.lblBankode.Text = "Bank Code";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(8, 100);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(53, 17);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Branch";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(104, 43);
            this.txtBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(132, 22);
            this.txtBank.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(9, 43);
            this.lblBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(40, 17);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateEndLeasingDate);
            this.groupBox2.Controls.Add(this.DateStartLeasingDate);
            this.groupBox2.Controls.Add(this.txtTotalLeasingAmount);
            this.groupBox2.Controls.Add(this.txtAnnualInterestRate);
            this.groupBox2.Controls.Add(this.txtMonthlyPayment);
            this.groupBox2.Controls.Add(this.txtLeasingPeriod);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.lblEndLeasingDate);
            this.groupBox2.Controls.Add(this.lblMonthlyPayment);
            this.groupBox2.Controls.Add(this.lblStartLeasingDate);
            this.groupBox2.Controls.Add(this.lblLeasingPeriod);
            this.groupBox2.Controls.Add(this.lblAnnualInterestRate);
            this.groupBox2.Controls.Add(this.lblTotalLeasingAmount);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Location = new System.Drawing.Point(693, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(477, 438);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leasing Details";
            // 
            // DateEndLeasingDate
            // 
            this.DateEndLeasingDate.Location = new System.Drawing.Point(207, 359);
            this.DateEndLeasingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateEndLeasingDate.Name = "DateEndLeasingDate";
            this.DateEndLeasingDate.Size = new System.Drawing.Size(265, 22);
            this.DateEndLeasingDate.TabIndex = 14;
            // 
            // DateStartLeasingDate
            // 
            this.DateStartLeasingDate.Location = new System.Drawing.Point(207, 308);
            this.DateStartLeasingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateStartLeasingDate.Name = "DateStartLeasingDate";
            this.DateStartLeasingDate.Size = new System.Drawing.Size(265, 22);
            this.DateStartLeasingDate.TabIndex = 13;
            // 
            // txtTotalLeasingAmount
            // 
            this.txtTotalLeasingAmount.Location = new System.Drawing.Point(207, 100);
            this.txtTotalLeasingAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalLeasingAmount.Name = "txtTotalLeasingAmount";
            this.txtTotalLeasingAmount.Size = new System.Drawing.Size(132, 22);
            this.txtTotalLeasingAmount.TabIndex = 12;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(207, 160);
            this.txtAnnualInterestRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(132, 22);
            this.txtAnnualInterestRate.TabIndex = 11;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(207, 266);
            this.txtMonthlyPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(132, 22);
            this.txtMonthlyPayment.TabIndex = 9;
            // 
            // txtLeasingPeriod
            // 
            this.txtLeasingPeriod.Location = new System.Drawing.Point(207, 213);
            this.txtLeasingPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeasingPeriod.Name = "txtLeasingPeriod";
            this.txtLeasingPeriod.Size = new System.Drawing.Size(132, 22);
            this.txtLeasingPeriod.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(207, 43);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 22);
            this.txtYear.TabIndex = 7;
            // 
            // lblEndLeasingDate
            // 
            this.lblEndLeasingDate.AutoSize = true;
            this.lblEndLeasingDate.Location = new System.Drawing.Point(9, 369);
            this.lblEndLeasingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndLeasingDate.Name = "lblEndLeasingDate";
            this.lblEndLeasingDate.Size = new System.Drawing.Size(121, 17);
            this.lblEndLeasingDate.TabIndex = 6;
            this.lblEndLeasingDate.Text = "End Leasing Date";
            this.lblEndLeasingDate.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(9, 266);
            this.lblMonthlyPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(116, 17);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // lblStartLeasingDate
            // 
            this.lblStartLeasingDate.AutoSize = true;
            this.lblStartLeasingDate.Location = new System.Drawing.Point(9, 318);
            this.lblStartLeasingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartLeasingDate.Name = "lblStartLeasingDate";
            this.lblStartLeasingDate.Size = new System.Drawing.Size(126, 17);
            this.lblStartLeasingDate.TabIndex = 4;
            this.lblStartLeasingDate.Text = "Start Leasing Date";
            // 
            // lblLeasingPeriod
            // 
            this.lblLeasingPeriod.AutoSize = true;
            this.lblLeasingPeriod.Location = new System.Drawing.Point(8, 213);
            this.lblLeasingPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeasingPeriod.Name = "lblLeasingPeriod";
            this.lblLeasingPeriod.Size = new System.Drawing.Size(103, 17);
            this.lblLeasingPeriod.TabIndex = 3;
            this.lblLeasingPeriod.Text = "Leasing Period";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(9, 160);
            this.lblAnnualInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(137, 17);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate";
            // 
            // lblTotalLeasingAmount
            // 
            this.lblTotalLeasingAmount.AutoSize = true;
            this.lblTotalLeasingAmount.Location = new System.Drawing.Point(5, 100);
            this.lblTotalLeasingAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLeasingAmount.Name = "lblTotalLeasingAmount";
            this.lblTotalLeasingAmount.Size = new System.Drawing.Size(146, 17);
            this.lblTotalLeasingAmount.TabIndex = 1;
            this.lblTotalLeasingAmount.Text = "Total Leasing Amount";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(9, 42);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(399, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 43);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccountNumber);
            this.groupBox3.Controls.Add(this.txtAccountHolder);
            this.groupBox3.Controls.Add(this.lblAccountNumber);
            this.groupBox3.Controls.Add(this.lblAccountHolder);
            this.groupBox3.Location = new System.Drawing.Point(159, 439);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(359, 123);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Details";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(163, 81);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(132, 22);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(163, 28);
            this.txtAccountHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(132, 22);
            this.txtAccountHolder.TabIndex = 2;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(9, 81);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(113, 17);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(9, 33);
            this.lblAccountHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(105, 17);
            this.lblAccountHolder.TabIndex = 0;
            this.lblAccountHolder.Text = "Account Holder";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(705, 590);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(837, 590);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 46);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtVid
            // 
            this.txtVid.Location = new System.Drawing.Point(235, 84);
            this.txtVid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVid.Name = "txtVid";
            this.txtVid.Size = new System.Drawing.Size(132, 22);
            this.txtVid.TabIndex = 9;
            // 
            // lblVid
            // 
            this.lblVid.AutoSize = true;
            this.lblVid.Location = new System.Drawing.Point(68, 92);
            this.lblVid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVid.Name = "lblVid";
            this.lblVid.Size = new System.Drawing.Size(75, 17);
            this.lblVid.TabIndex = 8;
            this.lblVid.Text = "Vehicle ID ";
            // 
            // VehicleLeasingUIAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVid);
            this.Controls.Add(this.lblVid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVehicleLeasingID);
            this.Controls.Add(this.lblVehicleLeasingID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VehicleLeasingUIAdd";
            this.Size = new System.Drawing.Size(1425, 716);
            this.Load += new System.EventHandler(this.VehicleLeasingUIAdd_Load);
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

        private System.Windows.Forms.Label lblVehicleLeasingID;
        private System.Windows.Forms.TextBox txtVehicleLeasingID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label lblBankode;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEndLeasingDate;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblStartLeasingDate;
        private System.Windows.Forms.Label lblLeasingPeriod;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblTotalLeasingAmount;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTotalLeasingAmount;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtLeasingPeriod;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker DateEndLeasingDate;
        private System.Windows.Forms.DateTimePicker DateStartLeasingDate;
        private System.Windows.Forms.TextBox txtVid;
        private System.Windows.Forms.Label lblVid;
    }
}
