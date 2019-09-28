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
            this.datePurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dateIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAssetsDetails = new System.Windows.Forms.DataGridView();
            this.btnSearchPurchasedate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchIssuedDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Assets maintanance ID";
            // 
            // txtIDView
            // 
            this.txtIDView.Location = new System.Drawing.Point(237, 21);
            this.txtIDView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDView.Name = "txtIDView";
            this.txtIDView.Size = new System.Drawing.Size(205, 22);
            this.txtIDView.TabIndex = 41;
            // 
            // lblPurchasedDate
            // 
            this.lblPurchasedDate.AutoSize = true;
            this.lblPurchasedDate.Location = new System.Drawing.Point(53, 84);
            this.lblPurchasedDate.Name = "lblPurchasedDate";
            this.lblPurchasedDate.Size = new System.Drawing.Size(110, 17);
            this.lblPurchasedDate.TabIndex = 42;
            this.lblPurchasedDate.Text = "Purchased Date";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(593, 84);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(83, 17);
            this.lblIssuedDate.TabIndex = 43;
            this.lblIssuedDate.Text = "Issued Date";
            // 
            // datePurchaseDate
            // 
            this.datePurchaseDate.Location = new System.Drawing.Point(192, 76);
            this.datePurchaseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePurchaseDate.Name = "datePurchaseDate";
            this.datePurchaseDate.Size = new System.Drawing.Size(200, 22);
            this.datePurchaseDate.TabIndex = 44;
            // 
            // dateIssuedDate
            // 
            this.dateIssuedDate.Location = new System.Drawing.Point(704, 78);
            this.dateIssuedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateIssuedDate.Name = "dateIssuedDate";
            this.dateIssuedDate.Size = new System.Drawing.Size(200, 22);
            this.dateIssuedDate.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(485, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 41);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAssetsDetails
            // 
            this.dgvAssetsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetsDetails.Location = new System.Drawing.Point(41, 128);
            this.dgvAssetsDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAssetsDetails.Name = "dgvAssetsDetails";
            this.dgvAssetsDetails.RowTemplate.Height = 24;
            this.dgvAssetsDetails.Size = new System.Drawing.Size(1332, 585);
            this.dgvAssetsDetails.TabIndex = 47;
            this.dgvAssetsDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssetsDetails_CellContentClick);
            // 
            // btnSearchPurchasedate
            // 
            this.btnSearchPurchasedate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearchPurchasedate.Location = new System.Drawing.Point(444, 73);
            this.btnSearchPurchasedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPurchasedate.Name = "btnSearchPurchasedate";
            this.btnSearchPurchasedate.Size = new System.Drawing.Size(99, 41);
            this.btnSearchPurchasedate.TabIndex = 48;
            this.btnSearchPurchasedate.Text = "Search";
            this.btnSearchPurchasedate.UseVisualStyleBackColor = false;
            this.btnSearchPurchasedate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnRefresh.Location = new System.Drawing.Point(1259, 68);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 41);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchIssuedDate
            // 
            this.btnSearchIssuedDate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearchIssuedDate.Location = new System.Drawing.Point(949, 68);
            this.btnSearchIssuedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchIssuedDate.Name = "btnSearchIssuedDate";
            this.btnSearchIssuedDate.Size = new System.Drawing.Size(99, 41);
            this.btnSearchIssuedDate.TabIndex = 50;
            this.btnSearchIssuedDate.Text = "Search";
            this.btnSearchIssuedDate.UseVisualStyleBackColor = false;
            this.btnSearchIssuedDate.Click += new System.EventHandler(this.btnSearchIssuedDate_Click);
            // 
            // AssetsUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchIssuedDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearchPurchasedate);
            this.Controls.Add(this.dgvAssetsDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateIssuedDate);
            this.Controls.Add(this.datePurchaseDate);
            this.Controls.Add(this.lblIssuedDate);
            this.Controls.Add(this.lblPurchasedDate);
            this.Controls.Add(this.txtIDView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AssetsUIView";
            this.Size = new System.Drawing.Size(1431, 736);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDView;
        private System.Windows.Forms.Label lblPurchasedDate;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.DateTimePicker datePurchaseDate;
        private System.Windows.Forms.DateTimePicker dateIssuedDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAssetsDetails;
        private System.Windows.Forms.Button btnSearchPurchasedate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchIssuedDate;
    }
}
