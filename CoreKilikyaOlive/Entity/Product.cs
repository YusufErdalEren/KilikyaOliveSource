using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKilikyaOlive.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductGroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
