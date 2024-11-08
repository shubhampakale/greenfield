using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerServices : ICustomerServices
    {
        private List<Customer> customerList;
        public CustomerServices() { 
            this.customerList = new List<Customer>();
            customerList.Add(new Customer {CustomerId = 1, FirstName="Shubh", LastName="Pakale", Contact="9970154890", Email="shubh@gmail.com"});
            customerList.Add(new Customer { CustomerId = 2, FirstName = "Labh", LastName = "Pakale", Contact = "9822786321", Email = "Labh@gmail.com" });

        }
        public bool Delete(int id)
        {
            Customer theCustomer = this.Get(id);
            return this.customerList.Remove(theCustomer);

        }

        public Customer Get(int id)
        {
            foreach (Customer customer in customerList) {
            if(customer.CustomerId == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public List<Customer> GetAllCustomers()
        {
            return customerList;
        }

        public bool Insert(Customer customer)
        {
            this.customerList.Add(customer);
            return true;
        }

        public bool Update(Customer customer)
        {
            Customer theCustomer = this.Get(customer.CustomerId);
            this.customerList.Remove(theCustomer);
            this.customerList.Add(customer);
            return true;

        }
    }
}
