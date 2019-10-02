namespace WindowsFormsApp3
{
    partial class AssetGenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetGenerateReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSrchID = new System.Windows.Forms.Button();
            this.AssetsRepoerView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.AssetsMaintenanceGenerateReport1 = new WindowsFormsApp3.AssetsMaintenanceGenerateReport();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSrchID);
            this.panel1.Controls.Add(this.txtSearchId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AssetsRepoerView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 394);
            this.panel2.TabIndex = 1;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(71, 15);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 22);
            this.txtSearchId.TabIndex = 0;
            // 
            // btnSrchID
            // 
            this.btnSrchID.Location = new System.Drawing.Point(192, 13);
            this.btnSrchID.Name = "btnSrchID";
            this.btnSrchID.Size = new System.Drawing.Size(75, 23);
            this.btnSrchID.TabIndex = 1;
            this.btnSrchID.Text = "Search";
            this.btnSrchID.UseVisualStyleBackColor = true;
            this.btnSrchID.Click += new System.EventHandler(this.btnSrchID_Click);
            // 
            // AssetsRepoerView
            // 
            this.AssetsRepoerView.ActiveViewIndex = 0;
            this.AssetsRepoerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssetsRepoerView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AssetsRepoerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetsRepoerView.Location = new System.Drawing.Point(0, 0);
            this.AssetsRepoerView.Name = "AssetsRepoerView";
            this.AssetsRepoerView.ReportSource = this.AssetsMaintenanceGenerateReport1;
            this.AssetsRepoerView.Size = new System.Drawing.Size(800, 394);
            this.AssetsRepoerView.TabIndex = 0;
            // 
            // AssetGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetGenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetGenerateReport";
            this.Load += new System.EventHandler(this.AssetGenerateReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSrchID;
        private System.Windows.Forms.TextBox txtSearchId;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer AssetsRepoerView;
        private AssetsMaintenanceGenerateReport AssetsMaintenanceGenerateReport1;
    }
}