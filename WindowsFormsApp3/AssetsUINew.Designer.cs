namespace WindowsFormsApp3
{
    partial class AssetsUINew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsUINew));
            this.label13 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantityNew = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dateIssued = new System.Windows.Forms.DateTimePicker();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSpareParts = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateNew = new System.Windows.Forms.DateTimePicker();
            this.lblSpareParts = new System.Windows.Forms.Label();
            this.txtOwnContactNew = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOwnerContactNo = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxAttachNew = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssetsID = new System.Windows.Forms.TextBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAttachNew)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "Contact Number";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(182, 123);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(158, 25);
            this.txtContactNo.TabIndex = 35;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Address";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(212, 73);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(213, 25);
            this.txtQuantity.TabIndex = 35;
            // 
            // lblQuantityNew
            // 
            this.lblQuantityNew.AutoSize = true;
            this.lblQuantityNew.Location = new System.Drawing.Point(46, 78);
            this.lblQuantityNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantityNew.Name = "lblQuantityNew";
            this.lblQuantityNew.Size = new System.Drawing.Size(62, 18);
            this.lblQuantityNew.TabIndex = 34;
            this.lblQuantityNew.Text = "Quantity";
            // 
            // btnBrowse
            // 
            this.btnAttach.Location = new System.Drawing.Point(212, 199);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(60, 29);
            this.btnAttach.TabIndex = 33;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Visible = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            this.btnBrowse.Location = new System.Drawing.Point(283, 249);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 32);
            this.btnBrowse.TabIndex = 33;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // dateIssued
            // 
            this.dateIssued.Location = new System.Drawing.Point(212, 398);
            this.dateIssued.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateIssued.Name = "dateIssued";
            this.dateIssued.Size = new System.Drawing.Size(212, 25);
            this.dateIssued.TabIndex = 32;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(47, 402);
            this.lblIssuedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(37, 18);
            this.lblIssuedDate.TabIndex = 31;
            this.lblIssuedDate.Text = "Date";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(212, 360);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(212, 25);
            this.txtInvoiceNumber.TabIndex = 30;
            this.txtInvoiceNumber.TextChanged += new System.EventHandler(this.txtInvoiceNumber_TextChanged);
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(46, 362);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(107, 18);
            this.lblInvoiceNumber.TabIndex = 29;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(182, 23);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(158, 25);
            this.txtShopName.TabIndex = 33;
            this.txtShopName.TextChanged += new System.EventHandler(this.txtShopName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "shop name";
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(46, 210);
            this.lblAttachments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(95, 18);
            this.lblAttachments.Size = new System.Drawing.Size(114, 23);
            this.lblAttachments.TabIndex = 27;
            this.lblAttachments.Text = "Attachments ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(211, 164);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 25);
            this.txtPrice.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(46, 169);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 18);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(46, 123);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 18);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date";
            // 
            // txtSpareParts
            // 
            this.txtSpareParts.Location = new System.Drawing.Point(212, 36);
            this.txtSpareParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpareParts.Name = "txtSpareParts";
            this.txtSpareParts.Size = new System.Drawing.Size(212, 25);
            this.txtSpareParts.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(182, 73);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(158, 25);
            this.txtAddress.TabIndex = 36;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(853, 488);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 74);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(683, 488);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 74);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateNew
            // 
            this.dateNew.Location = new System.Drawing.Point(211, 121);
            this.dateNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNew.Name = "dateNew";
            this.dateNew.Size = new System.Drawing.Size(212, 25);
            this.dateNew.TabIndex = 22;
            // 
            // lblSpareParts
            // 
            this.lblSpareParts.AutoSize = true;
            this.lblSpareParts.Location = new System.Drawing.Point(46, 38);
            this.lblSpareParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpareParts.Name = "lblSpareParts";
            this.lblSpareParts.Size = new System.Drawing.Size(138, 18);
            this.lblSpareParts.TabIndex = 20;
            this.lblSpareParts.Text = "Puchased spare parts";
            // 
            // txtOwnContactNew
            // 
            this.txtOwnContactNew.Location = new System.Drawing.Point(182, 280);
            this.txtOwnContactNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOwnContactNew.Name = "txtOwnContactNew";
            this.txtOwnContactNew.Size = new System.Drawing.Size(158, 25);
            this.txtOwnContactNew.TabIndex = 43;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(182, 226);
            this.txtOwnerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(158, 25);
            this.txtOwnerName.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 25);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblOwnerContactNo
            // 
            this.lblOwnerContactNo.AutoSize = true;
            this.lblOwnerContactNo.Location = new System.Drawing.Point(16, 284);
            this.lblOwnerContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwnerContactNo.Name = "lblOwnerContactNo";
            this.lblOwnerContactNo.Size = new System.Drawing.Size(152, 18);
            this.lblOwnerContactNo.TabIndex = 40;
            this.lblOwnerContactNo.Text = "Owner contact Number";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(16, 231);
            this.lblOwnerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(88, 18);
            this.lblOwnerName.TabIndex = 39;
            this.lblOwnerName.Text = "Owner name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.txtOwnContactNew);
            this.groupBox2.Controls.Add(this.txtOwnerName);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblOwnerContactNo);
            this.groupBox2.Controls.Add(this.lblOwnerName);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtContactNo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtShopName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(652, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(370, 342);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchased shop Details";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 181);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 18);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.picBoxAttachNew);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantityNew);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.dateIssued);
            this.groupBox1.Controls.Add(this.lblIssuedDate);
            this.groupBox1.Controls.Add(this.txtInvoiceNumber);
            this.groupBox1.Controls.Add(this.lblInvoiceNumber);
            this.groupBox1.Controls.Add(this.lblAttachments);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.dateNew);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtSpareParts);
            this.groupBox1.Controls.Add(this.lblSpareParts);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(502, 456);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spare Parts Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picBoxAttachNew
            // 
            this.picBoxAttachNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAttachNew.Location = new System.Drawing.Point(212, 226);
            this.picBoxAttachNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxAttachNew.Name = "picBoxAttachNew";
            this.picBoxAttachNew.Size = new System.Drawing.Size(213, 110);
            this.picBoxAttachNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAttachNew.TabIndex = 36;
            this.picBoxAttachNew.TabStop = false;
            this.picBoxAttachNew.Click += new System.EventHandler(this.picBoxAttachNew_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Assets maintanance ID";
            // 
            // txtAssetsID
            // 
            this.txtAssetsID.Location = new System.Drawing.Point(290, 37);
            this.txtAssetsID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssetsID.Name = "txtAssetsID";
            this.txtAssetsID.ReadOnly = true;
            this.txtAssetsID.Size = new System.Drawing.Size(212, 20);
            this.txtAssetsID.TabIndex = 37;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleID.Location = new System.Drawing.Point(634, 32);
            this.lblVehicleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(106, 24);
            this.lblVehicleID.TabIndex = 44;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(751, 37);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(194, 20);
            this.txtVehicleID.TabIndex = 45;
            // 
            // AssetsUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.txtAssetsID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssetsUINew";
            this.Size = new System.Drawing.Size(1073, 598);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAttachNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantityNew;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker dateIssued;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSpareParts;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateNew;
        private System.Windows.Forms.Label lblSpareParts;
        private System.Windows.Forms.TextBox txtOwnContactNew;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOwnerContactNo;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxAttachNew;
        private System.Windows.Forms.TextBox txtAssetsID;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtVehicleID;
    }
}
