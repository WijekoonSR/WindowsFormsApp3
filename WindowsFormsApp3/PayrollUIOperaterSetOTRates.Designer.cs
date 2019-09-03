namespace WindowsFormsApp3
{
    partial class PayrollUIOperaterSetOTRates
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSetNewOTRate = new System.Windows.Forms.TextBox();
            this.drpOTRate = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnNewOTRate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.edtSetNewOTRate);
            this.groupBox2.Controls.Add(this.drpOTRate);
            this.groupBox2.Location = new System.Drawing.Point(95, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 173);
            this.groupBox2.TabIndex = 32;
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
            this.drpOTRate.Location = new System.Drawing.Point(169, 39);
            this.drpOTRate.Name = "drpOTRate";
            this.drpOTRate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpOTRate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpOTRate.selectedIndex = -1;
            this.drpOTRate.Size = new System.Drawing.Size(102, 23);
            this.drpOTRate.TabIndex = 19;
            // 
            // btnNewOTRate
            // 
            this.btnNewOTRate.Location = new System.Drawing.Point(536, 202);
            this.btnNewOTRate.Name = "btnNewOTRate";
            this.btnNewOTRate.Size = new System.Drawing.Size(75, 23);
            this.btnNewOTRate.TabIndex = 31;
            this.btnNewOTRate.Text = "SET";
            this.btnNewOTRate.UseVisualStyleBackColor = true;
            // 
            // PayrollUIOperaterSetOTRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNewOTRate);
            this.Name = "PayrollUIOperaterSetOTRates";
            this.Size = new System.Drawing.Size(723, 396);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSetNewOTRate;
        private Bunifu.Framework.UI.BunifuDropdown drpOTRate;
        private System.Windows.Forms.Button btnNewOTRate;
    }
}
