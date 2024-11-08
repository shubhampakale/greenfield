using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowCart()
        {
            return View();
        }
        public ActionResult AddToCart()
        {
            return View();
        }
        public ActionResult RemoveFromCart()
        {
            return View();
        }
    }
}