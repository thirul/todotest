using NetManage.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetManage.Services.Core
{
    public interface IProductService
    {
         IEnumerable<Product> Get();
    }
}