namespace WindowsFormsApp3
{
    partial class PayrollUIGenerateSalaryChangeValues
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
            this.btnSetAllowance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddAllowance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.payrollUISetAllowance1 = new WindowsFormsApp3.PayrollUISetAllowance();
            this.payrollUIAddAllowance1 = new WindowsFormsApp3.PayrollUIAddAllowance();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddAllowance);
            this.panel1.Controls.Add(this.btnSetAllowance);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnSetAllowance
            // 
            this.btnSetAllowance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetAllowance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSetAllowance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetAllowance.BorderRadius = 0;
            this.btnSetAllowance.ButtonText = "Set Allowance";
            this.btnSetAllowance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetAllowance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetAllowance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetAllowance.Iconimage = null;
            this.btnSetAllowance.Iconimage_right = null;
            this.btnSetAllowance.Iconimage_right_Selected = null;
            this.btnSetAllowance.Iconimage_Selected = null;
            this.btnSetAllowance.IconZoom = 90D;
            this.btnSetAllowance.IsTab = false;
            this.btnSetAllowance.Location = new System.Drawing.Point(0, 0);
            this.btnSetAllowance.Name = "btnSetAllowance";
            this.btnSetAllowance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSetAllowance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSetAllowance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetAllowance.selected = false;
            this.btnSetAllowance.Size = new System.Drawing.Size(125, 67);
            this.btnSetAllowance.TabIndex = 0;
            this.btnSetAllowance.Textcolor = System.Drawing.Color.White;
            this.btnSetAllowance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAllowance.Click += new System.EventHandler(this.btnSetAllowance_Click);
            // 
            // btnAddAllowance
            // 
            this.btnAddAllowance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAllowance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddAllowance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAllowance.BorderRadius = 0;
            this.btnAddAllowance.ButtonText = "Add Allowance";
            this.btnAddAllowance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAllowance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddAllowance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAllowance.Iconimage = null;
            this.btnAddAllowance.Iconimage_right = null;
            this.btnAddAllowance.Iconimage_right_Selected = null;
            this.btnAddAllowance.Iconimage_Selected = null;
            this.btnAddAllowance.IconZoom = 90D;
            this.btnAddAllowance.IsTab = false;
            this.btnAddAllowance.Location = new System.Drawing.Point(125, 0);
            this.btnAddAllowance.Name = "btnAddAllowance";
            this.btnAddAllowance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddAllowance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddAllowance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddAllowance.selected = false;
            this.btnAddAllowance.Size = new System.Drawing.Size(123, 67);
            this.btnAddAllowance.TabIndex = 1;
            this.btnAddAllowance.Textcolor = System.Drawing.Color.White;
            this.btnAddAllowance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllowance.Click += new System.EventHandler(this.btnAddAllowance_Click);
            // 
            // payrollUISetAllowance1
            // 
            this.payrollUISetAllowance1.Location = new System.Drawing.Point(1, 70);
            this.payrollUISetAllowance1.Name = "payrollUISetAllowance1";
            this.payrollUISetAllowance1.Size = new System.Drawing.Size(828, 342);
            this.payrollUISetAllowance1.TabIndex = 1;
            // 
            // payrollUIAddAllowance1
            // 
            this.payrollUIAddAllowance1.Location = new System.Drawing.Point(1, 70);
            this.payrollUIAddAllowance1.Name = "payrollUIAddAllowance1";
            this.payrollUIAddAllowance1.Size = new System.Drawing.Size(828, 342);
            this.payrollUIAddAllowance1.TabIndex = 2;
            // 
            // PayrollUIGenerateSalaryChangeValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 406);
            this.Controls.Add(this.payrollUIAddAllowance1);
            this.Controls.Add(this.payrollUISetAllowance1);
            this.Controls.Add(this.panel1);
            this.Name = "PayrollUIGenerateSalaryChangeValues";
            this.Text = "PayrollUIGenerateSalaryChangeValues";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAllowance;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetAllowance;
        private PayrollUISetAllowance payrollUISetAllowance1;
        private PayrollUIAddAllowance payrollUIAddAllowance1;
    }
}