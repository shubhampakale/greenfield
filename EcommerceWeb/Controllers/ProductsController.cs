using Services;
using Specifications;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerseEntities;

namespace EcommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        ProductServices services = new ProductServices();
        // GET: Products
        public ActionResult ProductIndex()
        {
            //services.Seeding();
            List<Product> products = services.GetAllProducts();
            return View(products);
        }
        public ActionResult ProductDetails(int id)
        {
            Product product = services.Get(id);
            return View(product);
        }
        public ActionResult ProductInsert()
        {
            return View();
        }
        public ActionResult ProductUpdate()
        {
            return View();
        }
        public ActionResult ProductDelete()
        {
            return View();
        }
    }
}