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
using static Optic.Common.Enums;

namespace Optic.Windows.Master
{
    public partial class CreateSunGlassesMaster : Form
    {
        public CreateSunGlassesMaster()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        private OpticMasterDTO opticMasterDTO = new OpticMasterDTO();

        public CreateSunGlassesMaster(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        public CreateSunGlassesMaster(OpticMasterDTO objMaster)
        {
            opticMasterDTO = objMaster;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpticMasterManager manager = new OpticMasterManager();
            OpticMasterDTO opticMasterDto = new OpticMasterDTO();

            if (!string.IsNullOrEmpty(lblHiddenId.Text) || !manager.CheckMasterExists(txtName.Text, (int)MasterTypeEnum.SunGlassesMaster))
            {
                if (!string.IsNullOrEmpty(lblHiddenId.Text))
                    opticMasterDto.OpticMasterID = Convert.ToInt32(lblHiddenId.Text);

                opticMasterDto.MasterName = txtName.Text;
                opticMasterDto.PurchaseRate = string.IsNullOrEmpty(txtPurchaseRate.Text) ? 0 : Convert.ToDouble(txtPurchaseRate.Text.Trim());
                opticMasterDto.SellRate = string.IsNullOrEmpty(txtSellRate.Text) ? 0 : Convert.ToDouble(txtSellRate.Text);
                opticMasterDto.OpBal = string.IsNullOrEmpty(txtOpBal.Text) ? 0 : Convert.ToDouble(txtOpBal.Text);
                opticMasterDto.MasterTypeID = (int)MasterTypeEnum.SunGlassesMaster;
                opticMasterDto.IsDeleted = false;
                if (manager.AddUpdateOpticMaster(opticMasterDto))
                {
                    if(string.IsNullOrEmpty(lblHiddenId.Text))
                    this.mainForm.StatusLabelText = "Sun glasses added successfully.";
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

        private void CreateSunGlassesMaster_Load(object sender, EventArgs e)
        {
            lblHiddenId.Visible = false;
            if (opticMasterDTO != null && opticMasterDTO.OpticMasterID > 0)
            {
                lblHiddenId.Text = opticMasterDTO.OpticMasterID.ToString();
                txtName.Text = opticMasterDTO.MasterName;
                txtPurchaseRate.Text = Convert.ToString(opticMasterDTO.PurchaseRate);
                txtSellRate.Text = Convert.ToString(opticMasterDTO.SellRate);
                txtOpBal.Text = Convert.ToString(opticMasterDTO.OpBal);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
