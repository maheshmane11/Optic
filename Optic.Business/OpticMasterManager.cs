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
        public void AddUpdateOpticMaster(OpticMasterDTO opticMasterDto)
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
            opticMasterDataAccess.AddUpdateOpticMaster(opticMasterDto);
        }
    }
}
