using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess.DTOs
{
   public class DisplayVendorMasterDTO
    {
        public int VendorMasterID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
    }
}
