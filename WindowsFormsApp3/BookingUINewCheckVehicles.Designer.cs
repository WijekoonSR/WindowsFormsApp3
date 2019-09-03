namespace WindowsFormsApp3
{
    partial class BookingUINewCheckVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUINewCheckVehicles));
            this.dgvAvaiableVehicles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaiableVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvaiableVehicles
            // 
            this.dgvAvaiableVehicles.AllowUserToAddRows = false;
            this.dgvAvaiableVehicles.AllowUserToDeleteRows = false;
            this.dgvAvaiableVehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.dgvAvaiableVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaiableVehicles.Location = new System.Drawing.Point(12, 12);
            this.dgvAvaiableVehicles.Name = "dgvAvaiableVehicles";
            this.dgvAvaiableVehicles.ReadOnly = true;
            this.dgvAvaiableVehicles.Size = new System.Drawing.Size(416, 269);
            this.dgvAvaiableVehicles.TabIndex = 0;
            this.dgvAvaiableVehicles.UseWaitCursor = true;
            this.dgvAvaiableVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvaiableVehicles_CellContentClick);
            // 
            // BookingUINewCheckVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 297);
            this.Controls.Add(this.dgvAvaiableVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingUINewCheckVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Vehicles";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaiableVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvaiableVehicles;
    }
}