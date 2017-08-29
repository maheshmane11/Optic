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
    public partial class CreateFrameMaster : Form
    {
        public CreateFrameMaster()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpticMasterManager manager = new OpticMasterManager();
            OpticMasterDTO opticMasterDto = new OpticMasterDTO();
            opticMasterDto.MasterName = txtName.Text;
            opticMasterDto.PurchaseRate = Convert.ToDouble(txtPurchaseRate.Text);
            opticMasterDto.SellRate =Convert.ToDouble(txtSellRate.Text.Trim());
            opticMasterDto.OpBal = Convert.ToDouble(txtOpBal.Text);
            opticMasterDto.MasterTypeID = (int)MasterTypeEnum.FrameMaster;
            opticMasterDto.IsDeleted = (int)IsDeletedEnum.False;

            manager.AddUpdateOpticMaster(opticMasterDto);

        }
    }
}
