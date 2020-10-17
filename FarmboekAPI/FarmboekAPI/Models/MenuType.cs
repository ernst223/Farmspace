using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class MenuType
    {
        public MenuType()
        {
            Combine = new HashSet<Combine>();
            Equipment = new HashSet<Equipment>();
            Problem = new HashSet<Problem>();
            Product = new HashSet<Product>();
            Tractor = new HashSet<Tractor>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int MenuTypeId { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }

        public ICollection<Combine> Combine { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<Problem> Problem { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Tractor> Tractor { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
