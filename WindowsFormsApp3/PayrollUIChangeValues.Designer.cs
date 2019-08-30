namespace WindowsFormsApp3
{
    partial class PayrollUIChangeValues
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddValues = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSetNewOTRate = new System.Windows.Forms.TextBox();
            this.drpOTRate = new Bunifu.Framework.UI.BunifuDropdown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drpHousingAllownce = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.drpHousingAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.edtSetHousingAllowance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtSetFoodAllowance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtSetMedicalAllowance = new System.Windows.Forms.TextBox();
            this.drpMedicalAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewOTRate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddValues
            // 
            this.btnAddValues.Location = new System.Drawing.Point(683, 274);
            this.btnAddValues.Name = "btnAddValues";
            this.btnAddValues.Size = new System.Drawing.Size(97, 23);
            this.btnAddValues.TabIndex = 26;
            this.btnAddValues.Text = "Add New Values";
            this.btnAddValues.UseVisualStyleBackColor = true;
            this.btnAddValues.Click += new System.EventHandler(this.btnAddValues_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.edtSetNewOTRate);
            this.groupBox2.Controls.Add(this.drpOTRate);
            this.groupBox2.Location = new System.Drawing.Point(7, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 173);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "OT  Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set new OT rate";
            // 
            // edtSetNewOTRate
            // 
            this.edtSetNewOTRate.Location = new System.Drawing.Point(171, 124);
            this.edtSetNewOTRate.Name = "edtSetNewOTRate";
            this.edtSetNewOTRate.Size = new System.Drawing.Size(100, 20);
            this.edtSetNewOTRate.TabIndex = 4;
            // 
            // drpOTRate
            // 
            this.drpOTRate.BackColor = System.Drawing.Color.Transparent;
            this.drpOTRate.ForeColor = System.Drawing.Color.White;
            this.drpOTRate.Items = new string[0];
            this.drpOTRate.Location = new System.Drawing.Point(155, 39);
            this.drpOTRate.Name = "drpOTRate";
            this.drpOTRate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpOTRate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpOTRate.selectedIndex = -1;
            this.drpOTRate.Size = new System.Drawing.Size(116, 22);
            this.drpOTRate.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drpHousingAllownce);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drpHousingAllowance);
            this.groupBox1.Controls.Add(this.edtSetHousingAllowance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtSetFoodAllowance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edtSetMedicalAllowance);
            this.groupBox1.Controls.Add(this.drpMedicalAllowance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 154);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // drpHousingAllownce
            // 
            this.drpHousingAllownce.BackColor = System.Drawing.Color.Transparent;
            this.drpHousingAllownce.ForeColor = System.Drawing.Color.White;
            this.drpHousingAllownce.Items = new string[0];
            this.drpHousingAllownce.Location = new System.Drawing.Point(142, 19);
            this.drpHousingAllownce.Name = "drpHousingAllownce";
            this.drpHousingAllownce.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpHousingAllownce.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpHousingAllownce.selectedIndex = -1;
            this.drpHousingAllownce.Size = new System.Drawing.Size(116, 22);
            this.drpHousingAllownce.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Set new Housing Allowance";
            // 
            // drpHousingAllowance
            // 
            this.drpHousingAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpHousingAllowance.ForeColor = System.Drawing.Color.White;
            this.drpHousingAllowance.Items = new string[0];
            this.drpHousingAllowance.Location = new System.Drawing.Point(698, 19);
            this.drpHousingAllowance.Name = "drpHousingAllowance";
            this.drpHousingAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpHousingAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpHousingAllowance.selectedIndex = -1;
            this.drpHousingAllowance.Size = new System.Drawing.Size(116, 22);
            this.drpHousingAllowance.TabIndex = 17;
            // 
            // edtSetHousingAllowance
            // 
            this.edtSetHousingAllowance.Location = new System.Drawing.Point(158, 106);
            this.edtSetHousingAllowance.Name = "edtSetHousingAllowance";
            this.edtSetHousingAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtSetHousingAllowance.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Food Allowance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Housing Allowance";
            // 
            // edtSetFoodAllowance
            // 
            this.edtSetFoodAllowance.Location = new System.Drawing.Point(714, 106);
            this.edtSetFoodAllowance.Name = "edtSetFoodAllowance";
            this.edtSetFoodAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtSetFoodAllowance.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Set new Medical Allowance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Set new Food Allowance";
            // 
            // edtSetMedicalAllowance
            // 
            this.edtSetMedicalAllowance.Location = new System.Drawing.Point(440, 106);
            this.edtSetMedicalAllowance.Name = "edtSetMedicalAllowance";
            this.edtSetMedicalAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtSetMedicalAllowance.TabIndex = 11;
            // 
            // drpMedicalAllowance
            // 
            this.drpMedicalAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpMedicalAllowance.ForeColor = System.Drawing.Color.White;
            this.drpMedicalAllowance.Items = new string[0];
            this.drpMedicalAllowance.Location = new System.Drawing.Point(424, 19);
            this.drpMedicalAllowance.Name = "drpMedicalAllowance";
            this.drpMedicalAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpMedicalAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpMedicalAllowance.selectedIndex = -1;
            this.drpMedicalAllowance.Size = new System.Drawing.Size(116, 22);
            this.drpMedicalAllowance.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Medical Allowance";
            // 
            // btnNewOTRate
            // 
            this.btnNewOTRate.Location = new System.Drawing.Point(705, 368);
            this.btnNewOTRate.Name = "btnNewOTRate";
            this.btnNewOTRate.Size = new System.Drawing.Size(75, 23);
            this.btnNewOTRate.TabIndex = 23;
            this.btnNewOTRate.Text = "SET";
            this.btnNewOTRate.UseVisualStyleBackColor = true;
            // 
            // PayrollUIChangeValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 397);
            this.Controls.Add(this.btnAddValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewOTRate);
            this.Name = "PayrollUIChangeValues";
            this.Text = "PayrollUIChangeValues";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddValues;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSetNewOTRate;
        private Bunifu.Framework.UI.BunifuDropdown drpOTRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDropdown drpHousingAllownce;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown drpHousingAllowance;
        private System.Windows.Forms.TextBox edtSetHousingAllowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtSetFoodAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtSetMedicalAllowance;
        private Bunifu.Framework.UI.BunifuDropdown drpMedicalAllowance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewOTRate;
    }
}