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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleLeasing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleLeasing
            // 
            this.dgvVehicleLeasing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleLeasing.Location = new System.Drawing.Point(173, 120);
            this.dgvVehicleLeasing.Name = "dgvVehicleLeasing";
            this.dgvVehicleLeasing.Size = new System.Drawing.Size(635, 395);
            this.dgvVehicleLeasing.TabIndex = 0;
            // 
            // VehicleLeasingUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVehicleLeasing);
            this.Name = "VehicleLeasingUIView";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.VehicleLeasingUIView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleLeasing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleLeasing;
    }
}
