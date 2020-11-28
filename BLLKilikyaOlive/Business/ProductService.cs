using BLLKilikyaOlive.Interface;
using CoreKilikyaOlive.Entity;
using DALKilikyaOlive.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLKilikyaOlive.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetProducts(int productGroupId)
        {
           return _productDal.GetProducts(productGroupId);
        }
    }
}
