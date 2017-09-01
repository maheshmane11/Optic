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

        public List<DisplayVendorMasterDTO> GetVendorMasterList(string searchText)
        {
            try
            {
                List<DisplayVendorMasterDTO> vendorMasterList = new List<DisplayVendorMasterDTO>();
                using (var uoW = new UnitOfWork())
                {
                    var masterList = new List<VendorMaster>();
                    if (string.IsNullOrEmpty(searchText))
                        masterList = uoW.vendorMasterRepository.Get(x=>!x.IsDeleted).ToList();
                    else
                        masterList = uoW.vendorMasterRepository.Get(x => x.VendorName.Contains(searchText) && !x.IsDeleted).ToList();
                    
                    vendorMasterList =
                            masterList.Select(item => new DisplayVendorMasterDTO
                            {
                                VendorMasterID = item.VendorMasterID,
                                VendorName= item.VendorName,
                                VendorAddress = item.VendorAddress,
                                OfficePhoneNumber = item.OfficePhoneNumber,
                                PhoneNumber = item.PhoneNumber,
                                MobileNumber=item.MobileNumber,
                                FaxNumber = item.FaxNumber
                            }).ToList();                    
                }
                return vendorMasterList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VendorMasterDTO GetVendorMasterById(int vendorMasterId)
        {
            using (var uoW = new UnitOfWork())
            {
                var opticMaster = uoW.vendorMasterRepository.GetFirstOrDefault(x => x.VendorMasterID == vendorMasterId && !x.IsDeleted);

                VendorMasterDTO opticMasterDTO = new VendorMasterDTO
                {
                    VendorMasterID = opticMaster.VendorMasterID,
                    VendorName = opticMaster.VendorName,
                    OfficePhoneNumber = opticMaster.OfficePhoneNumber,
                    PhoneNumber = opticMaster.PhoneNumber,
                    MobileNumber=opticMaster.MobileNumber,
                    FaxNumber=opticMaster.FaxNumber,
                    VendorAddress=opticMaster.VendorAddress,
                    EmailId=opticMaster.EmailId,
                    Website=opticMaster.Website,
                    CstNo=opticMaster.CstNo,
                    GstNo=opticMaster.GstNo,
                    LbtNo=opticMaster.LbtNo,
                    VatNo=opticMaster.VatNo,
                    OpBal = opticMaster.OpBal,
                    IsDeleted = opticMaster.IsDeleted,                    
                    CreatedBy = opticMaster.CreatedBy,
                    CreatedDate = opticMaster.CreatedDate,
                    ModifiedBy = opticMaster.ModifiedBy,
                    ModifiedDate = opticMaster.ModifiedDate
                };
                return opticMasterDTO;
            }
        }

        public bool DeleteVendorMasterById(int vedorMasterId)
        {
            try
            {
                using (var uoW = new UnitOfWork())
                {
                    var vendorMaster = uoW.vendorMasterRepository.GetById(vedorMasterId);
                    vendorMaster.IsDeleted = true;
                    vendorMaster.ModifiedBy = 1;
                    vendorMaster.ModifiedDate = DateTime.Now;
                    uoW.vendorMasterRepository.Update(vendorMaster);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
