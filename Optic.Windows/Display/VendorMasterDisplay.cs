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

namespace Optic.Windows.Display
{
    public partial class VendorMasterDisplay : Form
    {
        public VendorMasterDisplay()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public VendorMasterDisplay(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        VendorMasterManager manager = new VendorMasterManager();
        private void VendorMasterDisplay_Load(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        private void FillMasterGrid()
        {
            var masterList = manager.GetMasterList(txtSearchMaster.Text);
            dataGridDisplayMaster.DataSource = masterList.Select(o => new
            {
                Id = o.VendorMasterID,
                Name = o.VendorName,
                Address = o.VendorAddress,
                OfficePhoneNo = o.OfficePhoneNumber,
                PhoneNo = o.PhoneNumber,
                MobileNo = o.MobileNumber,
                FaxNo=o.FaxNumber
            }).ToList();

            dataGridDisplayMaster.Columns[0].Visible = false;
            dataGridDisplayMaster.Columns[1].Width = 100;
            dataGridDisplayMaster.Columns[1].Width = 150;
            dataGridDisplayMaster.Columns[2].Width = 100;
            dataGridDisplayMaster.Columns[3].Width = 100;
            dataGridDisplayMaster.Columns[4].Width = 100;

            dataGridDisplayMaster.Columns["OfficePhoneNo"].HeaderText = "Phone No(O)";
            dataGridDisplayMaster.Columns["PhoneNo"].HeaderText = "Phone No";
            dataGridDisplayMaster.Columns["MobileNo"].HeaderText = "MobileNo";
            if (!dataGridDisplayMaster.Columns.Contains("btnDeleteRow"))
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "btnDeleteRow";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridDisplayMaster.Columns.Insert(dataGridDisplayMaster.ColumnCount, deleteButton);
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
                        FillMasterGrid();
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
            if (!string.IsNullOrEmpty(txtSearchMaster.Text))
            {
                FillMasterGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillMasterGrid();
        }
    }
}
