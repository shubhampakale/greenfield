using ECommerseEntities;
using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CartServices : ICartServices
    {
         Cart thecart = null;
        //Get


        //Dependency Injection 
        public CartServices(Cart cart)
        {
            this.thecart = cart;
        }

        public bool AddToCart(Items items)
        {
            this.thecart.Items.Add(items);
            return false;
        }

        public bool EmptyCart()
        {
            this.thecart.Items.Clear();
            return false;

        }
        public Product GetById(int id)
        {
            Product theproduct = new Product();
            return theproduct;
        }

        public List<Items> GetAll()
        {
           return thecart.Items;
        }

        public bool RemoveFromCart(int id)
        {
            thecart.Items.RemoveAll(item => (item.ProductId == id));
            return false;
        }
    }
}
