using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specifications;
using BinaryDataRepositoryLib;
using System.IO;

using System.Configuration;
using System.Text.Json;

namespace Services
{
    public class ProductServices : IProductServices
    {
        public bool SeedingJSON()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1, Description = "Sun", Quantity = 10, Title = "Star", UnitPrice = 1 });
            string json = JsonSerializer.Serialize(products);
            string jsonfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json_files", "products.json");
            //File.WriteAllText(jsonfile,);

            return false;
        }
        //sample data for testing purpose 
        public bool Seeding()
        {
            bool status = false;


            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1, Description= "Sun", Quantity =10, Title="Star", UnitPrice=1});
            products.Add(new Product { ProductId = 2, Description = "Moon", Quantity = 20, Title = "Celetial", UnitPrice = 2 });
            products.Add(new Product { ProductId = 3, Description = "Planet", Quantity = 30, Title = "Fastest", UnitPrice = 3 });

            IDataRepository<Product> repo = new BinaryRepository<Product>();
            //string filePath = "C:/Users/shubham.pakale/source/repos/eCommerse/EcommerceWeb/dat_files/products.dat";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "products.dat");
            
            
            //string filePath = (string)ConfigurationManager.AppSettings["ProductDataFilePath"];       // Path from web.config
            
            status = repo.Serialize(filePath, products);

            return status;
        }

        public List<Product> GetAllProducts()
        {
            //string filePath = "C:/Users/shubham.pakale/source/repos/eCommerse/EcommerceWeb/dat_files/products.dat";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "products.dat");
            List<Product> products = new List<Product>();
            IDataRepository<Product> repository = new BinaryRepository<Product>();

            products = repository.Deserialize(filePath);
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
     
        public bool Insert(Product product) 
        {
            List<Product> products = GetAllProducts();
            
            products.Add(product);
            IDataRepository<Product> repo = new BinaryRepository<Product>();
            repo.Serialize("products.dat",products);

            return true;
        }

        public bool Update(Product productTobeUpdated)
        {
            Product theProduct = Get(productTobeUpdated.ProductId);
            if(theProduct != null) 
            {
                List<Product> allProducts = GetAllProducts();   
                allProducts.Remove(theProduct);
                allProducts.Add(productTobeUpdated);

                IDataRepository<Product> repo = new BinaryRepository<Product>();
                repo.Serialize("products.dat", allProducts);
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

                IDataRepository<Product> repo = new BinaryRepository<Product>();
                repo.Serialize("products.dat", allProducts);
            }
            return false;
        }
    }
}
