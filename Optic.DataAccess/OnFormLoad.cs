using Optic.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optic.DataAccess
{
  public class OnFormLoad
    {
        public static void SetEFInitializer()
        {
            Database.SetInitializer<Context>(null);
        }
    }
}
