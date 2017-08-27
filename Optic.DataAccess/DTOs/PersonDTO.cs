using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Optic.Data.Models;

namespace Optic.DataAccess.DTOs
{
    public class PersonDTO
    {
        public PersonDTO()
        {
            OwnedCar = new List<Car>();
        }
        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Car> OwnedCar { get; set; }
    }
}
