using CRM;
using ECommerseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerProfile theProfile = new CustomerProfile();
            theProfile.thecustomer = new Customers
            {
                CustomerId = 1,
                FirstName = "Nikola",
                LastName = "Tesla",
                Email = "AC_Current@tesla.com",
                Contact = "9970154890"
            };

            theProfile.orderhistory = new List<Orders>();
            theProfile.orderhistory.Add(new Orders { OrderId=1, amount=1500, Status="Delivered", date=DateTime.Now});
            theProfile.orderhistory.Add(new Orders { OrderId=2, amount=3000, Status="Canceled", date=DateTime.Now});

            ViewData["theprofile"] = theProfile;

            return View();
        }
        public ActionResult CustomerDetails() 
        {   
            ICustomerServices customerServices = new CustomerServices();
            List<Customer> customers = customerServices.GetAllCustomers();
            return View(customers);
        }

        [HttpPost]
        public ActionResult CustomerInser(Customer customer) 
        {
            if (ModelState.IsValid)
            {
                ICustomerServices customersServices = new CustomerServices();
                bool isInserted = customersServices.Insert(customer);
                if (isInserted)
                {
                    return RedirectToAction("CustomerDetails");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to insert customer.");
                    return View(customer);
                }
            }
            else
            {
                ModelState.AddModelError("", "Failed to insert customer.");
                return View(customer);
            }
             
        }
        public ActionResult CustomerInsert()
        {
            return View();
        }

        public ActionResult CustomerUpdate()
        {
            return View();
        }
        public ActionResult CustomerDelete()
        {
            return View();
        }

    }
}