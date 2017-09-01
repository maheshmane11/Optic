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
        private VendorMasterDTO oldVendorMasterDto = new VendorMasterDTO();

        public CreateVendorMaster(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        public CreateVendorMaster(VendorMasterDTO objMaster)
        {
            oldVendorMasterDto = objMaster;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VendorMasterManager manager = new VendorMasterManager();
            VendorMasterDTO vendorMasterDto = new VendorMasterDTO();

            if (!string.IsNullOrEmpty(lblHiddenId.Text) || !manager.CheckMasterExists(txtName.Text))
            {
                if (!string.IsNullOrEmpty(lblHiddenId.Text))
                    vendorMasterDto.VendorMasterID = Convert.ToInt32(lblHiddenId.Text);

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
                    if(string.IsNullOrEmpty(lblHiddenId.Text))
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

        private void CreateVendorMaster_Load(object sender, EventArgs e)
        {
            lblHiddenId.Visible = false;
            if (oldVendorMasterDto != null && oldVendorMasterDto.VendorMasterID > 0)
            {
                lblHiddenId.Text = oldVendorMasterDto.VendorMasterID.ToString();
                txtName.Text = oldVendorMasterDto.VendorName;
                txtAddress.Text = oldVendorMasterDto.VendorAddress;
                txtCstNo.Text = Convert.ToString(oldVendorMasterDto.CstNo);
                txtLbtNo.Text = Convert.ToString(oldVendorMasterDto.LbtNo);
                txtVatNo.Text = Convert.ToString(oldVendorMasterDto.VatNo);
                txtGstNo.Text = Convert.ToString(oldVendorMasterDto.GstNo);
                txtOfficePhoneNo.Text = oldVendorMasterDto.OfficePhoneNumber;
                txtPhoneNumber.Text = oldVendorMasterDto.PhoneNumber;
                txtMobileNumber.Text = oldVendorMasterDto.MobileNumber;
                txtFaxNo.Text = oldVendorMasterDto.FaxNumber;
                txtEmailId.Text = oldVendorMasterDto.EmailId;
                txtWebsite.Text = oldVendorMasterDto.Website;
                txtOpBal.Text = Convert.ToString(oldVendorMasterDto.OpBal);
            }
        }
    }
}
