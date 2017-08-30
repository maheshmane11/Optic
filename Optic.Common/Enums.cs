using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.Common
{
   public class Enums
    {
      public enum MasterTypeEnum
        {
            FrameMaster=1,
            LensMaster=2,
            ContactLensMaster=3,
            AccessoryMaster = 4,
            SunGlassesMaster =5,
            ExpanseMaster = 6
        };

        public enum IsDeletedEnum
        {
            True = -1,
            False = 0
        };
    }
}
