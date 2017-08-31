namespace Optic.Windows.Display
{
    partial class OpticMasterDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlOpticMasters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchMaster = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridDisplayMaster = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Master";
            // 
            // ddlOpticMasters
            // 
            this.ddlOpticMasters.FormattingEnabled = true;
            this.ddlOpticMasters.Location = new System.Drawing.Point(164, 79);
            this.ddlOpticMasters.Name = "ddlOpticMasters";
            this.ddlOpticMasters.Size = new System.Drawing.Size(121, 21);
            this.ddlOpticMasters.TabIndex = 1;
            this.ddlOpticMasters.SelectedIndexChanged += new System.EventHandler(this.ddlOpticMasters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Master";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // txtSearchMaster
            // 
            this.txtSearchMaster.Location = new System.Drawing.Point(435, 79);
            this.txtSearchMaster.Name = "txtSearchMaster";
            this.txtSearchMaster.Size = new System.Drawing.Size(110, 20);
            this.txtSearchMaster.TabIndex = 4;
            this.txtSearchMaster.TextChanged += new System.EventHandler(this.txtSearchMaster_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridDisplayMaster);
            this.panel1.Location = new System.Drawing.Point(79, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 326);
            this.panel1.TabIndex = 5;
            // 
            // dataGridDisplayMaster
            // 
            this.dataGridDisplayMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplayMaster.Location = new System.Drawing.Point(13, 12);
            this.dataGridDisplayMaster.Name = "dataGridDisplayMaster";
            this.dataGridDisplayMaster.Size = new System.Drawing.Size(794, 300);
            this.dataGridDisplayMaster.TabIndex = 0;
            // 
            // OpticMasterDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearchMaster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlOpticMasters);
            this.Controls.Add(this.label1);
            this.Name = "OpticMasterDisplay";
            this.Text = "OpticMasterDisplay";
            this.Load += new System.EventHandler(this.OpticMasterDisplay_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlOpticMasters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchMaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridDisplayMaster;
    }
}