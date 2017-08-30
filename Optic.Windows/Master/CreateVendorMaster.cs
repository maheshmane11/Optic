using Optic.Business;
using Optic.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optic.Windows.Master
{
    public partial class CreateVendorMaster : Form
    {
        public CreateVendorMaster()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public CreateVendorMaster(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VendorMasterManager manager = new VendorMasterManager();
            VendorMasterDTO vendorMasterDto = new VendorMasterDTO();

            if (!manager.CheckMasterExists(txtName.Text))
            {
                vendorMasterDto.VendorName = txtName.Text.Trim();
                vendorMasterDto.VendorAddress = txtAddress.Text.Trim();
                vendorMasterDto.OfficePhoneNumber = string.IsNullOrEmpty(txtOfficePhoneNo.Text) ? null : (txtOfficePhoneNo.Text.Trim());
                vendorMasterDto.PhoneNumber = string.IsNullOrEmpty(txtPhoneNumber.Text) ? null : (txtPhoneNumber.Text.Trim());
                vendorMasterDto.MobileNumber = string.IsNullOrEmpty(txtMobileNumber.Text) ? null : (txtMobileNumber.Text.Trim());
                vendorMasterDto.FaxNumber = string.IsNullOrEmpty(txtFaxNo.Text) ? null : (txtFaxNo.Text.Trim());
                vendorMasterDto.Website = txtWebsite.Text.Trim();
                vendorMasterDto.EmailId = txtEmailId.Text.Trim();                
                vendorMasterDto.OpBal = string.IsNullOrEmpty(txtOpBal.Text) ? (double?)null : Convert.ToDouble(txtOpBal.Text.Trim());
                vendorMasterDto.CstNo = string.IsNullOrEmpty(txtCstNo.Text) ? (int?)null : Convert.ToInt32(txtCstNo.Text.Trim());
                vendorMasterDto.GstNo = string.IsNullOrEmpty(txtGstNo.Text) ? (int?)null : Convert.ToInt32(txtGstNo.Text.Trim());
                vendorMasterDto.VatNo = string.IsNullOrEmpty(txtVatNo.Text) ? (int?)null : Convert.ToInt32(txtVatNo.Text.Trim());
                vendorMasterDto.LbtNo = string.IsNullOrEmpty(txtLbtNo.Text) ? (int?)null : Convert.ToInt32(txtLbtNo.Text.Trim());
                vendorMasterDto.IsDeleted = false;
                if (manager.AddUpdateOpticMaster(vendorMasterDto))
                {
                    this.mainForm.StatusLabelText = "Vendor saved successfully.";
                    this.Close();
                }
                else
                    MessageBox.Show("Problem in saving saving data. Try Again.");
            }
            else
            {
                MessageBox.Show("Name already exists. Enter new name.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
