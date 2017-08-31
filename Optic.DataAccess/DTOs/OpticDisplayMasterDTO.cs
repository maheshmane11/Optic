using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess.DTOs
{
   public class OpticDisplayMasterDTO
    {
        public int OpticMasterID { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }        
        public double? PurchaseRate { get; set; }        
        public double? SellRate { get; set; }        
        public double? OpBal { get; set; }
    }    
}
