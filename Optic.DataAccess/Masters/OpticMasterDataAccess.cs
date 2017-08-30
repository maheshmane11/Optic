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
    }
}
