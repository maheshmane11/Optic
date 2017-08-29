using Optic.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optic.Windows.Master;

namespace Optic.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string StatusLabelText
        {
            get
            {
                return this.lblMainFormStatus.Text;
            }
            set
            {
                this.lblMainFormStatus.Text = value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OnFormLoadManager.SetEFInitializer();
        }

        private void lenseGlassMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CreateLensMaster(this);
            form.ShowDialog();
        }

        private void menuFrameMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateFrameMaster(this);
            form.ShowDialog();
        }

        private void menuContactLensMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateContactLensMaster(this);
            form.ShowDialog();
        }

        private void menuAccessoryMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateAccessoryMaster(this);
            form.ShowDialog();
        }

        private void menuSunGlasses_Click(object sender, EventArgs e)
        {
            var form = new CreateSunGlassesMaster(this);
            form.ShowDialog();
        }

        private void menuVendorMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateVendorMaster(this);
            form.ShowDialog();
        }

        private void menuExpanseMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateExpanseMaster(this);
            form.ShowDialog();
        }

        private void menuPrintBarcode_Click(object sender, EventArgs e)
        {
            var form = new CreatePrintBarcode(this);
            form.ShowDialog();
        }

       
    }
}
