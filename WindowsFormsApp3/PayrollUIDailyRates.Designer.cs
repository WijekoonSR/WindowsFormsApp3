namespace WindowsFormsApp3
{
    partial class PayrollUIDailyRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollUIDailyRates));
            this.label6 = new System.Windows.Forms.Label();
            this.edtOT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.edtWokingHours = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.drpOTRate = new Bunifu.Framework.UI.BunifuDropdown();
            this.dateTimePayroll = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edtPossition = new System.Windows.Forms.TextBox();
            this.edtCity = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetDailyRates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChangeOTRates = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Over Time";
            // 
            // edtOT
            // 
            this.edtOT.Location = new System.Drawing.Point(161, 119);
            this.edtOT.Name = "edtOT";
            this.edtOT.Size = new System.Drawing.Size(100, 20);
            this.edtOT.TabIndex = 3;
            this.edtOT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtOT_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "OT Rate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Working Hours";
            // 
            // edtWokingHours
            // 
            this.edtWokingHours.Location = new System.Drawing.Point(161, 51);
            this.edtWokingHours.Name = "edtWokingHours";
            this.edtWokingHours.Size = new System.Drawing.Size(100, 20);
            this.edtWokingHours.TabIndex = 38;
            this.edtWokingHours.TextChanged += new System.EventHandler(this.edtWokingHours_TextChanged);
            this.edtWokingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtWokingHours_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOT);
            this.groupBox4.Controls.Add(this.lblWorkingHours);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.drpOTRate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.edtOT);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.edtWokingHours);
            this.groupBox4.Location = new System.Drawing.Point(274, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 184);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.ForeColor = System.Drawing.Color.Red;
            this.lblOT.Location = new System.Drawing.Point(272, 122);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(38, 13);
            this.lblOT.TabIndex = 41;
            this.lblOT.Text = "Invalid";
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.ForeColor = System.Drawing.Color.Red;
            this.lblWorkingHours.Location = new System.Drawing.Point(272, 54);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(38, 13);
            this.lblWorkingHours.TabIndex = 40;
            this.lblWorkingHours.Text = "Invalid";
            // 
            // drpOTRate
            // 
            this.drpOTRate.BackColor = System.Drawing.Color.Transparent;
            this.drpOTRate.ForeColor = System.Drawing.Color.White;
            this.drpOTRate.Items = new string[] {
        "1200",
        "1500"};
            this.drpOTRate.Location = new System.Drawing.Point(372, 119);
            this.drpOTRate.Name = "drpOTRate";
            this.drpOTRate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpOTRate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpOTRate.selectedIndex = -1;
            this.drpOTRate.Size = new System.Drawing.Size(98, 20);
            this.drpOTRate.TabIndex = 19;
            // 
            // dateTimePayroll
            // 
            this.dateTimePayroll.Location = new System.Drawing.Point(850, 4);
            this.dateTimePayroll.Name = "dateTimePayroll";
            this.dateTimePayroll.Size = new System.Drawing.Size(200, 20);
            this.dateTimePayroll.TabIndex = 47;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuFlatButton2);
            this.groupBox3.Controls.Add(this.edtPossition);
            this.groupBox3.Controls.Add(this.edtCity);
            this.groupBox3.Controls.Add(this.edtName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.edtEmployeeID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1066, 65);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Set";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(213, 19);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(85, 20);
            this.bunifuFlatButton2.TabIndex = 30;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // edtPossition
            // 
            this.edtPossition.Location = new System.Drawing.Point(635, 19);
            this.edtPossition.Name = "edtPossition";
            this.edtPossition.ReadOnly = true;
            this.edtPossition.Size = new System.Drawing.Size(100, 20);
            this.edtPossition.TabIndex = 29;
            // 
            // edtCity
            // 
            this.edtCity.Location = new System.Drawing.Point(903, 19);
            this.edtCity.Name = "edtCity";
            this.edtCity.ReadOnly = true;
            this.edtCity.Size = new System.Drawing.Size(100, 20);
            this.edtCity.TabIndex = 28;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(376, 19);
            this.edtName.Name = "edtName";
            this.edtName.ReadOnly = true;
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
            this.label2.Location = new System.Drawing.Point(772, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Date";
            // 
            // btnSetDailyRates
            // 
            this.btnSetDailyRates.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetDailyRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetDailyRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetDailyRates.BorderRadius = 0;
            this.btnSetDailyRates.ButtonText = "Set";
            this.btnSetDailyRates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetDailyRates.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetDailyRates.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetDailyRates.Iconimage")));
            this.btnSetDailyRates.Iconimage_right = null;
            this.btnSetDailyRates.Iconimage_right_Selected = null;
            this.btnSetDailyRates.Iconimage_Selected = null;
            this.btnSetDailyRates.IconZoom = 90D;
            this.btnSetDailyRates.IsTab = false;
            this.btnSetDailyRates.Location = new System.Drawing.Point(450, 419);
            this.btnSetDailyRates.Name = "btnSetDailyRates";
            this.btnSetDailyRates.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetDailyRates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSetDailyRates.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetDailyRates.selected = false;
            this.btnSetDailyRates.Size = new System.Drawing.Size(121, 44);
            this.btnSetDailyRates.TabIndex = 50;
            this.btnSetDailyRates.Textcolor = System.Drawing.Color.White;
            this.btnSetDailyRates.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDailyRates.Click += new System.EventHandler(this.btnSetDailyRates_Click);
            // 
            // btnChangeOTRates
            // 
            this.btnChangeOTRates.Location = new System.Drawing.Point(865, 165);
            this.btnChangeOTRates.Name = "btnChangeOTRates";
            this.btnChangeOTRates.Size = new System.Drawing.Size(91, 23);
            this.btnChangeOTRates.TabIndex = 56;
            this.btnChangeOTRates.Text = "change Values";
            this.btnChangeOTRates.UseVisualStyleBackColor = true;
            this.btnChangeOTRates.Click += new System.EventHandler(this.btnChangeOTRates_Click);
            // 
            // PayrollUIDailyRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeOTRates);
            this.Controls.Add(this.btnSetDailyRates);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePayroll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Name = "PayrollUIDailyRates";
            this.Size = new System.Drawing.Size(1069, 585);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtOT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox edtWokingHours;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuDropdown drpOTRate;
        private System.Windows.Forms.DateTimePicker dateTimePayroll;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.TextBox edtPossition;
        private System.Windows.Forms.TextBox edtCity;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetDailyRates;
        private System.Windows.Forms.Button btnChangeOTRates;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.Label lblWorkingHours;
    }
}
