namespace Optic.Windows.Master
{
    partial class CreateFrameMaster
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
            this.lblFrameMasterHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtSellRate = new System.Windows.Forms.TextBox();
            this.txtOpBal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrameMasterHeading
            // 
            this.lblFrameMasterHeading.AutoSize = true;
            this.lblFrameMasterHeading.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrameMasterHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFrameMasterHeading.Location = new System.Drawing.Point(45, 34);
            this.lblFrameMasterHeading.Name = "lblFrameMasterHeading";
            this.lblFrameMasterHeading.Size = new System.Drawing.Size(198, 29);
            this.lblFrameMasterHeading.TabIndex = 0;
            this.lblFrameMasterHeading.Text = "Create New Frame";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purchase Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sell Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Op Bal.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Location = new System.Drawing.Point(143, 123);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseRate.TabIndex = 6;
            // 
            // txtSellRate
            // 
            this.txtSellRate.Location = new System.Drawing.Point(143, 153);
            this.txtSellRate.Name = "txtSellRate";
            this.txtSellRate.Size = new System.Drawing.Size(100, 20);
            this.txtSellRate.TabIndex = 7;
            // 
            // txtOpBal
            // 
            this.txtOpBal.Location = new System.Drawing.Point(143, 188);
            this.txtOpBal.Name = "txtOpBal";
            this.txtOpBal.Size = new System.Drawing.Size(100, 20);
            this.txtOpBal.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateFrameMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpBal);
            this.Controls.Add(this.txtSellRate);
            this.Controls.Add(this.txtPurchaseRate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFrameMasterHeading);
            this.Name = "CreateFrameMaster";
            this.Text = "New Frame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrameMasterHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtSellRate;
        private System.Windows.Forms.TextBox txtOpBal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}