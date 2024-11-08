using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CRM;
using orderProcessing;
using Catalog;
using Taxaction;
using Banking;
using Penalty;

namespace ECommerseTest
{
    /*
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("****************************************** E-Commerse ******************************************\n");
                Console.WriteLine("1.Catalog\n2.CRM\n3.Order Processing\n");
                Console.Write("Enter your choice = ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Product product1 = new Product();
                        product1.ProductId = 101;
                        product1.Title = "Vivo Y71 5G ";
                        product1.Description = "Smart Phone with 5G Connectivity";
                        product1.Quantity = 10;
                        product1.UnitPrice = 30000;
      
                        break;

                    case 2:
                        Console.WriteLine("");
                        Customer customer1 = new Customer();
                        customer1.CustomerId = 1;
                        customer1.FirstName = "Shubh";
                        customer1.LastName = "Pakale";
                        customer1.Email = "shubh.pakale28@gmail.com";
                        customer1.Contact = "9970154890";

                        Customer customer2 = new Customer();
                        customer2.CustomerId = 2;
                        customer2.FirstName = "Labh";
                        customer2.LastName = "Pakale";
                        customer2.Email = "Test@email.com";
                        customer2.Contact = "101";

                        ICustomerServices customerService = new CustomerServices();
                        customerService.Insert(customer1);
                        customerService.Insert(customer2);

                        List<Customer> list = customerService.GetAllCustomers();
                        foreach (Customer customer in list)
                        {
                            Console.WriteLine("Customer ID = "+customer.CustomerId);
                            Console.WriteLine("First name = " + customer.FirstName);
                            Console.WriteLine("Last name = " + customer.LastName);
                            Console.WriteLine("email = " + customer.Email);
                            Console.WriteLine("contact = " + customer.Contact);
                            Console.WriteLine("");

                        }
                        break;

                    case 3:
                        Console.WriteLine("");
                        Order order1 = new Order();
                        order1.OrderId = 1;
                        order1.amount = 100;
                        order1.date = new DateTime(2024,05,28);
                        order1.Status = "Delivered";

                        Order order2 = new Order();
                        order2.OrderId = 2;
                        order2.amount = 200;
                        order2.date = new DateTime(2025,05,28);
                        order2.Status = "Dispached";


                        IOrderServices orderService = new OrderServices();
                        orderService.Insert(order1);
                        orderService.Insert(order2);

                        List<Order> orderlist = orderService.GetAllOrders();
                        foreach (Order order in orderlist)
                        {
                            Console.WriteLine("Order ID = " + order.OrderId);
                            Console.WriteLine("Order amount = " + order.amount);
                            Console.WriteLine("Order date = " + order.date);
                            Console.WriteLine("Order Status = " + order.Status);
                            Console.WriteLine("");
                        }
                        break;

                }
            }
            while (choice != 0);
        }
    }
    */

    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            //Handler.PayGSTTax();
            //Handler.PayProffesionalTax();
            //Handler.PayIncomeTax();

            //Operation opn1 = new Operation(TaxHandler.PayServiceTax); // addresss of function
            //Operation opn2 = new Operation(TaxHandler.PayIncomeTax);
            //Operation opn3 = new Operation(TaxHandler.PayGSTTax);
            
            Operation masterOperation = null;
            masterOperation += opn1;
            masterOperation += opn2;
            masterOperation += opn3;    
            masterOperation.Invoke(30);

            Console.WriteLine("After detachment");
            masterOperation -=opn3 ;    // De-chaining
            masterOperation.Invoke(56);
            */

            //object creation 
            Account act = new Account(15000);

            //event registration
            act.underBalance +=  Penalty.Penalty.NoificationPenalty;
            act.underBalance += Penalty.Penalty.ServiceDissconnectionPenalty;
            act.overBalance += Taxaction.Taxaction.PayIncomeTax;

            //invocation
            //act.Withdraw(8000);
            act.Deposit(300000);    //These functions are in banking dll in account class       


            Console.ReadLine();

        }

    }
   


}

