using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Models
{
    public class Category : Entity
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
        public override string ToString()
        {
            return $"{CategoryName} / {Description}";
        }
    }
}
