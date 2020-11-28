using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLLKilikyaOlive.Interface;
using Microsoft.AspNetCore.Mvc;
using PLKilikyaOlive.Models;

namespace PLKilikyaOlive.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;


        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult List(int productGroupId)
        {
            var list = new List<ProductViewModel>();

            var productList = _productService.GetProducts(productGroupId);

            foreach (var item in productList)
            {
                var product = new ProductViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price
                };

                list.Add(product);
            }

            return View(list);
        }
    }
}
