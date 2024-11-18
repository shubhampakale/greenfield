using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerseEntities;
using Specifications;
using BinaryDataRepositoryLib;
using System.IO;

using System.Configuration;
using System.Text.Json;
using JsonDataRepositoryLib;

namespace Services
{
    public class ProductServices : IProductServices
    {
        string realtivePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json_files", "products.json");
        public bool SeedingJSON()
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product { ProductId = 1, Description = "Sun", Quantity = 10, Title = "Star", UnitPrice = 1 });

                IDataRepository < Product > repo =  new JsonRepository<Product> ();
                return repo.Serialize(realtivePath,products);
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        //sample data for testing purpose 
        public bool Seeding()
        {
            bool status = false;


            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1, Description= "Electronic Phones", Quantity =10, Title="Vivo Mobile", UnitPrice=1});
            products.Add(new Product { ProductId = 2, Description = "Laptop", Quantity = 20, Title = "Mac", UnitPrice = 2 });
            products.Add(new Product { ProductId = 3, Description = "Smartwatch", Quantity = 30, Title = "Fastrack", UnitPrice = 3 });

            IDataRepository<Product> repo = new JsonRepository<Product>();
            //string filePath = "C:/Users/shubham.pakale/source/repos/eCommerse/EcommerceWeb/dat_files/products.dat";
            //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "products.dat");
            
            
            //string filePath = (string)ConfigurationManager.AppSettings["ProductDataFilePath"];       // Path from web.config
            
            status = repo.Serialize(realtivePath, products);

            return status;
        }

        public List<Product> GetAllProducts()
        {
           
            List<Product> products = new List<Product>();
            IDataRepository<Product> repository = new JsonRepository<Product>();

            products = repository.Deserialize(realtivePath);
            return products;
        }

        public Product Get(int product_id) 
        {
            Product foundProduct = null;
            List<Product> products = GetAllProducts();


            foreach (Product p in products)
            {
                if(p.ProductId == product_id)
                {
                    foundProduct = p;
                }
            }
            return foundProduct;
        }
     
        public void Insert(Product product) 
        {
            List<Product> products = GetAllProducts();
            
            products.Add(product);
            IDataRepository<Product> repo = new JsonRepository<Product>();
            repo.Serialize(realtivePath, products);

        }

        public bool Update(Product productTobeUpdated)
        {
            Product theProduct = Get(productTobeUpdated.ProductId);
            if(theProduct != null) 
            {
                List<Product> allProducts = GetAllProducts();   
                allProducts.Remove(theProduct);
                allProducts.Add(productTobeUpdated);

                IDataRepository<Product> repo = new JsonRepository<Product>();
                repo.Serialize(realtivePath, allProducts);
            }
            return false;
        }

        public bool Delete(int product_id)
        {
            Product theProduct = Get(product_id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAllProducts();
                allProducts.Remove(theProduct);

                IDataRepository<Product> repo = new JsonRepository<Product>();
                repo.Serialize(realtivePath, allProducts);
            }
            return false;
        }
    }
}
