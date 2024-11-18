using HRPortal.Models;
using HRPortal.Repository;
using HRPortal.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeServices e_service = new EmployeeServices();
        // GET: Employees
        public ActionResult Index()
        {
            List<Employees> emp =  e_service.GetAllEmployees();
            return View(emp);
        }


        //Done
        public ActionResult Details(int id ) 
        {
            Employees emp =  e_service.Get( id );   
            return View(emp);
        }
        //Done
        public ActionResult Create() 
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Employees emp)
        {
            List<Employees> allemp = e_service.GetAllEmployees();
            allemp.Add(emp);

            IDataRepository<Employees> repo = new JsonDataRepository<Employees>();
            repo.Serialize(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json_files", "employee.json"), allemp);
            return RedirectToAction("Index");
        }

       

        public ActionResult Edit(int id)
        {
            Employees emp = e_service.Get( id );
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employees emp)
        {
            e_service.Update( emp );
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete(int id) 
        {
           
            bool isDeleted = e_service.Delete( id );
            if(isDeleted ) {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
            
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}