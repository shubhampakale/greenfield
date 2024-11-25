using ECommerseEntities;
using Services;
using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class ShoppingController : Controller
    {
        ICartServices cartServices = null;
        IProductServices productServices = null;
        
        public ShoppingController()
        {
            productServices = new ProductServices();
           
        }

        // GET: Shopping
        public ActionResult Index()
        {
            cartServices = new CartServices(HttpContext.Session["cart"] as Cart);
            List<Items> cart =  cartServices.GetAll();
            //cart.items.product id 
            
            ViewBag.Cart = cart;
            return View();
        }
        
        /*
         
        shopping cart ---> order placement 
        order amount 
        order seeding remove 
        Place order 


         
         */


        public ActionResult AddToCart(int id )
        {
            Product product = new Product();
            product = productServices.Get(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult AddToCart(Items items)
        {
            cartServices = new CartServices(HttpContext.Session["cart"] as Cart);
            cartServices.AddToCart(items);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            cartServices = new CartServices(HttpContext.Session["cart"] as Cart);
            cartServices.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}