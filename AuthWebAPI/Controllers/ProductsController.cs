using ECommerseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Specifications;
using Services;

namespace AuthWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/values
        // Action verbs 
        // Api controllers 
        //IProductServices svc = null;
        // IDataRepository<Product> repository = new JsonRepository<Product>();
        ProductServices svc = null;
        ProductsController()
        {
             svc  = new ProductServices();
            
     
        }
        

        public IEnumerable<Product> Get()    // always returns collection 
        {
            svc.SeedingJSON();
            List<Product> products = svc.GetAllProducts();
            return products;                                                    
        }

        // GET api/values/5
        public Product Get(int id)
        {
           
            Product product = svc.Get(id);
            return product;
        }

        // POST api/values
        
        public void Post([FromBody] Product product)
        {
            svc.Insert(product);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Product product)
        {
            svc.Update(product);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            svc.Delete(id);
        }
    }
}
