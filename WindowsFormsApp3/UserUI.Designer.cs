namespace WindowsFormsApp3
{
    partial class UserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userUIView1 = new WindowsFormsApp3.UserUIView();
            this.userUIEdit1 = new WindowsFormsApp3.UserUIEdit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userUIEdit1);
            this.panel1.Controls.Add(this.userUIView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 355);
            this.panel1.TabIndex = 0;
            // 
            // userUIView1
            // 
            this.userUIView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userUIView1.Location = new System.Drawing.Point(0, 0);
            this.userUIView1.Name = "userUIView1";
            this.userUIView1.Size = new System.Drawing.Size(254, 355);
            this.userUIView1.TabIndex = 0;
            // 
            // userUIEdit1
            // 
            this.userUIEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userUIEdit1.Location = new System.Drawing.Point(0, 0);
            this.userUIEdit1.Name = "userUIEdit1";
            this.userUIEdit1.Size = new System.Drawing.Size(254, 355);
            this.userUIEdit1.TabIndex = 1;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 355);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.UserNewUI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserUIEdit userUIEdit1;
        private UserUIView userUIView1;
    }
}