using CoreKilikyaOlive.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALKilikyaOlive.Interface
{
    public interface IProductDal
    {
        List<Product> GetProducts(int productGroupId);
    }
}
