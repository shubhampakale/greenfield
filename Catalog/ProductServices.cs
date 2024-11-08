using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class ProductServices : IProductServices
    {
        private List<Product> productsList;

        public ProductServices()
        {
            this.productsList = new List<Product>();
            productsList.Add(new Product { ProductId = 1, Description = "Roronoa", Title="Dark King", UnitPrice = 10, Quantity = 28 });
            productsList.Add(new Product { ProductId = 2, Description = "Monkey D Luffy",Title="Sun god", UnitPrice = 100, Quantity = 1 });
        }

        public void Delete(int product_id)
        {
            Product theProduct = this.Get(product_id);
            this.productsList.Remove(theProduct);
        }

        public Product Get(int product_id) {
            foreach (Product product in this.productsList)
            {
                if(product.ProductId == product_id)
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return productsList;
        }

        public void Insert(Product product) { 
            this.productsList.Add(product);
        }
        public void Update(Product product)
        {
            Product theProduct = this.Get(product.ProductId);
            this.productsList.Remove(product);
            this.productsList.Add(product);
        }
    }
}
