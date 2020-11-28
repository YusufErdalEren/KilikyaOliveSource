using BLLKilikyaOlive.Business;
using BLLKilikyaOlive.Interface;
using DALKilikyaOlive.Interface;
using DALKilikyaOlive.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLKilikyaOlive.CustomIocExtention
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductDal, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
