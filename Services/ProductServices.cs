using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specifications;
using BinaryDataRepositoryLib;

namespace Services
{
    public class ProductServices : IProductServices
    {
        //sample data for testing purpose 
        public bool Seeding()
        {
            bool status = false;

            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1, Description= "Sun", Quantity =10, Title="Star", UnitPrice=1});
            products.Add(new Product { ProductId = 2, Description = "Moon", Quantity = 20, Title = "Celetial", UnitPrice = 2 });

            IDataRepository repo = new BinaryRepository();
            status = repo.Serialize("products.dat", products);

            return status;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            IDataRepository repository = new BinaryRepository();

            products = repository.Deserialize("products.dat");
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
            IDataRepository repo = new BinaryRepository();
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

                IDataRepository repo = new BinaryRepository();
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

                IDataRepository repo = new BinaryRepository();
                repo.Serialize("products.dat", allProducts);
            }
            return false;
        }
    }
}
