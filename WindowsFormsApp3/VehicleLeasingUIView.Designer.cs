namespace WindowsFormsApp3
{
    partial class VehicleLeasingUIView
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
            this.dgvVehicleLeasing = new System.Windows.Forms.DataGridView();
            this.txtLeasingID = new System.Windows.Forms.TextBox();
            this.lblLeasingID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleLeasing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleLeasing
            // 
            this.dgvVehicleLeasing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleLeasing.Location = new System.Drawing.Point(62, 63);
            this.dgvVehicleLeasing.Name = "dgvVehicleLeasing";
            this.dgvVehicleLeasing.Size = new System.Drawing.Size(931, 483);
            this.dgvVehicleLeasing.TabIndex = 0;
            // 
            // txtLeasingID
            // 
            this.txtLeasingID.Location = new System.Drawing.Point(178, 16);
            this.txtLeasingID.Name = "txtLeasingID";
            this.txtLeasingID.Size = new System.Drawing.Size(100, 20);
            this.txtLeasingID.TabIndex = 1;
            // 
            // lblLeasingID
            // 
            this.lblLeasingID.AutoSize = true;
            this.lblLeasingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeasingID.Location = new System.Drawing.Point(75, 19);
            this.lblLeasingID.Name = "lblLeasingID";
            this.lblLeasingID.Size = new System.Drawing.Size(82, 16);
            this.lblLeasingID.TabIndex = 2;
            this.lblLeasingID.Text = "Leasing ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(918, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(808, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VehicleLeasingUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLeasingID);
            this.Controls.Add(this.txtLeasingID);
            this.Controls.Add(this.dgvVehicleLeasing);
            this.Name = "VehicleLeasingUIView";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.VehicleLeasingUIView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleLeasing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleLeasing;
        private System.Windows.Forms.TextBox txtLeasingID;
        private System.Windows.Forms.Label lblLeasingID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}
