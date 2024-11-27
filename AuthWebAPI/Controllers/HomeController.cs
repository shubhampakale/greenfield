using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Specifications;
using ECommerseEntities;
using EcommerseServices;
namespace AuthWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email,string password) { 
            IAuthServices svc = new AuthServices();
            if(svc.Login(email, password))
            {
                var s = "Login Successful";
                return Json(s,JsonRequestBehavior.AllowGet);
            }
            else
            {
                var ss = "Login Failed ";
                return Json(ss,JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Storage()
        {
            return View();
        }
        public ActionResult JQueryDemo()
        {
            return View();
        }

        public ActionResult ClientLogin()
        {
            return View();
        }

        public ActionResult ClientRegister()
        {
            return View();
        }

        public ActionResult Grid()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

    }
}
