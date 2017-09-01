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
    public partial class CreateExpanseMaster : Form
    {
        public CreateExpanseMaster()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;

        public CreateExpanseMaster(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }
        DisplayExpanseMasterDTO oldExpenseMaster = new DisplayExpanseMasterDTO();
        public CreateExpanseMaster(DisplayExpanseMasterDTO dtoExpenseMaster)
        {
            oldExpenseMaster.OpticMasterId = dtoExpenseMaster.OpticMasterId;
            oldExpenseMaster.Name = dtoExpenseMaster.Name;           
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpticMasterManager manager = new OpticMasterManager();
            OpticMasterDTO opticMasterDto = new OpticMasterDTO();

            if (!string.IsNullOrEmpty(lblHiddenId.Text) || !manager.CheckMasterExists(txtName.Text, (int)MasterTypeEnum.ExpanseMaster))
            {
                if(!string.IsNullOrEmpty(lblHiddenId.Text))
                {
                    opticMasterDto.OpticMasterID = Convert.ToInt32(lblHiddenId.Text);
                }
                opticMasterDto.MasterName = txtName.Text;
                opticMasterDto.MasterTypeID = (int)MasterTypeEnum.ExpanseMaster;
                opticMasterDto.IsDeleted = false;
                if (manager.AddUpdateOpticMaster(opticMasterDto))
                {
                    if(string.IsNullOrEmpty(lblHiddenId.Text))
                    this.mainForm.StatusLabelText = "Expance master saved successfully!!";
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

        private void CreateExpanseMaster_Load(object sender, EventArgs e)
        {
            lblHiddenId.Visible = false;
            if(oldExpenseMaster!=null && oldExpenseMaster.OpticMasterId>0)
            {
                lblHiddenId.Text = oldExpenseMaster.OpticMasterId.ToString();
                txtName.Text = oldExpenseMaster.Name;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
