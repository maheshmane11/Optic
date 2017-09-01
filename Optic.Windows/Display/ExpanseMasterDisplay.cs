using Optic.Business;
using Optic.DataAccess.DTOs;
using Optic.Windows.Master;
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
    public partial class ExpanseMasterDisplay : Form
    {
        public ExpanseMasterDisplay()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public ExpanseMasterDisplay(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void ExpanseMasterDisplay_Load(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        OpticMasterManager manager = new OpticMasterManager();
        private void FillMasterGrid()
        {
            var masterList = manager.GetExpenseMasterList((int)MasterTypeEnum.ExpanseMaster, txtSearchMaster.Text);
            dataGridDisplayMaster.DataSource = masterList.Select(o => new
            {
                Id = o.OpticMasterId,
                Name = o.Name
            }).ToList();

            dataGridDisplayMaster.Columns[0].Visible = false;
            dataGridDisplayMaster.Columns[1].Width = 150;

            dataGridDisplayMaster.Columns["Name"].HeaderText = "Expense Name";
            if (!dataGridDisplayMaster.Columns.Contains("btnDeleteRow") && !dataGridDisplayMaster.Columns.Contains("btnEditRow"))
            {
                var editButton = new DataGridViewButtonColumn();
                editButton.Name = "btnEditRow";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridDisplayMaster.Columns.Insert(dataGridDisplayMaster.ColumnCount, editButton);

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "btnDeleteRow";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridDisplayMaster.Columns.Insert(dataGridDisplayMaster.ColumnCount, deleteButton);

                dataGridDisplayMaster.CellClick += new DataGridViewCellEventHandler(dataGridDisplayMaster_CellClick);
            }
            else
            {
                dataGridDisplayMaster.Columns["btnDeleteRow"].Visible = true;
                dataGridDisplayMaster.Columns["btnEditRow"].Visible = true;
            }
            
        }

        void dataGridDisplayMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewButtonCell b = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (b != null)
                {
                    int opticMasterId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
                    if (b.Value.ToString().Equals("Delete"))
                        DeleteExpenseMaster(opticMasterId);
                    else
                        EditExpenseMaster(opticMasterId);
                }
            }
        }

        private void DeleteExpenseMaster(int opticMasterId)
        {
            if (manager.DeleteOpticMasterById(opticMasterId))
            {
                FillMasterGrid();
            }
            else
            {
                MessageBox.Show("Problem while deleting the record. Try again!");
            }
        }

        private void EditExpenseMaster(int opticMasterId)
        {
            var expenseMaster = manager.GetOpticMasterById(opticMasterId);
            var form = new CreateExpanseMaster(new DisplayExpanseMasterDTO { OpticMasterId = expenseMaster.OpticMasterID, Name = expenseMaster.MasterName });
            form.ShowDialog();
        }

        private void txtSearchMaster_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchMaster.Text))
            {
                FillMasterGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
