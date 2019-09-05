namespace WindowsFormsApp3
{
    partial class PayrollUISetAllowance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drpHousingAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.drpFoodAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.edtSetHousingAllowance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtSetFoodAllowance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtSetMedicalAllowance = new System.Windows.Forms.TextBox();
            this.drpMedicalAllowance = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drpHousingAllowance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drpFoodAllowance);
            this.groupBox1.Controls.Add(this.edtSetHousingAllowance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtSetFoodAllowance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edtSetMedicalAllowance);
            this.groupBox1.Controls.Add(this.drpMedicalAllowance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 154);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // drpHousingAllowance
            // 
            this.drpHousingAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpHousingAllowance.ForeColor = System.Drawing.Color.White;
            this.drpHousingAllowance.Items = new string[0];
            this.drpHousingAllowance.Location = new System.Drawing.Point(142, 19);
            this.drpHousingAllowance.Name = "drpHousingAllowance";
            this.drpHousingAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpHousingAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpHousingAllowance.selectedIndex = -1;
            this.drpHousingAllowance.Size = new System.Drawing.Size(116, 22);
            this.drpHousingAllowance.TabIndex = 9;
            this.drpHousingAllowance.onItemSelected += new System.EventHandler(this.drpHousingAllowance_onItemSelected);
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
            // drpFoodAllowance
            // 
            this.drpFoodAllowance.BackColor = System.Drawing.Color.Transparent;
            this.drpFoodAllowance.ForeColor = System.Drawing.Color.White;
            this.drpFoodAllowance.Items = new string[0];
            this.drpFoodAllowance.Location = new System.Drawing.Point(698, 19);
            this.drpFoodAllowance.Name = "drpFoodAllowance";
            this.drpFoodAllowance.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpFoodAllowance.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpFoodAllowance.selectedIndex = -1;
            this.drpFoodAllowance.Size = new System.Drawing.Size(116, 22);
            this.drpFoodAllowance.TabIndex = 17;
            this.drpFoodAllowance.onItemSelected += new System.EventHandler(this.drpFoodAllowance_onItemSelected);
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
            this.drpMedicalAllowance.onItemSelected += new System.EventHandler(this.drpMedicalAllowance_onItemSelected);
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(699, 292);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnNewOTRate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(539, 292);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 27;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // PayrollUISetAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Name = "PayrollUISetAllowance";
            this.Size = new System.Drawing.Size(828, 352);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDropdown drpHousingAllowance;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown drpFoodAllowance;
        private System.Windows.Forms.TextBox edtSetHousingAllowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtSetFoodAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtSetMedicalAllowance;
        private Bunifu.Framework.UI.BunifuDropdown drpMedicalAllowance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSet;
    }
}
