namespace WindowsFormsApp3
{
    partial class VehicleLeasingUIAddVehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleLeasingUIAddVehicleDetails));
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEngineType = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtEnginetype = new System.Windows.Forms.TextBox();
            this.btnkOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(112, 158);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(153, 20);
            this.txtFuelType.TabIndex = 0;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(14, 165);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(69, 13);
            this.lblFuelType.TabIndex = 1;
            this.lblFuelType.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacity";
            // 
            // lblEngineType
            // 
            this.lblEngineType.AutoSize = true;
            this.lblEngineType.Location = new System.Drawing.Point(12, 120);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(70, 13);
            this.lblEngineType.TabIndex = 4;
            this.lblEngineType.Text = " Engine Type";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(111, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(153, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(111, 73);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(153, 20);
            this.txtCapacity.TabIndex = 6;
            // 
            // txtEnginetype
            // 
            this.txtEnginetype.Location = new System.Drawing.Point(111, 113);
            this.txtEnginetype.Name = "txtEnginetype";
            this.txtEnginetype.Size = new System.Drawing.Size(153, 20);
            this.txtEnginetype.TabIndex = 7;
            // 
            // btnkOk
            // 
            this.btnkOk.Location = new System.Drawing.Point(102, 211);
            this.btnkOk.Name = "btnkOk";
            this.btnkOk.Size = new System.Drawing.Size(75, 23);
            this.btnkOk.TabIndex = 8;
            this.btnkOk.Text = "Ok";
            this.btnkOk.UseVisualStyleBackColor = true;
            // 
            // VehicleLeasingUIAddVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 262);
            this.Controls.Add(this.btnkOk);
            this.Controls.Add(this.txtEnginetype);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblEngineType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.txtFuelType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleLeasingUIAddVehicleDetails";
            this.Text = "Vehicle Details";
            this.Load += new System.EventHandler(this.VehicleLeasingUIAddVehicleDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtEnginetype;
        private System.Windows.Forms.Button btnkOk;
    }
}