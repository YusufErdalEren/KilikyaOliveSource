using CoreKilikyaOlive.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLKilikyaOlive.Interface
{
    public interface IProductService
    {
        List<Product> GetProducts(int productGroupId);
    }
}
