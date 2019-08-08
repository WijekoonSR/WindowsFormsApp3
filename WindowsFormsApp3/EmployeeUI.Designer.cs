namespace WindowsFormsApp3
{
    partial class EmployeeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUI));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewOperator = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditOperator = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEmployeeView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employeeUINewOperator1 = new WindowsFormsApp3.EmployeeUINewOperator();
            this.employeeUINewStaff1 = new WindowsFormsApp3.EmployeeUINewStaff();
            this.employeeUIEditOperator1 = new WindowsFormsApp3.EmployeeUIEditOperator();
            this.employeeUIEditStaff1 = new WindowsFormsApp3.EmployeeUIEditStaff();
            this.employeeUIView1 = new WindowsFormsApp3.EmployeeUIView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 63);
            this.panel4.TabIndex = 4;
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.GhostWhite;
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUpper.Location = new System.Drawing.Point(141, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1, 63);
            this.panelUpper.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.GhostWhite;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(262, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 63);
            this.panel8.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GhostWhite;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(393, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 63);
            this.panel7.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnEmployeeView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnEditOperator);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnNewStaff);
            this.panel1.Controls.Add(this.panelUpper);
            this.panel1.Controls.Add(this.btnNewOperator);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnNewOperator
            // 
            this.btnNewOperator.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewOperator.BorderRadius = 0;
            this.btnNewOperator.ButtonText = "New Operator";
            this.btnNewOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewOperator.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewOperator.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewOperator.Iconimage")));
            this.btnNewOperator.Iconimage_right = null;
            this.btnNewOperator.Iconimage_right_Selected = null;
            this.btnNewOperator.Iconimage_Selected = null;
            this.btnNewOperator.IconZoom = 34D;
            this.btnNewOperator.IsTab = false;
            this.btnNewOperator.Location = new System.Drawing.Point(1, 0);
            this.btnNewOperator.Name = "btnNewOperator";
            this.btnNewOperator.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewOperator.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnNewOperator.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewOperator.selected = false;
            this.btnNewOperator.Size = new System.Drawing.Size(140, 63);
            this.btnNewOperator.TabIndex = 5;
            this.btnNewOperator.Textcolor = System.Drawing.Color.Black;
            this.btnNewOperator.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOperator.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewStaff.BorderRadius = 0;
            this.btnNewStaff.ButtonText = "New Staff";
            this.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewStaff.Iconimage")));
            this.btnNewStaff.Iconimage_right = null;
            this.btnNewStaff.Iconimage_right_Selected = null;
            this.btnNewStaff.Iconimage_Selected = null;
            this.btnNewStaff.IconZoom = 34D;
            this.btnNewStaff.IsTab = false;
            this.btnNewStaff.Location = new System.Drawing.Point(142, 0);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNewStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnNewStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewStaff.selected = false;
            this.btnNewStaff.Size = new System.Drawing.Size(120, 63);
            this.btnNewStaff.TabIndex = 8;
            this.btnNewStaff.Textcolor = System.Drawing.Color.Black;
            this.btnNewStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnEditOperator
            // 
            this.btnEditOperator.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOperator.BorderRadius = 0;
            this.btnEditOperator.ButtonText = "Edit Operator";
            this.btnEditOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditOperator.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditOperator.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditOperator.Iconimage")));
            this.btnEditOperator.Iconimage_right = null;
            this.btnEditOperator.Iconimage_right_Selected = null;
            this.btnEditOperator.Iconimage_Selected = null;
            this.btnEditOperator.IconZoom = 34D;
            this.btnEditOperator.IsTab = false;
            this.btnEditOperator.Location = new System.Drawing.Point(263, 0);
            this.btnEditOperator.Name = "btnEditOperator";
            this.btnEditOperator.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditOperator.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnEditOperator.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditOperator.selected = false;
            this.btnEditOperator.Size = new System.Drawing.Size(130, 63);
            this.btnEditOperator.TabIndex = 12;
            this.btnEditOperator.Textcolor = System.Drawing.Color.Black;
            this.btnEditOperator.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOperator.Click += new System.EventHandler(this.btnEditOperator_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditStaff.BorderRadius = 0;
            this.btnEditStaff.ButtonText = "Edit Staff";
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditStaff.Iconimage")));
            this.btnEditStaff.Iconimage_right = null;
            this.btnEditStaff.Iconimage_right_Selected = null;
            this.btnEditStaff.Iconimage_Selected = null;
            this.btnEditStaff.IconZoom = 34D;
            this.btnEditStaff.IsTab = false;
            this.btnEditStaff.Location = new System.Drawing.Point(394, 0);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEditStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnEditStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditStaff.selected = false;
            this.btnEditStaff.Size = new System.Drawing.Size(120, 63);
            this.btnEditStaff.TabIndex = 14;
            this.btnEditStaff.Textcolor = System.Drawing.Color.Black;
            this.btnEditStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(514, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 63);
            this.panel2.TabIndex = 15;
            // 
            // btnEmployeeView
            // 
            this.btnEmployeeView.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEmployeeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEmployeeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeView.BorderRadius = 0;
            this.btnEmployeeView.ButtonText = "   View   ";
            this.btnEmployeeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployeeView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployeeView.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeView.Iconimage")));
            this.btnEmployeeView.Iconimage_right = null;
            this.btnEmployeeView.Iconimage_right_Selected = null;
            this.btnEmployeeView.Iconimage_Selected = null;
            this.btnEmployeeView.IconZoom = 34D;
            this.btnEmployeeView.IsTab = false;
            this.btnEmployeeView.Location = new System.Drawing.Point(515, 0);
            this.btnEmployeeView.Name = "btnEmployeeView";
            this.btnEmployeeView.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEmployeeView.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnEmployeeView.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployeeView.selected = false;
            this.btnEmployeeView.Size = new System.Drawing.Size(120, 63);
            this.btnEmployeeView.TabIndex = 16;
            this.btnEmployeeView.Textcolor = System.Drawing.Color.Black;
            this.btnEmployeeView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeView.Click += new System.EventHandler(this.btnEmployeeView_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(635, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 63);
            this.panel3.TabIndex = 17;
            // 
            // employeeUINewOperator1
            // 
            this.employeeUINewOperator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUINewOperator1.Location = new System.Drawing.Point(0, 63);
            this.employeeUINewOperator1.Name = "employeeUINewOperator1";
            this.employeeUINewOperator1.Size = new System.Drawing.Size(1069, 585);
            this.employeeUINewOperator1.TabIndex = 5;
            // 
            // employeeUINewStaff1
            // 
            this.employeeUINewStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUINewStaff1.Location = new System.Drawing.Point(0, 63);
            this.employeeUINewStaff1.Name = "employeeUINewStaff1";
            this.employeeUINewStaff1.Size = new System.Drawing.Size(1069, 585);
            this.employeeUINewStaff1.TabIndex = 6;
            // 
            // employeeUIEditOperator1
            // 
            this.employeeUIEditOperator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUIEditOperator1.Location = new System.Drawing.Point(0, 63);
            this.employeeUIEditOperator1.Name = "employeeUIEditOperator1";
            this.employeeUIEditOperator1.Size = new System.Drawing.Size(1069, 585);
            this.employeeUIEditOperator1.TabIndex = 7;
            // 
            // employeeUIEditStaff1
            // 
            this.employeeUIEditStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUIEditStaff1.Location = new System.Drawing.Point(0, 63);
            this.employeeUIEditStaff1.Name = "employeeUIEditStaff1";
            this.employeeUIEditStaff1.Size = new System.Drawing.Size(1069, 585);
            this.employeeUIEditStaff1.TabIndex = 8;
            // 
            // employeeUIView1
            // 
            this.employeeUIView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUIView1.Location = new System.Drawing.Point(0, 63);
            this.employeeUIView1.Name = "employeeUIView1";
            this.employeeUIView1.Size = new System.Drawing.Size(1069, 585);
            this.employeeUIView1.TabIndex = 9;
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.employeeUIView1);
            this.Controls.Add(this.employeeUIEditStaff1);
            this.Controls.Add(this.employeeUIEditOperator1);
            this.Controls.Add(this.employeeUINewStaff1);
            this.Controls.Add(this.employeeUINewOperator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeUI";
            this.Size = new System.Drawing.Size(1069, 648);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployeeView;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditOperator;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewOperator;
        private EmployeeUINewOperator employeeUINewOperator1;
        private EmployeeUINewStaff employeeUINewStaff1;
        private EmployeeUIEditOperator employeeUIEditOperator1;
        private EmployeeUIEditStaff employeeUIEditStaff1;
        private EmployeeUIView employeeUIView1;
    }
}
