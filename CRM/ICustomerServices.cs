using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    // Implimenting Prototype , contract , specification, etc.
    public interface ICustomerServices
    {
        List<Customer> GetAllCustomers();        //abstract method
        Customer Get(int id);           //Customer return type 
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(int id);
    }
}
