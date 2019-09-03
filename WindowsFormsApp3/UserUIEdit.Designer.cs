namespace WindowsFormsApp3
{
    partial class UserUIEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUIEdit));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReEnterPasword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnChangeUserPic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReEnterPasword
            // 
            this.txtReEnterPasword.Location = new System.Drawing.Point(137, 256);
            this.txtReEnterPasword.Name = "txtReEnterPasword";
            this.txtReEnterPasword.Size = new System.Drawing.Size(100, 20);
            this.txtReEnterPasword.TabIndex = 30;
            this.txtReEnterPasword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(137, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 29;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(137, 184);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 28;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(137, 146);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 27;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(17, 191);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 25;
            this.lblUserID.Text = "User ID";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(17, 263);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(98, 13);
            this.lbUsername.TabIndex = 24;
            this.lbUsername.Text = "Re-Enter Password";
            this.lbUsername.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(17, 153);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 22;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(40, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnChangeUserPic);
            this.panel1.Location = new System.Drawing.Point(31, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 109);
            this.panel1.TabIndex = 33;
            // 
            // picUser
            // 
            this.picUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 86);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 26;
            this.picUser.TabStop = false;
            // 
            // btnChangeUserPic
            // 
            this.btnChangeUserPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangeUserPic.Location = new System.Drawing.Point(0, 86);
            this.btnChangeUserPic.Name = "btnChangeUserPic";
            this.btnChangeUserPic.Size = new System.Drawing.Size(100, 23);
            this.btnChangeUserPic.TabIndex = 34;
            this.btnChangeUserPic.Text = "Change";
            this.btnChangeUserPic.UseVisualStyleBackColor = true;
            this.btnChangeUserPic.Click += new System.EventHandler(this.btnChangeUserPic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 86);
            this.panel2.TabIndex = 35;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(17, 127);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 13);
            this.lblFileName.TabIndex = 34;
            this.lblFileName.Text = "File Name ?";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(93, 118);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(70, 23);
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(137, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(114, 109);
            this.listView.TabIndex = 36;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // UserUIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReEnterPasword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "UserUIEdit";
            this.Size = new System.Drawing.Size(254, 355);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtReEnterPasword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnChangeUserPic;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView listView;
    }
}
