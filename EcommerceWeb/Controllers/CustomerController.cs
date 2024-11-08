using CRM;
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
        public ActionResult CustomerIndex()
        {
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