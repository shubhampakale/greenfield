using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            string themessage = "Account processing ";
            TempData["mymessage"] = themessage;
            return View();
        }

        public ActionResult Process()
        {
            string theMessage = TempData["mymessage"] as string;
            ViewData["processmessage"]=theMessage;
            return View();
        }

        
    }
}