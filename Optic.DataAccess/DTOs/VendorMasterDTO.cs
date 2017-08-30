using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess.DTOs
{
   public class VendorMasterDTO
    {
        public int VendorMasterID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailId { get; set; }
        public string Website { get; set; }
        public int? VatNo { get; set; }
        public int? CstNo { get; set; }
        public int? LbtNo { get; set; }
        public int? GstNo { get; set; }
        public double? OpBal { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
