namespace WindowsFormsApp3
{
    partial class CustomerUINew
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtcutomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblFaxNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.lblpjtEmail = new System.Windows.Forms.Label();
            this.txtContactNumber2 = new System.Windows.Forms.TextBox();
            this.lblPjtContactNumber = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblPjtAddress = new System.Windows.Forms.Label();
            this.txtProjectManager = new System.Windows.Forms.TextBox();
            this.lblProjectMgr = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateStartContract = new System.Windows.Forms.DateTimePicker();
            this.dateEndContract = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(66, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtcutomerID
            // 
            this.txtcutomerID.Location = new System.Drawing.Point(151, 27);
            this.txtcutomerID.Name = "txtcutomerID";
            this.txtcutomerID.Size = new System.Drawing.Size(113, 20);
            this.txtcutomerID.TabIndex = 1;
            this.txtcutomerID.TextChanged += new System.EventHandler(this.txtcutomerID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(788, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(655, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtEmail1);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtFaxNumber);
            this.groupBox1.Controls.Add(this.lblFaxNumber);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.lblContactNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 318);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company HeadOffice Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(180, 182);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 20);
            this.txtEmail1.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(180, 226);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFaxNumber.TabIndex = 27;
            // 
            // lblFaxNumber
            // 
            this.lblFaxNumber.AutoSize = true;
            this.lblFaxNumber.Location = new System.Drawing.Point(76, 233);
            this.lblFaxNumber.Name = "lblFaxNumber";
            this.lblFaxNumber.Size = new System.Drawing.Size(64, 13);
            this.lblFaxNumber.TabIndex = 25;
            this.lblFaxNumber.Text = "Fax Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(180, 134);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 20;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(76, 137);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 19;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(180, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(76, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.txtEmail2);
            this.groupBox2.Controls.Add(this.lblpjtEmail);
            this.groupBox2.Controls.Add(this.txtContactNumber2);
            this.groupBox2.Controls.Add(this.lblPjtContactNumber);
            this.groupBox2.Controls.Add(this.txtAddress1);
            this.groupBox2.Controls.Add(this.lblPjtAddress);
            this.groupBox2.Controls.Add(this.txtProjectManager);
            this.groupBox2.Controls.Add(this.lblProjectMgr);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 318);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(175, 182);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(100, 20);
            this.txtEmail2.TabIndex = 19;
            this.txtEmail2.TextChanged += new System.EventHandler(this.txtEmail2_TextChanged);
            // 
            // lblpjtEmail
            // 
            this.lblpjtEmail.AutoSize = true;
            this.lblpjtEmail.Location = new System.Drawing.Point(69, 185);
            this.lblpjtEmail.Name = "lblpjtEmail";
            this.lblpjtEmail.Size = new System.Drawing.Size(32, 13);
            this.lblpjtEmail.TabIndex = 18;
            this.lblpjtEmail.Text = "Email";
            // 
            // txtContactNumber2
            // 
            this.txtContactNumber2.Location = new System.Drawing.Point(175, 136);
            this.txtContactNumber2.Name = "txtContactNumber2";
            this.txtContactNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber2.TabIndex = 17;
            // 
            // lblPjtContactNumber
            // 
            this.lblPjtContactNumber.AutoSize = true;
            this.lblPjtContactNumber.Location = new System.Drawing.Point(66, 136);
            this.lblPjtContactNumber.Name = "lblPjtContactNumber";
            this.lblPjtContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblPjtContactNumber.TabIndex = 16;
            this.lblPjtContactNumber.Text = "Contact Number";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(175, 96);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(100, 20);
            this.txtAddress1.TabIndex = 15;
            // 
            // lblPjtAddress
            // 
            this.lblPjtAddress.AutoSize = true;
            this.lblPjtAddress.Location = new System.Drawing.Point(69, 96);
            this.lblPjtAddress.Name = "lblPjtAddress";
            this.lblPjtAddress.Size = new System.Drawing.Size(45, 13);
            this.lblPjtAddress.TabIndex = 14;
            this.lblPjtAddress.Text = "Address";
            // 
            // txtProjectManager
            // 
            this.txtProjectManager.Location = new System.Drawing.Point(175, 57);
            this.txtProjectManager.Name = "txtProjectManager";
            this.txtProjectManager.Size = new System.Drawing.Size(100, 20);
            this.txtProjectManager.TabIndex = 13;
            // 
            // lblProjectMgr
            // 
            this.lblProjectMgr.AutoSize = true;
            this.lblProjectMgr.Location = new System.Drawing.Point(67, 57);
            this.lblProjectMgr.Name = "lblProjectMgr";
            this.lblProjectMgr.Size = new System.Drawing.Size(85, 13);
            this.lblProjectMgr.TabIndex = 11;
            this.lblProjectMgr.Text = "Project Manager";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(66, 68);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 13);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "Contract Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(467, 62);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(95, 13);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "Contract End Date";
            // 
            // dateStartContract
            // 
            this.dateStartContract.Location = new System.Drawing.Point(180, 62);
            this.dateStartContract.Name = "dateStartContract";
            this.dateStartContract.Size = new System.Drawing.Size(234, 20);
            this.dateStartContract.TabIndex = 20;
            // 
            // dateEndContract
            // 
            this.dateEndContract.Location = new System.Drawing.Point(578, 61);
            this.dateEndContract.Name = "dateEndContract";
            this.dateEndContract.Size = new System.Drawing.Size(200, 20);
            this.dateEndContract.TabIndex = 21;
            // 
            // CustomerUINew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateEndContract);
            this.Controls.Add(this.dateStartContract);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcutomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "CustomerUINew";
            this.Size = new System.Drawing.Size(1069, 582);
            this.Load += new System.EventHandler(this.CustomerUINew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtcutomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtFaxNumber;
        private System.Windows.Forms.Label lblFaxNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblpjtEmail;
        private System.Windows.Forms.TextBox txtContactNumber2;
        private System.Windows.Forms.Label lblPjtContactNumber;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblPjtAddress;
        private System.Windows.Forms.TextBox txtProjectManager;
        private System.Windows.Forms.Label lblProjectMgr;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateStartContract;
        private System.Windows.Forms.DateTimePicker dateEndContract;
        private System.Windows.Forms.TextBox txtEmail2;
    }
}
