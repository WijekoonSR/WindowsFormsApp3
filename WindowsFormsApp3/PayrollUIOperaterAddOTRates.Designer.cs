namespace WindowsFormsApp3
{
    partial class PayrollUIOperaterAddOTRates
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtAddNewOTRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtAddNewOTRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(238, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 119);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // edtAddNewOTRate
            // 
            this.edtAddNewOTRate.Location = new System.Drawing.Point(126, 39);
            this.edtAddNewOTRate.Name = "edtAddNewOTRate";
            this.edtAddNewOTRate.Size = new System.Drawing.Size(100, 20);
            this.edtAddNewOTRate.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add new OT rate";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // PayrollUIOperaterAddOTRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Name = "PayrollUIOperaterAddOTRates";
            this.Size = new System.Drawing.Size(710, 316);
            this.Load += new System.EventHandler(this.PayrollUIOperaterAddOTRates_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtAddNewOTRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}
