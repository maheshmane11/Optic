using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void CreateExpanseMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
