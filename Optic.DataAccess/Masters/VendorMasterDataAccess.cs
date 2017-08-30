using Optic.Data;
using Optic.Data.Models;
using Optic.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess.Masters
{
    public class VendorMasterDataAccess
    {
        public bool AddUpdateVendorMaster(VendorMasterDTO vendorMasterDto)
        {
            try
            {
                if (vendorMasterDto.VendorMasterID > 0)
                {

                    using (var uoW = new UnitOfWork())
                    {
                        var model = uoW.vendorMasterRepository.GetById(vendorMasterDto.VendorMasterID);
                        model.VendorName = vendorMasterDto.VendorName;
                        model.VendorAddress = vendorMasterDto.VendorAddress;
                        model.MobileNumber = vendorMasterDto.MobileNumber;
                        model.PhoneNumber = vendorMasterDto.PhoneNumber;
                        model.OfficePhoneNumber = vendorMasterDto.OfficePhoneNumber;
                        model.FaxNumber = vendorMasterDto.FaxNumber;
                        model.Website = vendorMasterDto.Website;
                        model.EmailId = vendorMasterDto.EmailId;
                        model.OpBal = vendorMasterDto.OpBal;
                        model.GstNo = vendorMasterDto.GstNo;
                        model.LbtNo = vendorMasterDto.LbtNo;
                        model.VatNo = vendorMasterDto.VatNo;
                        model.CstNo = vendorMasterDto.CstNo;
                        model.IsDeleted = vendorMasterDto.IsDeleted;
                        model.ModifiedBy = vendorMasterDto.ModifiedBy;
                        model.ModifiedDate = vendorMasterDto.ModifiedDate;
                        uoW.Save();
                    }

                }
                else
                {
                    VendorMaster model = new VendorMaster();
                    model.VendorName = vendorMasterDto.VendorName;
                    model.VendorAddress = vendorMasterDto.VendorAddress;
                    model.MobileNumber = vendorMasterDto.MobileNumber;
                    model.PhoneNumber = vendorMasterDto.PhoneNumber;
                    model.OfficePhoneNumber = vendorMasterDto.OfficePhoneNumber;
                    model.FaxNumber = vendorMasterDto.FaxNumber;
                    model.Website = vendorMasterDto.Website;
                    model.EmailId = vendorMasterDto.EmailId;
                    model.OpBal = vendorMasterDto.OpBal;
                    model.GstNo = vendorMasterDto.GstNo;
                    model.LbtNo = vendorMasterDto.LbtNo;
                    model.VatNo = vendorMasterDto.VatNo;
                    model.CstNo = vendorMasterDto.CstNo;
                    model.IsDeleted = vendorMasterDto.IsDeleted;
                    model.CreatedBy = vendorMasterDto.CreatedBy;
                    model.CreatedDate = vendorMasterDto.CreatedDate;
                    using (var uoW = new UnitOfWork())
                    {
                        uoW.vendorMasterRepository.Insert(model);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckVendorExists(string name, int? mobileNo = null)
        {
            int count = 0;
            using (var uoW = new UnitOfWork())
            {
                if (uoW.vendorMasterRepository.Get().Count() > 0)
                {
                    count = uoW.vendorMasterRepository
                        .Get(x => x.VendorName.Equals(name.Trim())).Count();
                }
            }
            return count > 0 ? true : false;
        }
    }
}
