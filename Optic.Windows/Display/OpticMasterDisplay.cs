using Optic.Business;
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

namespace Optic.Windows.Display
{
    public partial class OpticMasterDisplay : Form
    {
        public OpticMasterDisplay()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public OpticMasterDisplay(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void OpticMasterDisplay_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> lstMasters = new List<KeyValuePair<int, string>>();
            Array masters = Enum.GetValues(typeof(MasterTypeEnum));
            foreach (MasterTypeEnum master in masters)
            {
                lstMasters.Add(new KeyValuePair<int, string>(((int)master),master.ToString()));
            }
            ddlOpticMasters.DataSource = lstMasters;
            ddlOpticMasters.DisplayMember = "Value";
            ddlOpticMasters.ValueMember = "Key";
        }

        OpticMasterManager manager = new OpticMasterManager();  
        private void ddlOpticMasters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlOpticMasters.Text))
            {
                int selectedMasterValue = Convert.ToInt32(((KeyValuePair<int, string>)ddlOpticMasters.SelectedItem).Key); ;
                var masterList = manager.GetMasterList(selectedMasterValue);
                dataGridDisplayMaster.DataSource = masterList;
                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridDisplayMaster.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }
    }
}
