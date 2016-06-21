using NetManage.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetManage.Services.Core
{
    public class ProductService: IProductService
    {
        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product{Id=1,Name="Learn MVC", Price=12.45},
                new Product{Id=2,Name="Learn Angular", Price=22.45}
            };
        }
    }
}