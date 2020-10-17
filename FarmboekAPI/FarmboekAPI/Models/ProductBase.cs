using System;
using System.Collections.Generic;

namespace FarmboekAPI.Models
{
    public partial class ProductBase
    {
        public ProductBase()
        {
            Product = new HashSet<Product>();
            ProductActiveIngredient = new HashSet<ProductActiveIngredient>();
            ProductAttachment = new HashSet<ProductAttachment>();
            ProductBaseRemedyType = new HashSet<ProductBaseRemedyType>();
            ProductImage = new HashSet<ProductImage>();
            ProductSpecification = new HashSet<ProductSpecification>();
            Remedy = new HashSet<Remedy>();
            SupplierProduct = new HashSet<SupplierProduct>();
        }

        public int ProductBaseId { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Formulation { get; set; }
        public string Registration { get; set; }
        public string Concentration { get; set; }
        public int EntryTypeId { get; set; }
        public int BrandId { get; set; }
        public string Range { get; set; }
        public bool? BrandProductDisplay { get; set; }

        public Brand Brand { get; set; }
        public EntryType EntryType { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<ProductActiveIngredient> ProductActiveIngredient { get; set; }
        public ICollection<ProductAttachment> ProductAttachment { get; set; }
        public ICollection<ProductBaseRemedyType> ProductBaseRemedyType { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
        public ICollection<ProductSpecification> ProductSpecification { get; set; }
        public ICollection<Remedy> Remedy { get; set; }
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
    }
}
