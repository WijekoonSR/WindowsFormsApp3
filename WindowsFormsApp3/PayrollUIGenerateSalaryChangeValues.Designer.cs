namespace WindowsFormsApp3
{
    partial class PayrollUIGenerateSalaryChangeValues
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
            this.payrollUISetAllowance1 = new WindowsFormsApp3.PayrollUISetAllowance();
            this.SuspendLayout();
            // 
            // payrollUISetAllowance1
            // 
            this.payrollUISetAllowance1.Location = new System.Drawing.Point(-2, 35);
            this.payrollUISetAllowance1.Name = "payrollUISetAllowance1";
            this.payrollUISetAllowance1.Size = new System.Drawing.Size(828, 352);
            this.payrollUISetAllowance1.TabIndex = 1;
            this.payrollUISetAllowance1.Load += new System.EventHandler(this.payrollUISetAllowance1_Load);
            // 
            // PayrollUIGenerateSalaryChangeValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 406);
            this.Controls.Add(this.payrollUISetAllowance1);
            this.Name = "PayrollUIGenerateSalaryChangeValues";
            this.Text = "PayrollUIGenerateSalaryChangeValues";
            this.ResumeLayout(false);

        }

        #endregion

        private PayrollUISetAllowance payrollUISetAllowance1;
    }
}