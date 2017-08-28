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

        private void MainForm_Load(object sender, EventArgs e)
        {
            OnFormLoadManager.SetEFInitializer();
        }

        private void lenseGlassMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CreateLensMaster();
            form.Show(this);
        }

        private void menuFrameMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateFrameMaster();
            form.Show(this);
        }

        private void menuContactLensMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateContactLensMaster();
            form.Show(this);
        }

        private void menuAccessoryMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateAccessoryMaster();
            form.Show(this);
        }

        private void menuSunGlasses_Click(object sender, EventArgs e)
        {
            var form = new CreateSunGlassesMaster();
            form.Show(this);
        }

        private void menuVendorMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateVendorMaster();
            form.Show(this);
        }

        private void menuExpanseMaster_Click(object sender, EventArgs e)
        {
            var form = new CreateExpanseMaster();
            form.Show(this);
        }

        private void menuPrintBarcode_Click(object sender, EventArgs e)
        {
            var form = new CreatePrintBarcode();
            form.Show(this);
        }
    }
}
