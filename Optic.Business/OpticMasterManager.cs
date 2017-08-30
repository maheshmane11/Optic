using Optic.DataAccess.DTOs;
using Optic.DataAccess.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Business
{
    public class OpticMasterManager
    {
        OpticMasterDataAccess opticMasterDataAccess = new OpticMasterDataAccess();
        public bool AddUpdateOpticMaster(OpticMasterDTO opticMasterDto)
        {
            try
            {
                if (opticMasterDto.OpticMasterID > 0)
                {
                    opticMasterDto.ModifiedBy = 1;
                    opticMasterDto.ModifiedDate = DateTime.Now;
                }
                else
                {
                    opticMasterDto.CreatedBy = 1;
                    opticMasterDto.CreatedDate = DateTime.Now;
                }
                return opticMasterDataAccess.AddUpdateOpticMaster(opticMasterDto);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckMasterExists(string name, int masterTypeId)
        {
            return opticMasterDataAccess.CheckMasterExists(name, masterTypeId);
        }

        public List<OpticDisplayMasterDTO> GetMasterList(int masterTypeId)
        {
            return opticMasterDataAccess.GetMasterList(masterTypeId);
        }
    }
}
