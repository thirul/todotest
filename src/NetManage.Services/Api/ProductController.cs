using NetManage.Services.Core;
using NetManage.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetManage.Services.api
{
    [RoutePrefix("api")]    
    public class ProductController : ApiController
    {
        IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("products")]
        [HttpGet]
        public IHttpActionResult GetProducts()
        {
            return Ok(productService.Get());
        }

        [Route("product/{id}")]
        [HttpGet]
        public IHttpActionResult GetProducts(int id)
        {
            var products = productService.Get();
            var product = products.FirstOrDefault(x => x.Id == id);

            return Ok(product);
        }

        [Route("product")]
        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {            
            return Ok(product);
        }

      

    }

   
}
