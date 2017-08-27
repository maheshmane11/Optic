using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Optic.DataAccess.DTOs
{
   public class CarDTO
    {        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Number { get; set; }
        public int CarTypeID { get; set; }
        public PersonDTO Owner { get; set; }
        public CarTypeDTO CarType { get; set; }
    }
}
