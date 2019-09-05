namespace WindowsFormsApp3
{
    partial class AssetsUIEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsUIEdit));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantityEdit = new System.Windows.Forms.TextBox();
            this.lblQuantityNew = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher4 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher5 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher6 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher7 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher8 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher9 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher10 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher11 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher12 = new System.DirectoryServices.DirectorySearcher();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher13 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher14 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher15 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher16 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher17 = new System.DirectoryServices.DirectorySearcher();
            this.btnClearEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOwnContactEdit = new System.Windows.Forms.TextBox();
            this.txtOwnerEdit = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOwnerContactNoEdit = new System.Windows.Forms.Label();
            this.lblOwnerNameEdit = new System.Windows.Forms.Label();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.lblContactNoEdit = new System.Windows.Forms.Label();
            this.txtAddressEdit = new System.Windows.Forms.TextBox();
            this.txtContactNoEdit = new System.Windows.Forms.TextBox();
            this.lblAddressEdit = new System.Windows.Forms.Label();
            this.txtShopNameEdit = new System.Windows.Forms.TextBox();
            this.lblShopNameEdit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxAttachEdit = new System.Windows.Forms.PictureBox();
            this.dateIssuedEdit = new System.Windows.Forms.DateTimePicker();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.txtInvoiceNumberEdit = new System.Windows.Forms.TextBox();
            this.lblInvoiceEdit = new System.Windows.Forms.Label();
            this.lblAttachmentsEdit = new System.Windows.Forms.Label();
            this.txtPriceEdit = new System.Windows.Forms.TextBox();
            this.lblPriceEdit = new System.Windows.Forms.Label();
            this.dateEdit = new System.Windows.Forms.DateTimePicker();
            this.lblDateEdit = new System.Windows.Forms.Label();
            this.txtSpareEdit = new System.Windows.Forms.TextBox();
            this.lblSpareEdit = new System.Windows.Forms.Label();
            this.lblAssetsMaintanceEdit = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAssetsID = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.dltbutton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtVehicleIDEdit = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAttachEdit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(828, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 91);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantityEdit
            // 
            this.txtQuantityEdit.Location = new System.Drawing.Point(282, 101);
            this.txtQuantityEdit.Name = "txtQuantityEdit";
            this.txtQuantityEdit.Size = new System.Drawing.Size(306, 29);
            this.txtQuantityEdit.TabIndex = 36;
            // 
            // lblQuantityNew
            // 
            this.lblQuantityNew.AutoSize = true;
            this.lblQuantityNew.Location = new System.Drawing.Point(52, 104);
            this.lblQuantityNew.Name = "lblQuantityNew";
            this.lblQuantityNew.Size = new System.Drawing.Size(85, 22);
            this.lblQuantityNew.TabIndex = 35;
            this.lblQuantityNew.Text = "Quantity";
            this.lblQuantityNew.Click += new System.EventHandler(this.lblQuantityNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(282, 288);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 33);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.Asynchronous = true;
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher4
            // 
            this.directorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher5
            // 
            this.directorySearcher5.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher6
            // 
            this.directorySearcher6.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher6.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher6.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher7
            // 
            this.directorySearcher7.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher7.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher7.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher8
            // 
            this.directorySearcher8.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher8.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher8.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher9
            // 
            this.directorySearcher9.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher9.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher9.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher10
            // 
            this.directorySearcher10.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher10.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher10.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher11
            // 
            this.directorySearcher11.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher11.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher11.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher12
            // 
            this.directorySearcher12.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher12.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher12.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher13
            // 
            this.directorySearcher13.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher13.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher13.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher14
            // 
            this.directorySearcher14.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher14.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher14.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher15
            // 
            this.directorySearcher15.Asynchronous = true;
            this.directorySearcher15.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher15.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher15.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher16
            // 
            this.directorySearcher16.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher16.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher16.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher17
            // 
            this.directorySearcher17.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher17.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher17.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnClearEdit
            // 
            this.btnClearEdit.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnClearEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearEdit.Location = new System.Drawing.Point(1039, 591);
            this.btnClearEdit.Name = "btnClearEdit";
            this.btnClearEdit.Size = new System.Drawing.Size(168, 91);
            this.btnClearEdit.TabIndex = 52;
            this.btnClearEdit.Text = "Clear";
            this.btnClearEdit.UseVisualStyleBackColor = false;
            this.btnClearEdit.Click += new System.EventHandler(this.btnClearEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.txtOwnContactEdit);
            this.groupBox2.Controls.Add(this.txtOwnerEdit);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblOwnerContactNoEdit);
            this.groupBox2.Controls.Add(this.lblOwnerNameEdit);
            this.groupBox2.Controls.Add(this.lblEmailEdit);
            this.groupBox2.Controls.Add(this.lblContactNoEdit);
            this.groupBox2.Controls.Add(this.txtAddressEdit);
            this.groupBox2.Controls.Add(this.txtContactNoEdit);
            this.groupBox2.Controls.Add(this.lblAddressEdit);
            this.groupBox2.Controls.Add(this.txtShopNameEdit);
            this.groupBox2.Controls.Add(this.lblShopNameEdit);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(855, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 421);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchased shop Details";
            // 
            // txtOwnContactEdit
            // 
            this.txtOwnContactEdit.Location = new System.Drawing.Point(242, 339);
            this.txtOwnContactEdit.Name = "txtOwnContactEdit";
            this.txtOwnContactEdit.Size = new System.Drawing.Size(214, 29);
            this.txtOwnContactEdit.TabIndex = 43;
            // 
            // txtOwnerEdit
            // 
            this.txtOwnerEdit.Location = new System.Drawing.Point(242, 269);
            this.txtOwnerEdit.Name = "txtOwnerEdit";
            this.txtOwnerEdit.Size = new System.Drawing.Size(214, 29);
            this.txtOwnerEdit.TabIndex = 42;
            this.txtOwnerEdit.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(242, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 29);
            this.txtEmail.TabIndex = 41;
            // 
            // lblOwnerContactNoEdit
            // 
            this.lblOwnerContactNoEdit.AutoSize = true;
            this.lblOwnerContactNoEdit.Location = new System.Drawing.Point(6, 346);
            this.lblOwnerContactNoEdit.Name = "lblOwnerContactNoEdit";
            this.lblOwnerContactNoEdit.Size = new System.Drawing.Size(211, 22);
            this.lblOwnerContactNoEdit.TabIndex = 40;
            this.lblOwnerContactNoEdit.Text = "Owner contact Number";
            // 
            // lblOwnerNameEdit
            // 
            this.lblOwnerNameEdit.AutoSize = true;
            this.lblOwnerNameEdit.Location = new System.Drawing.Point(6, 272);
            this.lblOwnerNameEdit.Name = "lblOwnerNameEdit";
            this.lblOwnerNameEdit.Size = new System.Drawing.Size(120, 22);
            this.lblOwnerNameEdit.TabIndex = 39;
            this.lblOwnerNameEdit.Text = "Owner name";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.Location = new System.Drawing.Point(6, 212);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(60, 22);
            this.lblEmailEdit.TabIndex = 38;
            this.lblEmailEdit.Text = "Email";
            // 
            // lblContactNoEdit
            // 
            this.lblContactNoEdit.AutoSize = true;
            this.lblContactNoEdit.Location = new System.Drawing.Point(6, 150);
            this.lblContactNoEdit.Name = "lblContactNoEdit";
            this.lblContactNoEdit.Size = new System.Drawing.Size(151, 22);
            this.lblContactNoEdit.TabIndex = 37;
            this.lblContactNoEdit.Text = "Contact Number";
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Location = new System.Drawing.Point(242, 90);
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(214, 29);
            this.txtAddressEdit.TabIndex = 36;
            // 
            // txtContactNoEdit
            // 
            this.txtContactNoEdit.Location = new System.Drawing.Point(242, 145);
            this.txtContactNoEdit.Name = "txtContactNoEdit";
            this.txtContactNoEdit.Size = new System.Drawing.Size(214, 29);
            this.txtContactNoEdit.TabIndex = 35;
            // 
            // lblAddressEdit
            // 
            this.lblAddressEdit.AutoSize = true;
            this.lblAddressEdit.Location = new System.Drawing.Point(6, 90);
            this.lblAddressEdit.Name = "lblAddressEdit";
            this.lblAddressEdit.Size = new System.Drawing.Size(81, 22);
            this.lblAddressEdit.TabIndex = 34;
            this.lblAddressEdit.Text = "Address";
            // 
            // txtShopNameEdit
            // 
            this.txtShopNameEdit.Location = new System.Drawing.Point(242, 28);
            this.txtShopNameEdit.Name = "txtShopNameEdit";
            this.txtShopNameEdit.Size = new System.Drawing.Size(214, 29);
            this.txtShopNameEdit.TabIndex = 33;
            // 
            // lblShopNameEdit
            // 
            this.lblShopNameEdit.AutoSize = true;
            this.lblShopNameEdit.Location = new System.Drawing.Point(6, 33);
            this.lblShopNameEdit.Name = "lblShopNameEdit";
            this.lblShopNameEdit.Size = new System.Drawing.Size(104, 22);
            this.lblShopNameEdit.TabIndex = 33;
            this.lblShopNameEdit.Text = "shop name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.picBoxAttachEdit);
            this.groupBox1.Controls.Add(this.txtQuantityEdit);
            this.groupBox1.Controls.Add(this.lblQuantityNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dateIssuedEdit);
            this.groupBox1.Controls.Add(this.lblIssuedDate);
            this.groupBox1.Controls.Add(this.txtInvoiceNumberEdit);
            this.groupBox1.Controls.Add(this.lblInvoiceEdit);
            this.groupBox1.Controls.Add(this.lblAttachmentsEdit);
            this.groupBox1.Controls.Add(this.txtPriceEdit);
            this.groupBox1.Controls.Add(this.lblPriceEdit);
            this.groupBox1.Controls.Add(this.dateEdit);
            this.groupBox1.Controls.Add(this.lblDateEdit);
            this.groupBox1.Controls.Add(this.txtSpareEdit);
            this.groupBox1.Controls.Add(this.lblSpareEdit);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 598);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spare Parts Details";
            // 
            // picBoxAttachEdit
            // 
            this.picBoxAttachEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAttachEdit.Location = new System.Drawing.Point(282, 317);
            this.picBoxAttachEdit.Name = "picBoxAttachEdit";
            this.picBoxAttachEdit.Size = new System.Drawing.Size(306, 147);
            this.picBoxAttachEdit.TabIndex = 37;
            this.picBoxAttachEdit.TabStop = false;
            this.picBoxAttachEdit.Visible = false;
            // 
            // dateIssuedEdit
            // 
            this.dateIssuedEdit.Location = new System.Drawing.Point(282, 554);
            this.dateIssuedEdit.Name = "dateIssuedEdit";
            this.dateIssuedEdit.Size = new System.Drawing.Size(306, 29);
            this.dateIssuedEdit.TabIndex = 32;
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(52, 554);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(111, 22);
            this.lblIssuedDate.TabIndex = 31;
            this.lblIssuedDate.Text = "Issued Date";
            this.lblIssuedDate.Click += new System.EventHandler(this.lblIssuedDate_Click);
            // 
            // txtInvoiceNumberEdit
            // 
            this.txtInvoiceNumberEdit.Location = new System.Drawing.Point(282, 495);
            this.txtInvoiceNumberEdit.Name = "txtInvoiceNumberEdit";
            this.txtInvoiceNumberEdit.Size = new System.Drawing.Size(306, 29);
            this.txtInvoiceNumberEdit.TabIndex = 30;
            // 
            // lblInvoiceEdit
            // 
            this.lblInvoiceEdit.AutoSize = true;
            this.lblInvoiceEdit.Location = new System.Drawing.Point(52, 498);
            this.lblInvoiceEdit.Name = "lblInvoiceEdit";
            this.lblInvoiceEdit.Size = new System.Drawing.Size(147, 22);
            this.lblInvoiceEdit.TabIndex = 29;
            this.lblInvoiceEdit.Text = "Invoice Number";
            // 
            // lblAttachmentsEdit
            // 
            this.lblAttachmentsEdit.AutoSize = true;
            this.lblAttachmentsEdit.Location = new System.Drawing.Point(52, 299);
            this.lblAttachmentsEdit.Name = "lblAttachmentsEdit";
            this.lblAttachmentsEdit.Size = new System.Drawing.Size(130, 22);
            this.lblAttachmentsEdit.TabIndex = 27;
            this.lblAttachmentsEdit.Text = "Attachments -";
            this.lblAttachmentsEdit.Visible = false;
            this.lblAttachmentsEdit.Click += new System.EventHandler(this.lblAttachmentsEdit_Click);
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(282, 226);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(306, 29);
            this.txtPriceEdit.TabIndex = 26;
            this.txtPriceEdit.TextChanged += new System.EventHandler(this.txtPriceEdit_TextChanged);
            // 
            // lblPriceEdit
            // 
            this.lblPriceEdit.AutoSize = true;
            this.lblPriceEdit.Location = new System.Drawing.Point(52, 226);
            this.lblPriceEdit.Name = "lblPriceEdit";
            this.lblPriceEdit.Size = new System.Drawing.Size(56, 22);
            this.lblPriceEdit.TabIndex = 25;
            this.lblPriceEdit.Text = "Price";
            // 
            // dateEdit
            // 
            this.dateEdit.Location = new System.Drawing.Point(282, 159);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Size = new System.Drawing.Size(306, 29);
            this.dateEdit.TabIndex = 22;
            // 
            // lblDateEdit
            // 
            this.lblDateEdit.AutoSize = true;
            this.lblDateEdit.Location = new System.Drawing.Point(52, 165);
            this.lblDateEdit.Name = "lblDateEdit";
            this.lblDateEdit.Size = new System.Drawing.Size(50, 22);
            this.lblDateEdit.TabIndex = 21;
            this.lblDateEdit.Text = "Date";
            // 
            // txtSpareEdit
            // 
            this.txtSpareEdit.Location = new System.Drawing.Point(282, 42);
            this.txtSpareEdit.Name = "txtSpareEdit";
            this.txtSpareEdit.Size = new System.Drawing.Size(306, 29);
            this.txtSpareEdit.TabIndex = 19;
            // 
            // lblSpareEdit
            // 
            this.lblSpareEdit.AutoSize = true;
            this.lblSpareEdit.Location = new System.Drawing.Point(52, 45);
            this.lblSpareEdit.Name = "lblSpareEdit";
            this.lblSpareEdit.Size = new System.Drawing.Size(196, 22);
            this.lblSpareEdit.TabIndex = 20;
            this.lblSpareEdit.Text = "Puchased spare parts";
            // 
            // lblAssetsMaintanceEdit
            // 
            this.lblAssetsMaintanceEdit.AutoSize = true;
            this.lblAssetsMaintanceEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAssetsMaintanceEdit.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetsMaintanceEdit.Location = new System.Drawing.Point(104, 33);
            this.lblAssetsMaintanceEdit.Name = "lblAssetsMaintanceEdit";
            this.lblAssetsMaintanceEdit.Size = new System.Drawing.Size(332, 27);
            this.lblAssetsMaintanceEdit.TabIndex = 47;
            this.lblAssetsMaintanceEdit.Text = "Assets maintanance ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAssetsID);
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Location = new System.Drawing.Point(474, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 25);
            this.panel1.TabIndex = 53;
            // 
            // txtAssetsID
            // 
            this.txtAssetsID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAssetsID.Location = new System.Drawing.Point(0, 0);
            this.txtAssetsID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssetsID.MaxLength = 223;
            this.txtAssetsID.Name = "txtAssetsID";
            this.txtAssetsID.Size = new System.Drawing.Size(296, 22);
            this.txtAssetsID.TabIndex = 33;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(297, 0);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(27, 25);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 36;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // dltbutton
            // 
            this.dltbutton.BackColor = System.Drawing.SystemColors.InfoText;
            this.dltbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dltbutton.Location = new System.Drawing.Point(1238, 591);
            this.dltbutton.Name = "dltbutton";
            this.dltbutton.Size = new System.Drawing.Size(168, 91);
            this.dltbutton.TabIndex = 54;
            this.dltbutton.Text = "Delete";
            this.dltbutton.UseVisualStyleBackColor = false;
            this.dltbutton.Click += new System.EventHandler(this.dltbutton_Click);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVehicleID.Location = new System.Drawing.Point(867, 31);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(132, 29);
            this.lblVehicleID.TabIndex = 55;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // txtVehicleIDEdit
            // 
            this.txtVehicleIDEdit.Location = new System.Drawing.Point(1025, 31);
            this.txtVehicleIDEdit.Name = "txtVehicleIDEdit";
            this.txtVehicleIDEdit.Size = new System.Drawing.Size(257, 22);
            this.txtVehicleIDEdit.TabIndex = 56;
            // 
            // AssetsUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtVehicleIDEdit);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.dltbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClearEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAssetsMaintanceEdit);
            this.Name = "AssetsUIEdit";
            this.Size = new System.Drawing.Size(1431, 736);
            this.Load += new System.EventHandler(this.AssetsUIEdit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAttachEdit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantityEdit;
        private System.Windows.Forms.Label lblQuantityNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.DirectoryServices.DirectorySearcher directorySearcher4;
        private System.DirectoryServices.DirectorySearcher directorySearcher5;
        private System.DirectoryServices.DirectorySearcher directorySearcher6;
        private System.DirectoryServices.DirectorySearcher directorySearcher7;
        private System.DirectoryServices.DirectorySearcher directorySearcher8;
        private System.DirectoryServices.DirectorySearcher directorySearcher9;
        private System.DirectoryServices.DirectorySearcher directorySearcher10;
        private System.DirectoryServices.DirectorySearcher directorySearcher11;
        private System.DirectoryServices.DirectorySearcher directorySearcher12;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher13;
        private System.DirectoryServices.DirectorySearcher directorySearcher14;
        private System.DirectoryServices.DirectorySearcher directorySearcher15;
        private System.DirectoryServices.DirectorySearcher directorySearcher16;
        private System.DirectoryServices.DirectorySearcher directorySearcher17;
        private System.Windows.Forms.Button btnClearEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOwnContactEdit;
        private System.Windows.Forms.TextBox txtOwnerEdit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOwnerContactNoEdit;
        private System.Windows.Forms.Label lblOwnerNameEdit;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.Label lblContactNoEdit;
        private System.Windows.Forms.TextBox txtAddressEdit;
        private System.Windows.Forms.TextBox txtContactNoEdit;
        private System.Windows.Forms.Label lblAddressEdit;
        private System.Windows.Forms.TextBox txtShopNameEdit;
        private System.Windows.Forms.Label lblShopNameEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateIssuedEdit;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.TextBox txtInvoiceNumberEdit;
        private System.Windows.Forms.Label lblInvoiceEdit;
        private System.Windows.Forms.Label lblAttachmentsEdit;
        private System.Windows.Forms.TextBox txtPriceEdit;
        private System.Windows.Forms.Label lblPriceEdit;
        private System.Windows.Forms.DateTimePicker dateEdit;
        private System.Windows.Forms.Label lblDateEdit;
        private System.Windows.Forms.TextBox txtSpareEdit;
        private System.Windows.Forms.Label lblSpareEdit;
        private System.Windows.Forms.Label lblAssetsMaintanceEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picBoxAttachEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAssetsID;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Button dltbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtVehicleIDEdit;
    }
}
