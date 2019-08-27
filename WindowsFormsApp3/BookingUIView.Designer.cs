namespace WindowsFormsApp3
{
    partial class BookingUIView
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
            this.components = new System.ComponentModel.Container();
            this.databaseDataSet = new WindowsFormsApp3.DatabaseDataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp3.DatabaseDataSetTableAdapters.BookingsTableAdapter();
            this.dgvBookingsView = new System.Windows.Forms.DataGridView();
            this.databaseDataSet1 = new WindowsFormsApp3.DatabaseDataSet1();
            this.bookingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter1 = new WindowsFormsApp3.DatabaseDataSet1TableAdapters.BookingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.databaseDataSet;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvBookingsView
            // 
            this.dgvBookingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingsView.Location = new System.Drawing.Point(32, 59);
            this.dgvBookingsView.Name = "dgvBookingsView";
            this.dgvBookingsView.Size = new System.Drawing.Size(1005, 498);
            this.dgvBookingsView.TabIndex = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource1
            // 
            this.bookingsBindingSource1.DataMember = "Bookings";
            this.bookingsBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // bookingsTableAdapter1
            // 
            this.bookingsTableAdapter1.ClearBeforeFill = true;
            // 
            // BookingUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBookingsView);
            this.Name = "BookingUIView";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.BookingUIView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridView dgvBookingsView;
        private System.Windows.Forms.BindingSource bookingsBindingSource1;
        private DatabaseDataSet1 databaseDataSet1;
        private DatabaseDataSet1TableAdapters.BookingsTableAdapter bookingsTableAdapter1;
    }
}
