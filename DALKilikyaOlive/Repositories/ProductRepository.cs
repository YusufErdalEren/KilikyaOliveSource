using CoreKilikyaOlive.Entity;
using DALKilikyaOlive.Interface;
using DALKilikyaOlive.KilikyaOliveContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALKilikyaOlive.Repositories
{
    public class ProductRepository : IProductDal
    {
        public List<Product> GetProducts(int productGroupId)
        {
            var productList = new List<Product>();

            using (var context = new KilikyaContext())
            {
                productList = context.Products.Where(x => x.ProductGroupId == productGroupId).ToList();
            }

            return productList;
        }
    }
}
