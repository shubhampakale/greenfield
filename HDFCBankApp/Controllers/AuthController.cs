using HDFCBankApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class AuthController : Controller
    {
        AuthServices authServices =  new AuthServices();

        public AuthController()
        {
           
        }

        public ActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            
            bool status = authServices.Login(email, password);
            if (status)
            {
                HttpContext.Session["logedinUser"] = email;
                return RedirectToAction("welcome");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult welcome()
        {
            string email = HttpContext.Session["logedinUser"] as string;
            ViewBag.Email = email;
            return View();
        }



    }
}