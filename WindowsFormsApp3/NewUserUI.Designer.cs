namespace WindowsFormsApp3
{
    partial class NewUserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAddPrfPic = new System.Windows.Forms.Button();
            this.lblAddProfPic = new System.Windows.Forms.Label();
            this.TxtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtReEnterPW = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblReEnterPW = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnAddPrfPic);
            this.panel1.Controls.Add(this.lblAddProfPic);
            this.panel1.Controls.Add(this.TxtEmployeeID);
            this.panel1.Controls.Add(this.lblEmployeeID);
            this.panel1.Controls.Add(this.txtReEnterPW);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.lblReEnterPW);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 439);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(239, 108);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 25;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(179, 111);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(54, 13);
            this.lblFName.TabIndex = 24;
            this.lblFName.Text = "File Name";
            this.lblFName.Click += new System.EventHandler(this.lblFName_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(138, 367);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(115, 30);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);
            // 
            // btnAddPrfPic
            // 
            this.btnAddPrfPic.Location = new System.Drawing.Point(178, 52);
            this.btnAddPrfPic.Name = "btnAddPrfPic";
            this.btnAddPrfPic.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrfPic.TabIndex = 22;
            this.btnAddPrfPic.Text = "Add Picture";
            this.btnAddPrfPic.UseVisualStyleBackColor = true;
            this.btnAddPrfPic.Click += new System.EventHandler(this.btnAddPrfPic_Click);
            // 
            // lblAddProfPic
            // 
            this.lblAddProfPic.AutoSize = true;
            this.lblAddProfPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProfPic.Location = new System.Drawing.Point(97, 20);
            this.lblAddProfPic.Name = "lblAddProfPic";
            this.lblAddProfPic.Size = new System.Drawing.Size(164, 20);
            this.lblAddProfPic.TabIndex = 21;
            this.lblAddProfPic.Text = "Welcome New User";
            this.lblAddProfPic.Click += new System.EventHandler(this.lblAddProfPic_Click);
            // 
            // TxtEmployeeID
            // 
            this.TxtEmployeeID.Location = new System.Drawing.Point(168, 218);
            this.TxtEmployeeID.Name = "TxtEmployeeID";
            this.TxtEmployeeID.Size = new System.Drawing.Size(147, 20);
            this.TxtEmployeeID.TabIndex = 19;
            this.TxtEmployeeID.TextChanged += new System.EventHandler(this.TxtEmployeeID_TextChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(49, 225);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 18;
            this.lblEmployeeID.Text = "Employee ID";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // txtReEnterPW
            // 
            this.txtReEnterPW.Location = new System.Drawing.Point(168, 311);
            this.txtReEnterPW.Name = "txtReEnterPW";
            this.txtReEnterPW.Size = new System.Drawing.Size(146, 20);
            this.txtReEnterPW.TabIndex = 17;
            this.txtReEnterPW.TextChanged += new System.EventHandler(this.txtReEnterPW_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 265);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(168, 175);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(146, 20);
            this.txtUserID.TabIndex = 15;
            // 
            // lblReEnterPW
            // 
            this.lblReEnterPW.AutoSize = true;
            this.lblReEnterPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPW.Location = new System.Drawing.Point(49, 316);
            this.lblReEnterPW.Name = "lblReEnterPW";
            this.lblReEnterPW.Size = new System.Drawing.Size(113, 15);
            this.lblReEnterPW.TabIndex = 14;
            this.lblReEnterPW.Text = "Re-Enter Password";
            this.lblReEnterPW.Click += new System.EventHandler(this.lblReEnterPW_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(49, 266);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(49, 176);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 15);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User ID";
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo.Location = new System.Drawing.Point(179, 82);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(220, 13);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Please Enter File Name For Uploaded Picture";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(62, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 109);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 109);
            this.panel3.TabIndex = 35;
            // 
            // picUser
            // 
            this.picUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 109);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 26;
            this.picUser.TabStop = false;
            // 
            // NewUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 439);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.NewUserUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtReEnterPW;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblReEnterPW;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblAddProfPic;
        private System.Windows.Forms.Button btnAddPrfPic;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picUser;
    }
}