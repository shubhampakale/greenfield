using ECommerseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public  interface ICartServices
    {
        bool AddToCart(Items items);
        bool RemoveFromCart(int id);

        bool EmptyCart();

        List<Items> GetAll();
    }
}
