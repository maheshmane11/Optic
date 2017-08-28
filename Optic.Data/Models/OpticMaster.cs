﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Data.Models
{
   public class OpticMaster
    {
        public int OpticMasterID { get; set; }
        public int MasterTypeID { get; set; }
        public string MasterName { get; set; }
        public double PurchaseRate { get; set; }
        public double SellRate { get; set; }
        public double OpBal { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }

        public virtual MasterType MasterType { get; set; }
    }
}