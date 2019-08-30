namespace WindowsFormsApp3
{
    partial class StartUpUI
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
            this.btnExistingUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExistingUser
            // 
            this.btnExistingUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(23)))), ((int)(((byte)(247)))));
            this.btnExistingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExistingUser.Location = new System.Drawing.Point(71, 115);
            this.btnExistingUser.Name = "btnExistingUser";
            this.btnExistingUser.Size = new System.Drawing.Size(291, 50);
            this.btnExistingUser.TabIndex = 25;
            this.btnExistingUser.Text = "Existing User";
            this.btnExistingUser.UseVisualStyleBackColor = false;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(7)))), ((int)(((byte)(254)))));
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewUser.Location = new System.Drawing.Point(71, 41);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(291, 50);
            this.btnNewUser.TabIndex = 24;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = false;
            // 
            // StartUpUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 203);
            this.Controls.Add(this.btnExistingUser);
            this.Controls.Add(this.btnNewUser);
            this.Name = "StartUpUI";
            this.Text = "StartUpUI";
            this.Load += new System.EventHandler(this.StartUpUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExistingUser;
        private System.Windows.Forms.Button btnNewUser;
    }
}