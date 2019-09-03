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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newUserUIPage011 = new WindowsFormsApp3.NewUserUIPage01();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newUserUIPage011);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 316);
            this.panel1.TabIndex = 0;
            // 
            // newUserUIPage011
            // 
            this.newUserUIPage011.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.newUserUIPage011.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newUserUIPage011.Location = new System.Drawing.Point(0, 0);
            this.newUserUIPage011.Name = "newUserUIPage011";
            this.newUserUIPage011.Size = new System.Drawing.Size(323, 316);
            this.newUserUIPage011.TabIndex = 2;
            // 
            // NewUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 316);
            this.Controls.Add(this.panel1);
            this.Name = "NewUserUI";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NewUserUIPage01 newUserUIPage011;
    }
}