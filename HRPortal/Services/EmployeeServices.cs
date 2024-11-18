using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using HRPortal.Repository;



namespace HRPortal.Services
{
    public class EmployeeServices : IEmployees
    {
        string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json_files", "employee.json");

    


        public void Seeding()
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees { Id=1,Name="Steve",BasicSalary=10000,DailyAllowance=3000,Workingdays=30,IsConfirmed=true,Joindate= new DateTime(2024,05,28)});

            IDataRepository<Employees> repo = new JsonDataRepository<Employees>();
            repo.Serialize(relativePath, employees);
        }
 
            
        
        public Employees Get(int employee_id)
        {
            Employees foundProduct = null;
            List<Employees> employee = GetAllEmployees();

            foreach (Employees e in employee)
            {
                if (e.Id == employee_id)
                {
                    foundProduct = e;
                }
            }
            return foundProduct;
        }

        public List<Employees> GetAllEmployees()
        {
       
            List<Employees> employees = new List<Employees>();
            IDataRepository<Employees> repository = new JsonDataRepository<Employees>();

            employees = repository.Deserialize(relativePath);
            return employees;
        }

        public void Create(Employees employee)
        {  
            List<Employees> emp = new List<Employees>();
            emp = GetAllEmployees();
            emp.Add(employee);
            IDataRepository<Employees> repo = new JsonDataRepository<Employees>();
            repo.Serialize(relativePath, emp);
        }

        public bool Delete(int Id)
        {
            Employees theEmployee = Get(Id);
            if (theEmployee != null)
            {
                List<Employees> allEmployee = GetAllEmployees();
                

                allEmployee = allEmployee.FindAll((e) => e.Id != Id);

                IDataRepository<Employees> repo = new JsonDataRepository<Employees>();
                repo.Serialize(relativePath, allEmployee);
                return true;
            }
            return false;
        }

        public bool Update(Employees employeeToBeInserted)
        {
            Employees theEmployee = Get(employeeToBeInserted.Id);
            if (theEmployee != null)
            {
                List<Employees> allEmployee = GetAllEmployees();
                allEmployee = allEmployee.FindAll((e) => e.Id != employeeToBeInserted.Id);

                allEmployee.Add(employeeToBeInserted);

                IDataRepository<Employees> repo = new JsonDataRepository<Employees>();
                repo.Serialize(relativePath, allEmployee);
            }
            return false;
        }
    }
}