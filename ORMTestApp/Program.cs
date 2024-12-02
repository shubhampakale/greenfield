using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ECommerceDALLib.ORM;
using ECommerseEntities;

namespace ORMTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = DBManager.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}