using Catalog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            IProductServices productServices = new ProductServices();
            List<Product> products = productServices.GetAllProducts();
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