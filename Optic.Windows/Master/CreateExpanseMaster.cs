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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            OpticMasterManager manager = new OpticMasterManager();
            OpticMasterDTO opticMasterDto = new OpticMasterDTO();

            if (!manager.CheckMasterExists(txtName.Text, (int)MasterTypeEnum.ExpanseMaster))
            {
                opticMasterDto.MasterName = txtName.Text;
                opticMasterDto.MasterTypeID = (int)MasterTypeEnum.ExpanseMaster;
                opticMasterDto.IsDeleted = false;
                if (manager.AddUpdateOpticMaster(opticMasterDto))
                {

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
    }
}
