using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Optic.Data.Models
{
   public class Car
    {        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Number { get; set; }
        public int CarTypeID { get; set; }
        public virtual Person Owner { get; set; }
        public virtual CarType CarType { get; set; }
    }
}
