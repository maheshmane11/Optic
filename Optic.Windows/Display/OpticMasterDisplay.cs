using Optic.Business;
using Optic.Common;
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
            lstMasters.Add(new KeyValuePair<int, string>(0, "- Select Master -"));
            foreach (MasterTypeEnum master in masters)
            {
                if (!master.ToString().Equals(Constants.strExpenseMaster))
                    lstMasters.Add(new KeyValuePair<int, string>(((int)master), master.ToString()));
            }
            ddlOpticMasters.DataSource = lstMasters;
            ddlOpticMasters.DisplayMember = "Value";
            ddlOpticMasters.ValueMember = "Key";
        }

        OpticMasterManager manager = new OpticMasterManager();
        private void ddlOpticMasters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMasterValue = Convert.ToInt32(((KeyValuePair<int, string>)ddlOpticMasters.SelectedItem).Key); ;

            if (selectedMasterValue > 0)
            {
                FillMasterGrid(selectedMasterValue);
            }
        }

        private void FillMasterGrid(int selectedMasterValue)
        {
            var masterList = manager.GetMasterList(selectedMasterValue, txtSearchMaster.Text);
            dataGridDisplayMaster.DataSource = masterList.Select(o => new
            {
                Id = o.OpticMasterID,
                Name = o.Name,
                Barcode = o.Barcode,
                PurchaseRate = o.PurchaseRate,
                SellRate = o.SellRate,
                OpBal = o.OpBal
            }).ToList();

            dataGridDisplayMaster.Columns[0].Visible = false;

            dataGridDisplayMaster.Columns[1].Width = 150;
            dataGridDisplayMaster.Columns[2].Width = 100;
            dataGridDisplayMaster.Columns[3].Width = 150;
            dataGridDisplayMaster.Columns[4].Width = 100;

            dataGridDisplayMaster.Columns["PurchaseRate"].HeaderText = "Purchase Rate";
            dataGridDisplayMaster.Columns["SellRate"].HeaderText = "Sell Rate";
            dataGridDisplayMaster.Columns["OpBal"].HeaderText = "Op Bal";
            if (!dataGridDisplayMaster.Columns.Contains("btnDeleteRow"))
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "btnDeleteRow";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridDisplayMaster.Columns.Insert(6, deleteButton);
                //dataGridDisplayMaster.Columns.Add();
            }
            else
                dataGridDisplayMaster.Columns["btnDeleteRow"].Visible = true;
            dataGridDisplayMaster.CellClick += new DataGridViewCellEventHandler(dataGridDisplayMaster_CellClick);

        }

        void dataGridDisplayMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null)
            {
                DataGridViewButtonCell b = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (b != null)
                {
                    int opticMasterId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
                    if (manager.DeleteOpticMasterById(opticMasterId))
                    {
                        int selectedMasterValue = Convert.ToInt32(((KeyValuePair<int, string>)ddlOpticMasters.SelectedItem).Key);
                        FillMasterGrid(selectedMasterValue);
                    }
                    else
                    {
                        MessageBox.Show("Problem while deleting the record. Try again!");
                    }

                }
            }
        }

        private void txtSearchMaster_TextChanged(object sender, EventArgs e)
        {
            int selectedMasterValue = Convert.ToInt32(((KeyValuePair<int, string>)ddlOpticMasters.SelectedItem).Key); ;
            if (selectedMasterValue > 0)
            {
                FillMasterGrid(selectedMasterValue);
            }
        }
    }
}
