using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceDALLib.DisConnectedDataAccess;
using ECommerseEntities;

namespace DisConnectedTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAll
            /*List<Product> products = DBManager.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }*

            //Get by Id 
            Product product = new Product();
            int id = Convert.ToInt32(Console.ReadLine());
            product = DBManager.GetById(id);
            Console.WriteLine(product);
            */

            //delete
            /*int id = Convert.ToInt32(Console.ReadLine());
            DBManager.Delete(id);
            List<Product> products = DBManager.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            */

            //insert 
            /*Product product = new Product
            {
                ProductId = 5,
                Title = "Appple vision",
                Description = "AR-VR device",
                UnitPrice = 200000,
                Quantity = 10,
                ImgUrl = "/image/vision.jpg"
            };

            bool isInserted = DBManager.Insert(product);
            if (isInserted)
            {
                Console.WriteLine("Product inserted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to insert the product.");
            }

            List<Product> products = DBManager.GetAll();
            foreach (Product theproduct in products)
            {
                Console.WriteLine(theproduct);
            }
            */

            //update
            /* Product updatedproduct = new Product
            
            
            {
                ProductId = 3, 
                Title = "Airpodes",
                Description = "Earphones",
                UnitPrice = 5000,
                Quantity = 100,
                ImgUrl = "/images/airdopes.jpg"
            };
            bool isUpdated = DBManager.Update(updatedproduct);
            if (isUpdated)
            {
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Failed to update the product.");
            }

            List<Product> products = DBManager.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            */



            Console.ReadLine();
        }
    }
}
