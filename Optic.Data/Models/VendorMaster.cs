using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Data.Models
{
   public class VendorMaster
    {
        public int VendorMasterID { get; set; }        
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public int OfficePhoneNumber { get; set; }
        public int PhoneNumber { get; set; }
        public int MobileNumber { get; set; }
        public int FaxNumber { get; set; }
        public string EmailId { get; set; }
        public string Website { get; set; }
        public int GstNo { get; set; }
        public double OpBal { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }

    }
}
