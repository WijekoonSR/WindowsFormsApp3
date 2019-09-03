namespace WindowsFormsApp3
{
    partial class NewUserUIPage01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserUIPage01));
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblReEnterPW = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPW = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.newUserUIPage021 = new WindowsFormsApp3.NewUserUIPage02();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.TxtEmployeeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(31, 79);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 15);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(31, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblReEnterPW
            // 
            this.lblReEnterPW.AutoSize = true;
            this.lblReEnterPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPW.Location = new System.Drawing.Point(31, 179);
            this.lblReEnterPW.Name = "lblReEnterPW";
            this.lblReEnterPW.Size = new System.Drawing.Size(113, 15);
            this.lblReEnterPW.TabIndex = 2;
            this.lblReEnterPW.Text = "Re-Enter Password";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(150, 78);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(146, 20);
            this.txtUserID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtReEnterPW
            // 
            this.txtReEnterPW.Location = new System.Drawing.Point(150, 174);
            this.txtReEnterPW.Name = "txtReEnterPW";
            this.txtReEnterPW.Size = new System.Drawing.Size(146, 20);
            this.txtReEnterPW.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(150)))), ((int)(((byte)(196)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(211, 257);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 32);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // newUserUIPage021
            // 
            this.newUserUIPage021.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.newUserUIPage021.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(231)))));
            this.newUserUIPage021.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newUserUIPage021.Location = new System.Drawing.Point(0, 0);
            this.newUserUIPage021.Name = "newUserUIPage021";
            this.newUserUIPage021.Size = new System.Drawing.Size(319, 315);
            this.newUserUIPage021.TabIndex = 8;
            this.newUserUIPage021.Load += new System.EventHandler(this.newUserUIPage021_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(231)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(31, 226);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 10;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // TxtEmployeeID
            // 
            this.TxtEmployeeID.Location = new System.Drawing.Point(150, 219);
            this.TxtEmployeeID.Name = "TxtEmployeeID";
            this.TxtEmployeeID.Size = new System.Drawing.Size(147, 20);
            this.TxtEmployeeID.TabIndex = 11;
            // 
            // NewUserUIPage01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.TxtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtReEnterPW);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblReEnterPW);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.newUserUIPage021);
            this.Name = "NewUserUIPage01";
            this.Size = new System.Drawing.Size(319, 315);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblReEnterPW;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReEnterPW;
        private System.Windows.Forms.Button btnNext;
        private NewUserUIPage02 newUserUIPage021;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox TxtEmployeeID;
    }
}
