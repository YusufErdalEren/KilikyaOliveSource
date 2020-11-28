using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKilikyaOlive.Entity
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
