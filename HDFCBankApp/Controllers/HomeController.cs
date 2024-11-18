﻿using HDFCBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string company = "HDFC Bank";
            ViewBag.Company = company;
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Contact cnt = new Contact
            {
                ContactNumber = "9970154890",
                Email = "admin@simplyfHealthcare.com",
                Website = "www.simplyfyhealthcare.com"
            };

            ViewData["contact"] =cnt;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}