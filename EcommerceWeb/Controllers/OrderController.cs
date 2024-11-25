using ECommerseEntities;
using orderProcessing;
using System;
using EcommerseServices;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace EcommerceWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BuyAll()
        {
            Cart cart = this.HttpContext.Session["myCart"] as Cart;
            CartServices cartService = new CartServices(cart);
            Random rand = new Random();
            Order order = new Order { OrderId = rand.Next(100000, 9999999), Cart = cart, OrderAmount = cartService.GetTotal(), OrderDate = DateTime.Now, Status = "Delivered" };

            List<Order> orders = orderRepo.Deserialize<Order>(filepath);
            orders.Add(order);
            orderRepo.Serialize(filepath, orders);
            cartService.ClearCart();

            return RedirectToAction("Index", "Product");
        }
    }
}