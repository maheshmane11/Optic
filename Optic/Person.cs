﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace JetEFDemo
{
    public class Person
    {
        public Person()
        {
            OwnedCar = new List<Car>();
        }
        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Car> OwnedCar { get; set; }
    }
}
