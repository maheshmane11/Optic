namespace Optic.Windows.Master
{
    partial class CreateSunGlassesMaster
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOpBal = new System.Windows.Forms.TextBox();
            this.txtSellRate = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOpBal = new System.Windows.Forms.Label();
            this.lblSellRate = new System.Windows.Forms.Label();
            this.lblPurchaseRate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFrameMasterHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtOpBal
            // 
            this.txtOpBal.Location = new System.Drawing.Point(165, 203);
            this.txtOpBal.Name = "txtOpBal";
            this.txtOpBal.Size = new System.Drawing.Size(100, 20);
            this.txtOpBal.TabIndex = 19;
            // 
            // txtSellRate
            // 
            this.txtSellRate.Location = new System.Drawing.Point(165, 169);
            this.txtSellRate.Name = "txtSellRate";
            this.txtSellRate.Size = new System.Drawing.Size(100, 20);
            this.txtSellRate.TabIndex = 18;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Location = new System.Drawing.Point(165, 136);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseRate.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 16;
            // 
            // lblOpBal
            // 
            this.lblOpBal.AutoSize = true;
            this.lblOpBal.Location = new System.Drawing.Point(55, 210);
            this.lblOpBal.Name = "lblOpBal";
            this.lblOpBal.Size = new System.Drawing.Size(42, 13);
            this.lblOpBal.TabIndex = 15;
            this.lblOpBal.Text = "Op Bal.";
            // 
            // lblSellRate
            // 
            this.lblSellRate.AutoSize = true;
            this.lblSellRate.Location = new System.Drawing.Point(55, 169);
            this.lblSellRate.Name = "lblSellRate";
            this.lblSellRate.Size = new System.Drawing.Size(50, 13);
            this.lblSellRate.TabIndex = 14;
            this.lblSellRate.Text = "Sell Rate";
            // 
            // lblPurchaseRate
            // 
            this.lblPurchaseRate.AutoSize = true;
            this.lblPurchaseRate.Location = new System.Drawing.Point(55, 136);
            this.lblPurchaseRate.Name = "lblPurchaseRate";
            this.lblPurchaseRate.Size = new System.Drawing.Size(78, 13);
            this.lblPurchaseRate.TabIndex = 13;
            this.lblPurchaseRate.Text = "Purchase Rate";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblFrameMasterHeading
            // 
            this.lblFrameMasterHeading.AutoSize = true;
            this.lblFrameMasterHeading.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrameMasterHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFrameMasterHeading.Location = new System.Drawing.Point(53, 23);
            this.lblFrameMasterHeading.Name = "lblFrameMasterHeading";
            this.lblFrameMasterHeading.Size = new System.Drawing.Size(252, 29);
            this.lblFrameMasterHeading.TabIndex = 11;
            this.lblFrameMasterHeading.Text = "Create New Sun Glasses";
            // 
            // CreateSunGlassesMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 299);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpBal);
            this.Controls.Add(this.txtSellRate);
            this.Controls.Add(this.txtPurchaseRate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOpBal);
            this.Controls.Add(this.lblSellRate);
            this.Controls.Add(this.lblPurchaseRate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFrameMasterHeading);
            this.Name = "CreateSunGlassesMaster";
            this.Text = "New Sun Glass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOpBal;
        private System.Windows.Forms.TextBox txtSellRate;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOpBal;
        private System.Windows.Forms.Label lblSellRate;
        private System.Windows.Forms.Label lblPurchaseRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFrameMasterHeading;
    }
}