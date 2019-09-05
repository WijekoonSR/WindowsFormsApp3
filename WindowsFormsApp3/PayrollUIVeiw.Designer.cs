namespace WindowsFormsApp3
{
    partial class PayrollUIVeiw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollUIVeiw));
            this.dgvParollUI = new System.Windows.Forms.DataGridView();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.edtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParollUI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParollUI
            // 
            this.dgvParollUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParollUI.Location = new System.Drawing.Point(164, 153);
            this.dgvParollUI.Name = "dgvParollUI";
            this.dgvParollUI.Size = new System.Drawing.Size(791, 281);
            this.dgvParollUI.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(253, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(108, 20);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtEmployeeID
            // 
            this.edtEmployeeID.Location = new System.Drawing.Point(147, 13);
            this.edtEmployeeID.Name = "edtEmployeeID";
            this.edtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.edtEmployeeID.TabIndex = 32;
            this.edtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtEmployeeID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Employee ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefresh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Iconimage")));
            this.btnRefresh.Iconimage_right = null;
            this.btnRefresh.Iconimage_right_Selected = null;
            this.btnRefresh.Iconimage_Selected = null;
            this.btnRefresh.IconZoom = 90D;
            this.btnRefresh.IsTab = false;
            this.btnRefresh.Location = new System.Drawing.Point(388, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefresh.selected = false;
            this.btnRefresh.Size = new System.Drawing.Size(108, 20);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Textcolor = System.Drawing.Color.White;
            this.btnRefresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeID.Location = new System.Drawing.Point(186, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(38, 13);
            this.lblEmployeeID.TabIndex = 66;
            this.lblEmployeeID.Text = "Invalid";
            // 
            // PayrollUIVeiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.edtEmployeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvParollUI);
            this.Name = "PayrollUIVeiw";
            this.Size = new System.Drawing.Size(1069, 585);
            this.Load += new System.EventHandler(this.PayrollUIVeiw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParollUI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParollUI;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.TextBox edtEmployeeID;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefresh;
        private System.Windows.Forms.Label lblEmployeeID;
    }
}
