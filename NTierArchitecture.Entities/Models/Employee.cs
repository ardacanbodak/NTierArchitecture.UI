using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Employee : Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public override string ToString()
        {
            return $"{Name} / {Surname}";
        }

    }
}
