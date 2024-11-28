using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseEntities
{
    //Bussines entity class which contains only data
    // are called poco classes in .net
    //POCO = Plain old clr object

    //[Serializable]
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int UnitPrice { get; set;}

        public int Quantity { get; set;}
        public string ImgUrl { get; set;}

    }
   
}
