using System.Collections.Generic;

namespace backoffice.Models
{
    public class Brand : BaseModel
    {
        public Brand(string name) : base(name)
        {
        }

        public IEnumerable<ProductBrand> ProductBrands { get; set; }
    }
}