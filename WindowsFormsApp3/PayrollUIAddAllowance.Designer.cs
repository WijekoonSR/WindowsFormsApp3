﻿namespace WindowsFormsApp3
{
    partial class PayrollUIAddAllowance
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
            this.edtAddMedicalAllowance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtSetHousingAllowance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtAddHousingAllowance = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtAddMedicalAllowance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edtSetHousingAllowance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtAddHousingAllowance);
            this.groupBox1.Location = new System.Drawing.Point(243, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 214);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // edtAddMedicalAllowance
            // 
            this.edtAddMedicalAllowance.Location = new System.Drawing.Point(167, 83);
            this.edtAddMedicalAllowance.Name = "edtAddMedicalAllowance";
            this.edtAddMedicalAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtAddMedicalAllowance.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add new Food Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Add new Medical Allowance";
            // 
            // edtSetHousingAllowance
            // 
            this.edtSetHousingAllowance.Location = new System.Drawing.Point(167, 160);
            this.edtSetHousingAllowance.Name = "edtSetHousingAllowance";
            this.edtSetHousingAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtSetHousingAllowance.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add new Housing Allowance";
            // 
            // edtAddHousingAllowance
            // 
            this.edtAddHousingAllowance.Location = new System.Drawing.Point(167, 19);
            this.edtAddHousingAllowance.Name = "edtAddHousingAllowance";
            this.edtAddHousingAllowance.Size = new System.Drawing.Size(100, 20);
            this.edtAddHousingAllowance.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(458, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PayrollUIAddAllowance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Name = "PayrollUIAddAllowance";
            this.Size = new System.Drawing.Size(828, 342);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtAddMedicalAllowance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtSetHousingAllowance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtAddHousingAllowance;
        private System.Windows.Forms.Button btnAdd;
    }
}