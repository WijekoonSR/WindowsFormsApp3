namespace WindowsFormsApp3
{
    partial class PayrollUINew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenarsteSalary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDailyRates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.payrollUIGenaratesSalary1 = new WindowsFormsApp3.PayrollUIGenaratesSalary();
            this.payrollUIDailyRates1 = new WindowsFormsApp3.PayrollUIDailyRates();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenarsteSalary);
            this.panel1.Controls.Add(this.btnDailyRates);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 56);
            this.panel1.TabIndex = 41;
            // 
            // btnGenarsteSalary
            // 
            this.btnGenarsteSalary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenarsteSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenarsteSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenarsteSalary.BorderRadius = 0;
            this.btnGenarsteSalary.ButtonText = "Generates Salary";
            this.btnGenarsteSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenarsteSalary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenarsteSalary.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenarsteSalary.Iconimage = null;
            this.btnGenarsteSalary.Iconimage_right = null;
            this.btnGenarsteSalary.Iconimage_right_Selected = null;
            this.btnGenarsteSalary.Iconimage_Selected = null;
            this.btnGenarsteSalary.IconZoom = 90D;
            this.btnGenarsteSalary.IsTab = false;
            this.btnGenarsteSalary.Location = new System.Drawing.Point(119, 0);
            this.btnGenarsteSalary.Name = "btnGenarsteSalary";
            this.btnGenarsteSalary.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenarsteSalary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGenarsteSalary.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenarsteSalary.selected = false;
            this.btnGenarsteSalary.Size = new System.Drawing.Size(129, 56);
            this.btnGenarsteSalary.TabIndex = 1;
            this.btnGenarsteSalary.Textcolor = System.Drawing.Color.White;
            this.btnGenarsteSalary.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarsteSalary.Click += new System.EventHandler(this.btnGenarsteSalary_Click);
            // 
            // btnDailyRates
            // 
            this.btnDailyRates.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailyRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailyRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailyRates.BorderRadius = 0;
            this.btnDailyRates.ButtonText = "Daily Rates";
            this.btnDailyRates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyRates.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDailyRates.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDailyRates.Iconimage = null;
            this.btnDailyRates.Iconimage_right = null;
            this.btnDailyRates.Iconimage_right_Selected = null;
            this.btnDailyRates.Iconimage_Selected = null;
            this.btnDailyRates.IconZoom = 90D;
            this.btnDailyRates.IsTab = false;
            this.btnDailyRates.Location = new System.Drawing.Point(0, 0);
            this.btnDailyRates.Name = "btnDailyRates";
            this.btnDailyRates.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailyRates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDailyRates.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDailyRates.selected = false;
            this.btnDailyRates.Size = new System.Drawing.Size(119, 56);
            this.btnDailyRates.TabIndex = 0;
            this.btnDailyRates.Textcolor = System.Drawing.Color.White;
            this.btnDailyRates.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyRates.Click += new System.EventHandler(this.btnDailyRates_Click);
            // 
            // payrollUIGenaratesSalary1
            // 
            this.payrollUIGenaratesSalary1.Location = new System.Drawing.Point(2, 58);
            this.payrollUIGenaratesSalary1.Name = "payrollUIGenaratesSalary1";
            this.payrollUIGenaratesSalary1.Size = new System.Drawing.Size(1067, 523);
            this.payrollUIGenaratesSalary1.TabIndex = 43;
            // 
            // payrollUIDailyRates1
            // 
            this.payrollUIDailyRates1.Location = new System.Drawing.Point(1, 58);
            this.payrollUIDailyRates1.Name = "payrollUIDailyRates1";
            this.payrollUIDailyRates1.Size = new System.Drawing.Size(1068, 523);
            this.payrollUIDailyRates1.TabIndex = 44;
            // 
            // PayrollUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.payrollUIDailyRates1);
            this.Controls.Add(this.payrollUIGenaratesSalary1);
            this.Controls.Add(this.panel1);
            this.Name = "PayrollUINew";
            this.Size = new System.Drawing.Size(1069, 585);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenarsteSalary;
        private Bunifu.Framework.UI.BunifuFlatButton btnDailyRates;
        private PayrollUIGenaratesSalary payrollUIGenaratesSalary1;
        private PayrollUIDailyRates payrollUIDailyRates1;
    }
}
