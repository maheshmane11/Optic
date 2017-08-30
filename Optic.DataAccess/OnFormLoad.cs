using Optic.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess
{
  public class OnFormLoad
    {
        public static void SetEFSettings()
        {
            Database.SetInitializer<Context>(null);                        
        }
    }
}
