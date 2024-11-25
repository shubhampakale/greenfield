using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using ECommerseEntities;

namespace SerializationTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductServices services = new ProductServices();
            services.Seeding();

            List<Product> allProducts = services.GetAllProducts();
            foreach(Product p in allProducts)
            {
                Console.WriteLine(p.ProductId + " " + p.Title + " " + p.Description + " " + p.UnitPrice + " " + p.Quantity);
            }

            Console.ReadLine();
        }
    }
}
