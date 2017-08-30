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
      
    }
}
