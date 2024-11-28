using ECommerseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Specifications;
using EcommerseServices.DBServices;

namespace AuthWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        
        

        public IEnumerable<Product> Get()    // always returns collection 
        {
            IProductServices svc = new ProductService();
            List<Product> products = svc.GetAllProducts();
            return products;                                                    
        }

        // GET api/values/5
        public Product Get(int id)
        {
            IProductServices svc = new ProductService();
            Product product = svc.Get(id);
            return product;
        }

        // POST api/values
        
        public void Post([FromBody] Product product)
        {
            IProductServices svc = new ProductService();
            svc.Insert(product);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Product product)
        {
            IProductServices svc = new ProductService();
            svc.Update(product);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            IProductServices svc = new ProductService();
            svc.Delete(id);
        }

    }
}
