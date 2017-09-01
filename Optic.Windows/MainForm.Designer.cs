namespace Optic.Windows
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFrameMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLensMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContactLensMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccessoryMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSunGlasses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendorMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpanseMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintBarcode = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAllMasters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayVendorMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayexpanseMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainFormStatus = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(810, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFrameMaster,
            this.menuLensMaster,
            this.menuContactLensMaster,
            this.menuAccessoryMaster,
            this.menuSunGlasses,
            this.menuVendorMaster,
            this.menuExpanseMaster,
            this.menuPrintBarcode});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // menuFrameMaster
            // 
            this.menuFrameMaster.Name = "menuFrameMaster";
            this.menuFrameMaster.Size = new System.Drawing.Size(182, 22);
            this.menuFrameMaster.Text = "Frame Master";
            this.menuFrameMaster.Click += new System.EventHandler(this.menuFrameMaster_Click);
            // 
            // menuLensMaster
            // 
            this.menuLensMaster.Name = "menuLensMaster";
            this.menuLensMaster.Size = new System.Drawing.Size(182, 22);
            this.menuLensMaster.Text = "Lens(Glass) Master";
            this.menuLensMaster.Click += new System.EventHandler(this.lenseGlassMasterToolStripMenuItem_Click);
            // 
            // menuContactLensMaster
            // 
            this.menuContactLensMaster.Name = "menuContactLensMaster";
            this.menuContactLensMaster.Size = new System.Drawing.Size(182, 22);
            this.menuContactLensMaster.Text = "Contact Lens Master";
            this.menuContactLensMaster.Click += new System.EventHandler(this.menuContactLensMaster_Click);
            // 
            // menuAccessoryMaster
            // 
            this.menuAccessoryMaster.Name = "menuAccessoryMaster";
            this.menuAccessoryMaster.Size = new System.Drawing.Size(182, 22);
            this.menuAccessoryMaster.Text = "Accessory Master";
            this.menuAccessoryMaster.Click += new System.EventHandler(this.menuAccessoryMaster_Click);
            // 
            // menuSunGlasses
            // 
            this.menuSunGlasses.Name = "menuSunGlasses";
            this.menuSunGlasses.Size = new System.Drawing.Size(182, 22);
            this.menuSunGlasses.Text = "Sun Glasses";
            this.menuSunGlasses.Click += new System.EventHandler(this.menuSunGlasses_Click);
            // 
            // menuVendorMaster
            // 
            this.menuVendorMaster.Name = "menuVendorMaster";
            this.menuVendorMaster.Size = new System.Drawing.Size(182, 22);
            this.menuVendorMaster.Text = "Vendor Master";
            this.menuVendorMaster.Click += new System.EventHandler(this.menuVendorMaster_Click);
            // 
            // menuExpanseMaster
            // 
            this.menuExpanseMaster.Name = "menuExpanseMaster";
            this.menuExpanseMaster.Size = new System.Drawing.Size(182, 22);
            this.menuExpanseMaster.Text = "Expanse Master";
            this.menuExpanseMaster.Click += new System.EventHandler(this.menuExpanseMaster_Click);
            // 
            // menuPrintBarcode
            // 
            this.menuPrintBarcode.Name = "menuPrintBarcode";
            this.menuPrintBarcode.Size = new System.Drawing.Size(182, 22);
            this.menuPrintBarcode.Text = "Print Barcode";
            this.menuPrintBarcode.Click += new System.EventHandler(this.menuPrintBarcode_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAllMasters,
            this.menuDisplayVendorMaster,
            this.menuDisplayexpanseMaster});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // menuAllMasters
            // 
            this.menuAllMasters.Name = "menuAllMasters";
            this.menuAllMasters.Size = new System.Drawing.Size(155, 22);
            this.menuAllMasters.Text = "All Masters";
            this.menuAllMasters.Click += new System.EventHandler(this.menuAllMasters_Click);
            // 
            // menuDisplayVendorMaster
            // 
            this.menuDisplayVendorMaster.Name = "menuDisplayVendorMaster";
            this.menuDisplayVendorMaster.Size = new System.Drawing.Size(155, 22);
            this.menuDisplayVendorMaster.Text = "Vendor Master";
            this.menuDisplayVendorMaster.Click += new System.EventHandler(this.menuDisplayVendorMaster_Click);
            // 
            // menuDisplayexpanseMaster
            // 
            this.menuDisplayexpanseMaster.Name = "menuDisplayexpanseMaster";
            this.menuDisplayexpanseMaster.Size = new System.Drawing.Size(155, 22);
            this.menuDisplayexpanseMaster.Text = "Expanse Master";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lblMainFormStatus
            // 
            this.lblMainFormStatus.AutoSize = true;
            this.lblMainFormStatus.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainFormStatus.Location = new System.Drawing.Point(39, 45);
            this.lblMainFormStatus.Name = "lblMainFormStatus";
            this.lblMainFormStatus.Size = new System.Drawing.Size(0, 33);
            this.lblMainFormStatus.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 312);
            this.Controls.Add(this.lblMainFormStatus);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Optic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFrameMaster;
        private System.Windows.Forms.ToolStripMenuItem menuLensMaster;
        private System.Windows.Forms.ToolStripMenuItem menuContactLensMaster;
        private System.Windows.Forms.ToolStripMenuItem menuAccessoryMaster;
        private System.Windows.Forms.ToolStripMenuItem menuSunGlasses;
        private System.Windows.Forms.ToolStripMenuItem menuVendorMaster;
        private System.Windows.Forms.ToolStripMenuItem menuExpanseMaster;
        private System.Windows.Forms.ToolStripMenuItem menuPrintBarcode;
        private System.Windows.Forms.Label lblMainFormStatus;
        private System.Windows.Forms.ToolStripMenuItem menuAllMasters;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayVendorMaster;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayexpanseMaster;
    }
}