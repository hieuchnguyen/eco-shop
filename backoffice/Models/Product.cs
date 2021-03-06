using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using backoffice.Models.Enums;

namespace backoffice.Models
{
    public class Product : BaseModel
    {
        public Product(string name) : base(name)
        {
        }
        
        public ProductStatus Status { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
    }
}