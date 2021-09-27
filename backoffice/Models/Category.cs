using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using backoffice.Models.Enums;

namespace backoffice.Models
{
    public class Category : BaseModel
    {
        public Category(string name) : base(name)
        {
        }
        
        public CategoryType Type { get; set; }
        public IEnumerable<Product> Products { get; set; }

        private void EnsureUpdate()
        {
            UpdatedOn = DateTime.Now;
        }
        
        internal void UpdateName(string name)
        {
            Name = name;
            EnsureUpdate();
        }
    }
}