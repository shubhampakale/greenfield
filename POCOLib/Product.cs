using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ECommerseEntities
{
    //Bussines entity class which contains only data
    // are called poco classes in .net
    //POCO = Plain old clr object

    //[Serializable]
    [Table("products_shubham")]
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set;}

        public int Quantity { get; set;}
        public string ImgUrl { get; set;}

        public override string ToString()
        {
            return ProductId + " " + Title + " " + Description;
        }

    }   

}
