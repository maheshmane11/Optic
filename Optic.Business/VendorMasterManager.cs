using Optic.DataAccess.DTOs;
using Optic.DataAccess.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Business
{
   public class VendorMasterManager
    {
        VendorMasterDataAccess vendorMasterDataAccess = new VendorMasterDataAccess();
        public bool AddUpdateOpticMaster(VendorMasterDTO vendorMasterDto)
        {
            try
            {
                if (vendorMasterDto.VendorMasterID > 0)
                {
                    vendorMasterDto.ModifiedBy = 1;
                    vendorMasterDto.ModifiedDate = DateTime.Now;
                }
                else
                {
                    vendorMasterDto.CreatedBy = 1;
                    vendorMasterDto.CreatedDate = DateTime.Now;
                }
                return vendorMasterDataAccess.AddUpdateVendorMaster(vendorMasterDto);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CheckMasterExists(string name, int? mobileNO=null)
        {
            return vendorMasterDataAccess.CheckVendorExists(name, mobileNO);
        }

        public List<DisplayVendorMasterDTO> GetMasterList(string searchText)
        {
            return vendorMasterDataAccess.GetVendorMasterList(searchText);
        }

        public bool DeleteOpticMasterById(int vendorMasterId)
        {
            return vendorMasterDataAccess.DeleteVendorMasterById(vendorMasterId);
        }
    }
}
