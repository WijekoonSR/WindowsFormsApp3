namespace WindowsFormsApp3
{
    partial class PayrollUIPaySlip
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Payroll_StaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CharithaS_Data = new WindowsFormsApp3.CharithaS_Data();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Payroll_StaffTableAdapter = new WindowsFormsApp3.CharithaS_DataTableAdapters.Payroll_StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Payroll_StaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharithaS_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Payroll_StaffBindingSource
            // 
            this.Payroll_StaffBindingSource.DataMember = "Payroll_Staff";
            this.Payroll_StaffBindingSource.DataSource = this.CharithaS_Data;
            // 
            // CharithaS_Data
            // 
            this.CharithaS_Data.DataSetName = "CharithaS_Data";
            this.CharithaS_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CharithaS";
            reportDataSource1.Value = this.Payroll_StaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.PayrollUIReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(747, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // Payroll_StaffTableAdapter
            // 
            this.Payroll_StaffTableAdapter.ClearBeforeFill = true;
            // 
            // PayrollUIPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayrollUIPaySlip";
            this.Text = "PayrollUIPaySlip";
            this.Load += new System.EventHandler(this.PayrollUIPaySlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Payroll_StaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharithaS_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Payroll_StaffBindingSource;
        private CharithaS_Data CharithaS_Data;
        private CharithaS_DataTableAdapters.Payroll_StaffTableAdapter Payroll_StaffTableAdapter;
    }
}