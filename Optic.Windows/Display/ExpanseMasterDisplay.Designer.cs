namespace Optic.Windows.Display
{
    partial class ExpanseMasterDisplay
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
            this.dataGridDisplayMaster = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearchMaster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridDisplayMaster);
            this.panel1.Location = new System.Drawing.Point(93, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 284);
            this.panel1.TabIndex = 16;
            // 
            // dataGridDisplayMaster
            // 
            this.dataGridDisplayMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplayMaster.Location = new System.Drawing.Point(13, 17);
            this.dataGridDisplayMaster.Name = "dataGridDisplayMaster";
            this.dataGridDisplayMaster.Size = new System.Drawing.Size(436, 253);
            this.dataGridDisplayMaster.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(337, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 26);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearchMaster
            // 
            this.txtSearchMaster.Location = new System.Drawing.Point(163, 63);
            this.txtSearchMaster.Name = "txtSearchMaster";
            this.txtSearchMaster.Size = new System.Drawing.Size(121, 20);
            this.txtSearchMaster.TabIndex = 15;
            this.txtSearchMaster.TextChanged += new System.EventHandler(this.txtSearchMaster_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Display Expanse Master";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(460, 63);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ExpanseMasterDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 454);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchMaster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ExpanseMasterDisplay";
            this.Text = "ExpanseMasterDisplay";
            this.Load += new System.EventHandler(this.ExpanseMasterDisplay_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplayMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridDisplayMaster;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearchMaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}