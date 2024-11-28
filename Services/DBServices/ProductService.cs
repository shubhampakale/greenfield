using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerseEntities;
using Specifications;
using ECommerceDALLib;


namespace EcommerseServices.DBServices
{
    public class ProductService : IProductServices
    {
        /*public bool Delete(int id)
        {
            Product theProduct = Get(id);
            // calling functions 

            DBManager.Delete(id);

            return false;
        }

        public Product Get(int id)
        {
            Product foundProduct = DBManager.GetById(id);
            return foundProduct;
        }

        public List<Product> GetAll()
        {
            List<Product> products = DBManager.GetAll();
            return products;
        }

        public bool Insert(Product product)
        {   
            DBManager.Insert(product);
            return true;
        }

        public bool Update(Product productTobeUpdated)
        {
            DBManager.Update(productTobeUpdated);
            return true;
        }*/
        public bool Delete(int id)
        {
            DBManager.Delete(id);

            return false;
        }

        public Product Get(int ProductId)
        {
            Product foundProduct = DBManager.GetById(ProductId);
            return foundProduct;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = DBManager.GetAll();
            return products;
        }

        public void Insert(Product product)
        {
            DBManager.Insert(product);
            //return true;
        }

        public bool Update(Product product)
        {
            DBManager.Update(product);
            return true;
        }
    }
}
