using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using ECommerseEntities;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
namespace ECommerceDALLib.ORM
{


    public class ECommerceContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ECommerceContext() : base("name=conString") { }
    }

    public static class DBManager
    {
        public static void Delete(int id)
        {
            //string str_Id = id.ToString();
            using (var context = new ECommerceContext())
            {
                var product = context.Products.SingleOrDefault(s => s.ProductId == id);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }


        }
        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            using (var context = new ECommerceContext())
            {
                var dbProducts = context.Products.ToList();
                foreach (var product in dbProducts)
                {
                    Product theProduct = new Product();
                    theProduct.Title = product.Title;
                    theProduct.Description = product.Description;
                    theProduct.Quantity = product.Quantity;
                    theProduct.ImgUrl = product.ImgUrl;
                    theProduct.UnitPrice = product.UnitPrice;
                    theProduct.ProductId = product.ProductId;
                    products.Add(product);
                }
            }
            return products;
        }

        public static Product GetById(int id)
        {
            Product product = null;
            //string str_Id = id.ToString();
            using (var context = new ECommerceContext())
            {
                product = context.Products.SingleOrDefault(s => s.ProductId == id);

            }
            return product;
        }
        public static bool Insert(Product product)
        {
            bool status = false;
            using (var context = new ECommerceContext())
            {
                context.Products.Add(product);
            }
            return status;
        }

        public static bool Update(Product product)
        {
            bool status = false;

            using (var context = new ECommerceContext())
            {
                var foundDroduct = context.Products.SingleOrDefault(s => s.ProductId == product.ProductId);
                if (foundDroduct != null)
                {
                    foundDroduct.Title = product.Title;
                    foundDroduct.Description = product.Description;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }


            return status;
        }

    }


}