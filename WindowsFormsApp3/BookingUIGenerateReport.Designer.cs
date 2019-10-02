namespace WindowsFormsApp3
{
    partial class BookingUIGenerateReport
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
            this.BookingsReport1 = new WindowsFormsApp3.BookingsReport();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIdSrch = new System.Windows.Forms.Button();
            this.txtBookingIdSrch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIdSrch);
            this.panel1.Controls.Add(this.txtBookingIdSrch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIdSrch
            // 
            this.btnIdSrch.Location = new System.Drawing.Point(144, 12);
            this.btnIdSrch.Name = "btnIdSrch";
            this.btnIdSrch.Size = new System.Drawing.Size(75, 23);
            this.btnIdSrch.TabIndex = 1;
            this.btnIdSrch.Text = "button1";
            this.btnIdSrch.UseVisualStyleBackColor = true;
            this.btnIdSrch.Click += new System.EventHandler(this.btnIdSrch_Click);
            // 
            // txtBookingIdSrch
            // 
            this.txtBookingIdSrch.Location = new System.Drawing.Point(28, 12);
            this.txtBookingIdSrch.Name = "txtBookingIdSrch";
            this.txtBookingIdSrch.Size = new System.Drawing.Size(100, 20);
            this.txtBookingIdSrch.TabIndex = 0;
            this.txtBookingIdSrch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 395);
            this.panel2.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 395);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // BookingUIGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookingUIGenerateReport";
            this.Text = "BookingUIGenerateReport";
            this.Load += new System.EventHandler(this.BookingUIGenerateReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BookingsReport BookingsReport1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBookingIdSrch;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnIdSrch;
    }
}