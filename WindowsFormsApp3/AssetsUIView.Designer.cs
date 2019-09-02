namespace WindowsFormsApp3
{
    partial class AssetsUIView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDView = new System.Windows.Forms.TextBox();
            this.lblPurchasedDate = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAssetsDetails = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Assets maintanance ID";
            // 
            // txtIDView
            // 
            this.txtIDView.Location = new System.Drawing.Point(190, 49);
            this.txtIDView.Name = "txtIDView";
            this.txtIDView.Size = new System.Drawing.Size(205, 22);
            this.txtIDView.TabIndex = 41;
            // 
            // lblPurchasedDate
            // 
            this.lblPurchasedDate.AutoSize = true;
            this.lblPurchasedDate.Location = new System.Drawing.Point(542, 52);
            this.lblPurchasedDate.Name = "lblPurchasedDate";
            this.lblPurchasedDate.Size = new System.Drawing.Size(110, 17);
            this.lblPurchasedDate.TabIndex = 42;
            this.lblPurchasedDate.Text = "Purchased Date";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(927, 52);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(83, 17);
            this.lblIssuedDate.TabIndex = 43;
            this.lblIssuedDate.Text = "Issued Date";
            this.lblIssuedDate.Click += new System.EventHandler(this.lblIssuedDate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(680, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1027, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 45;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(412, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 27);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAssetsDetails
            // 
            this.dgvAssetsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetsDetails.Location = new System.Drawing.Point(46, 100);
            this.dgvAssetsDetails.Name = "dgvAssetsDetails";
            this.dgvAssetsDetails.RowTemplate.Height = 24;
            this.dgvAssetsDetails.Size = new System.Drawing.Size(1330, 689);
            this.dgvAssetsDetails.TabIndex = 47;
            this.dgvAssetsDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(1255, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 48;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AssetsUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAssetsDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIssuedDate);
            this.Controls.Add(this.lblPurchasedDate);
            this.Controls.Add(this.txtIDView);
            this.Controls.Add(this.label1);
            this.Name = "AssetsUIView";
            this.Size = new System.Drawing.Size(1431, 736);
            this.Load += new System.EventHandler(this.AssetsUIView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDView;
        private System.Windows.Forms.Label lblPurchasedDate;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAssetsDetails;
        private System.Windows.Forms.Button button1;
    }
}
