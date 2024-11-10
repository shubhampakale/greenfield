using Services;
using Specifications;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO;

namespace EcommerceWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductIndex()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            ProductServices services = new ProductServices();
            services.Seeding();
            List<Product> products = services.GetAllProducts();
            return View(products);
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