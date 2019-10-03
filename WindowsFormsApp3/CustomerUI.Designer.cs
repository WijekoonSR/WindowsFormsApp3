﻿namespace WindowsFormsApp3
{
    partial class CustomerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUI));
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerUINew = new WindowsFormsApp3.CustomerUINew();
            this.customerUIEdit = new WindowsFormsApp3.CustomerUIEdit();
            this.customerUIView = new WindowsFormsApp3.CustomerUIView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.btnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Slider = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerUINew);
            this.panel3.Controls.Add(this.customerUIEdit);
            this.panel3.Controls.Add(this.customerUIView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 585);
            this.panel3.TabIndex = 8;
            // 
            // customerUINew
            // 
            this.customerUINew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerUINew.Location = new System.Drawing.Point(0, 0);
            this.customerUINew.Name = "customerUINew";
            this.customerUINew.Size = new System.Drawing.Size(1069, 585);
            this.customerUINew.TabIndex = 2;
            this.customerUINew.Load += new System.EventHandler(this.customerUINew2_Load);
            // 
            // customerUIEdit
            // 
            this.customerUIEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerUIEdit.Location = new System.Drawing.Point(0, 0);
            this.customerUIEdit.Name = "customerUIEdit";
            this.customerUIEdit.Size = new System.Drawing.Size(1069, 585);
            this.customerUIEdit.TabIndex = 1;
            // 
            // customerUIView
            // 
            this.customerUIView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerUIView.Location = new System.Drawing.Point(0, 0);
            this.customerUIView.Name = "customerUIView";
            this.customerUIView.Size = new System.Drawing.Size(1069, 585);
            this.customerUIView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.panelUpper);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 63);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GhostWhite;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(484, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 63);
            this.panel5.TabIndex = 15;
            // 
            // btnReport
            // 
            this.btnReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.BorderRadius = 0;
            this.btnReport.ButtonText = "Report";
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReport.Iconimage")));
            this.btnReport.Iconimage_right = null;
            this.btnReport.Iconimage_right_Selected = null;
            this.btnReport.Iconimage_Selected = null;
            this.btnReport.IconZoom = 34D;
            this.btnReport.IsTab = false;
            this.btnReport.Location = new System.Drawing.Point(364, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReport.selected = false;
            this.btnReport.Size = new System.Drawing.Size(120, 63);
            this.btnReport.TabIndex = 14;
            this.btnReport.Textcolor = System.Drawing.Color.Black;
            this.btnReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GhostWhite;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(363, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 63);
            this.panel7.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.BorderRadius = 0;
            this.btnView.ButtonText = "   View   ";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnView.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnView.Iconimage")));
            this.btnView.Iconimage_right = null;
            this.btnView.Iconimage_right_Selected = null;
            this.btnView.Iconimage_Selected = null;
            this.btnView.IconZoom = 34D;
            this.btnView.IsTab = false;
            this.btnView.Location = new System.Drawing.Point(243, 0);
            this.btnView.Name = "btnView";
            this.btnView.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnView.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnView.OnHoverTextColor = System.Drawing.Color.White;
            this.btnView.selected = false;
            this.btnView.Size = new System.Drawing.Size(120, 63);
            this.btnView.TabIndex = 12;
            this.btnView.Textcolor = System.Drawing.Color.Black;
            this.btnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.GhostWhite;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(242, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 63);
            this.panel8.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "   Edit   ";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconZoom = 34D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(122, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(120, 63);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Textcolor = System.Drawing.Color.Black;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.GhostWhite;
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUpper.Location = new System.Drawing.Point(121, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1, 63);
            this.panelUpper.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.BorderRadius = 0;
            this.btnNew.ButtonText = "   New   ";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNew.Iconimage")));
            this.btnNew.Iconimage_right = null;
            this.btnNew.Iconimage_right_Selected = null;
            this.btnNew.Iconimage_Selected = null;
            this.btnNew.IconZoom = 34D;
            this.btnNew.IsTab = false;
            this.btnNew.Location = new System.Drawing.Point(1, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.btnNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNew.selected = false;
            this.btnNew.Size = new System.Drawing.Size(120, 63);
            this.btnNew.TabIndex = 5;
            this.btnNew.Textcolor = System.Drawing.Color.Black;
            this.btnNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
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
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.Black;
            this.Slider.Location = new System.Drawing.Point(0, 0);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(121, 3);
            this.Slider.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Slider);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 3);
            this.panel2.TabIndex = 9;
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerUI";
            this.Size = new System.Drawing.Size(1069, 648);
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnView;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.Panel panelUpper;
        private Bunifu.Framework.UI.BunifuFlatButton btnNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Slider;
        private CustomerUIEdit customerUIEdit1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private CustomerUINew customerUINew1;
        private CustomerUIView customerUIView1;
        private CustomerUINew customerUINew;
        private CustomerUIEdit customerUIEdit;
        private CustomerUIView customerUIView;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnReport;
    }
}
