﻿using System;
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
    public partial class CreateContactLensMaster : Form
    {
        public CreateContactLensMaster()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public CreateContactLensMaster(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
