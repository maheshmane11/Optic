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
    public class OpticMasterDataAccess
    {
        public bool AddUpdateOpticMaster(OpticMasterDTO opticMasterDto)
        {
            try
            {
                if (opticMasterDto.OpticMasterID > 0)
                {

                    using (var uoW = new UnitOfWork())
                    {
                        var model = uoW.opticMasterRepository.GetById(opticMasterDto.OpticMasterID);
                        model.MasterName = opticMasterDto.MasterName.Trim();
                        model.MasterTypeID = opticMasterDto.MasterTypeID;
                        model.PurchaseRate = opticMasterDto.PurchaseRate;
                        model.SellRate = opticMasterDto.SellRate;
                        model.OpBal = opticMasterDto.OpBal;
                        model.IsDeleted = opticMasterDto.IsDeleted;
                        model.ModifiedBy = opticMasterDto.ModifiedBy;
                        model.ModifiedDate = opticMasterDto.ModifiedDate;
                        uoW.Save();
                    }

                }
                else
                {
                    OpticMasters model = new OpticMasters();
                    model.MasterName = opticMasterDto.MasterName;
                    model.MasterTypeID = opticMasterDto.MasterTypeID;
                    model.PurchaseRate = opticMasterDto.PurchaseRate;
                    model.SellRate = opticMasterDto.SellRate;
                    model.OpBal = opticMasterDto.OpBal;
                    model.IsDeleted = opticMasterDto.IsDeleted;
                    model.CreatedBy = opticMasterDto.CreatedBy;
                    model.CreatedDate = opticMasterDto.CreatedDate;
                    using (var uoW = new UnitOfWork())
                    {
                        uoW.opticMasterRepository.Insert(model);
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckMasterExists(string name, int masterTypeId)
        {
            int count = 0;
            using (var uoW = new UnitOfWork())
            {
                if (uoW.opticMasterRepository.Get().Count() > 0)
                {
                    count = uoW.opticMasterRepository
                    .Get(x => x.MasterName.Equals(name.Trim()) && x.MasterTypeID == masterTypeId).Count();
                }
            }
            return count > 0 ? true : false;
        }

        public List<OpticDisplayMasterDTO> GetMasterList(int masterTypeId, string searchText)
        {
            try
            {
                List<OpticDisplayMasterDTO> OpticDisplayMasterList = new List<OpticDisplayMasterDTO>();
                using (var uoW = new UnitOfWork())
                {
                    var masterList = new List<OpticMasters>();
                    if(string.IsNullOrEmpty(searchText))
                       masterList = uoW.opticMasterRepository.Get(x => x.MasterTypeID == masterTypeId && !x.IsDeleted).ToList();
                    else
                        masterList= uoW.opticMasterRepository.Get(x => x.MasterTypeID == masterTypeId && x.MasterName.Contains(searchText) && !x.IsDeleted).ToList();
                    OpticDisplayMasterDTO newData = new OpticDisplayMasterDTO();

                    OpticDisplayMasterList =
                            masterList.Select(item => new OpticDisplayMasterDTO
                            {
                                OpticMasterID = item.OpticMasterID,
                                Name = item.MasterName,
                                Barcode = "ABC",
                                PurchaseRate = item.PurchaseRate,
                                SellRate = item.SellRate,
                                OpBal = item.OpBal
                            }).ToList();


                    //foreach (var item in masterList)
                    //{
                    //    newData = new OpticDisplayMasterDTO();
                    //    newData.OpticMasterID = item.OpticMasterID;
                    //    newData.Name = item.MasterName;
                    //    newData.Barcode = "ABC";
                    //    newData.PurchaseRate = item.PurchaseRate;
                    //    newData.SellRate = item.SellRate;
                    //    newData.OpBal = item.OpBal;
                    //    OpticDisplayMasterList.Add(newData);
                    //}
                }
                return OpticDisplayMasterList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool DeleteOpticMasterById(int opticMasterId)
        {
            try
            {
                using (var uoW = new UnitOfWork())
                {
                    var opticMaster=uoW.opticMasterRepository.GetById(opticMasterId);
                    opticMaster.IsDeleted = true;
                    opticMaster.ModifiedBy = 1;
                    opticMaster.ModifiedDate = DateTime.Now;
                    uoW.opticMasterRepository.Update(opticMaster);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
