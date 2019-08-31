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
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBankode = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTotalLeasingAmount = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblLeasingPeriod = new System.Windows.Forms.Label();
            this.lblStartLeasingDate = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblEndLeasingDate = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtLeasingPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtStartLeasingDate = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtTotalLeasingAmount = new System.Windows.Forms.TextBox();
            this.txtEndLeasingDate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(51, 30);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleID.TabIndex = 0;
            this.lblVehicleID.Text = "Vehicle ID ";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(154, 27);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBankCode);
            this.groupBox1.Controls.Add(this.txtBranch);
            this.groupBox1.Controls.Add(this.lblBankode);
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.lblBank);
            this.groupBox1.Location = new System.Drawing.Point(119, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Details";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(7, 35);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(78, 35);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(100, 20);
            this.txtBank.TabIndex = 1;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(6, 81);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 2;
            this.lblBranch.Text = "Branch";
            // 
            // lblBankode
            // 
            this.lblBankode.AutoSize = true;
            this.lblBankode.Location = new System.Drawing.Point(6, 130);
            this.lblBankode.Name = "lblBankode";
            this.lblBankode.Size = new System.Drawing.Size(60, 13);
            this.lblBankode.TabIndex = 3;
            this.lblBankode.Text = "Bank Code";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(78, 81);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(100, 20);
            this.txtBranch.TabIndex = 5;
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(78, 127);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(100, 20);
            this.txtBankCode.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEndLeasingDate);
            this.groupBox2.Controls.Add(this.txtTotalLeasingAmount);
            this.groupBox2.Controls.Add(this.txtAnnualInterestRate);
            this.groupBox2.Controls.Add(this.txtStartLeasingDate);
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
            this.groupBox2.Location = new System.Drawing.Point(520, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 356);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leasing Details";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(7, 34);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // lblTotalLeasingAmount
            // 
            this.lblTotalLeasingAmount.AutoSize = true;
            this.lblTotalLeasingAmount.Location = new System.Drawing.Point(4, 81);
            this.lblTotalLeasingAmount.Name = "lblTotalLeasingAmount";
            this.lblTotalLeasingAmount.Size = new System.Drawing.Size(110, 13);
            this.lblTotalLeasingAmount.TabIndex = 1;
            this.lblTotalLeasingAmount.Text = "Total Leasing Amount";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(7, 130);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(104, 13);
            this.lblAnnualInterestRate.TabIndex = 2;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate";
            // 
            // lblLeasingPeriod
            // 
            this.lblLeasingPeriod.AutoSize = true;
            this.lblLeasingPeriod.Location = new System.Drawing.Point(6, 173);
            this.lblLeasingPeriod.Name = "lblLeasingPeriod";
            this.lblLeasingPeriod.Size = new System.Drawing.Size(77, 13);
            this.lblLeasingPeriod.TabIndex = 3;
            this.lblLeasingPeriod.Text = "Leasing Period";
            // 
            // lblStartLeasingDate
            // 
            this.lblStartLeasingDate.AutoSize = true;
            this.lblStartLeasingDate.Location = new System.Drawing.Point(7, 258);
            this.lblStartLeasingDate.Name = "lblStartLeasingDate";
            this.lblStartLeasingDate.Size = new System.Drawing.Size(95, 13);
            this.lblStartLeasingDate.TabIndex = 4;
            this.lblStartLeasingDate.Text = "Start Leasing Date";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(7, 216);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // lblEndLeasingDate
            // 
            this.lblEndLeasingDate.AutoSize = true;
            this.lblEndLeasingDate.Location = new System.Drawing.Point(7, 300);
            this.lblEndLeasingDate.Name = "lblEndLeasingDate";
            this.lblEndLeasingDate.Size = new System.Drawing.Size(92, 13);
            this.lblEndLeasingDate.TabIndex = 6;
            this.lblEndLeasingDate.Text = "End Leasing Date";
            this.lblEndLeasingDate.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(155, 35);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 7;
            // 
            // txtLeasingPeriod
            // 
            this.txtLeasingPeriod.Location = new System.Drawing.Point(155, 173);
            this.txtLeasingPeriod.Name = "txtLeasingPeriod";
            this.txtLeasingPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtLeasingPeriod.TabIndex = 8;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(155, 216);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyPayment.TabIndex = 9;
            // 
            // txtStartLeasingDate
            // 
            this.txtStartLeasingDate.Location = new System.Drawing.Point(155, 258);
            this.txtStartLeasingDate.Name = "txtStartLeasingDate";
            this.txtStartLeasingDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartLeasingDate.TabIndex = 10;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(155, 130);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualInterestRate.TabIndex = 11;
            // 
            // txtTotalLeasingAmount
            // 
            this.txtTotalLeasingAmount.Location = new System.Drawing.Point(155, 81);
            this.txtTotalLeasingAmount.Name = "txtTotalLeasingAmount";
            this.txtTotalLeasingAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalLeasingAmount.TabIndex = 12;
            // 
            // txtEndLeasingDate
            // 
            this.txtEndLeasingDate.Location = new System.Drawing.Point(155, 300);
            this.txtEndLeasingDate.Name = "txtEndLeasingDate";
            this.txtEndLeasingDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndLeasingDate.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(299, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccountNumber);
            this.groupBox3.Controls.Add(this.txtAccountHolder);
            this.groupBox3.Controls.Add(this.lblAccountNumber);
            this.groupBox3.Controls.Add(this.lblAccountHolder);
            this.groupBox3.Location = new System.Drawing.Point(119, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Details";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(7, 27);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(81, 13);
            this.lblAccountHolder.TabIndex = 0;
            this.lblAccountHolder.Text = "Account Holder";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(7, 66);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(122, 23);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(100, 20);
            this.txtAccountHolder.TabIndex = 2;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(122, 66);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(529, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(628, 479);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // VehicleLeasingUIAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblVehicleID);
            this.Name = "VehicleLeasingUIAdd";
            this.Size = new System.Drawing.Size(1069, 582);
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

        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtVehicleID;
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
        private System.Windows.Forms.TextBox txtEndLeasingDate;
        private System.Windows.Forms.TextBox txtTotalLeasingAmount;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtStartLeasingDate;
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
    }
}
