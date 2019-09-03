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
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Assets maintanance ID";
            // 
            // txtIDView
            // 
            this.txtIDView.Location = new System.Drawing.Point(178, 17);
            this.txtIDView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDView.Name = "txtIDView";
            this.txtIDView.Size = new System.Drawing.Size(155, 20);
            this.txtIDView.TabIndex = 41;
            // 
            // lblPurchasedDate
            // 
            this.lblPurchasedDate.AutoSize = true;
            this.lblPurchasedDate.Location = new System.Drawing.Point(40, 68);
            this.lblPurchasedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasedDate.Name = "lblPurchasedDate";
            this.lblPurchasedDate.Size = new System.Drawing.Size(84, 13);
            this.lblPurchasedDate.TabIndex = 42;
            this.lblPurchasedDate.Text = "Purchased Date";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(328, 68);
            this.lblIssuedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(64, 13);
            this.lblIssuedDate.TabIndex = 43;
            this.lblIssuedDate.Text = "Issued Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 62);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(411, 59);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Location = new System.Drawing.Point(364, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 33);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAssetsDetails
            // 
            this.dgvAssetsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetsDetails.Location = new System.Drawing.Point(31, 104);
            this.dgvAssetsDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAssetsDetails.Name = "dgvAssetsDetails";
            this.dgvAssetsDetails.RowTemplate.Height = 24;
            this.dgvAssetsDetails.Size = new System.Drawing.Size(999, 475);
            this.dgvAssetsDetails.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(588, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnRefresh.Location = new System.Drawing.Point(944, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 33);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AssetsUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAssetsDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIssuedDate);
            this.Controls.Add(this.lblPurchasedDate);
            this.Controls.Add(this.txtIDView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssetsUIView";
            this.Size = new System.Drawing.Size(1073, 598);
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
        private System.Windows.Forms.Button btnRefresh;
    }
}
