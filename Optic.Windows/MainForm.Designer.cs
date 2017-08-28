﻿namespace Optic.Windows
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
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFrameMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLensMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContactLensMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccessoryMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSunGlasses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendorMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpanseMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintBarcode = new System.Windows.Forms.ToolStripMenuItem();
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
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuFrameMaster
            // 
            this.menuFrameMaster.Name = "menuFrameMaster";
            this.menuFrameMaster.Size = new System.Drawing.Size(182, 22);
            this.menuFrameMaster.Text = "Frame Master";
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
            // 
            // menuAccessoryMaster
            // 
            this.menuAccessoryMaster.Name = "menuAccessoryMaster";
            this.menuAccessoryMaster.Size = new System.Drawing.Size(182, 22);
            this.menuAccessoryMaster.Text = "Accessory Master";
            // 
            // menuSunGlasses
            // 
            this.menuSunGlasses.Name = "menuSunGlasses";
            this.menuSunGlasses.Size = new System.Drawing.Size(182, 22);
            this.menuSunGlasses.Text = "Sun Glasses";
            // 
            // menuVendorMaster
            // 
            this.menuVendorMaster.Name = "menuVendorMaster";
            this.menuVendorMaster.Size = new System.Drawing.Size(182, 22);
            this.menuVendorMaster.Text = "Vendor Master";
            // 
            // menuExpanseMaster
            // 
            this.menuExpanseMaster.Name = "menuExpanseMaster";
            this.menuExpanseMaster.Size = new System.Drawing.Size(182, 22);
            this.menuExpanseMaster.Text = "Expanse Master";
            // 
            // menuPrintBarcode
            // 
            this.menuPrintBarcode.Name = "menuPrintBarcode";
            this.menuPrintBarcode.Size = new System.Drawing.Size(182, 22);
            this.menuPrintBarcode.Text = "Print Barcode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 312);
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
    }
}