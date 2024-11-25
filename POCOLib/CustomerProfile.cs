using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseEntities
{
    public class CustomerProfile
    {
        public Customers thecustomer {  get; set; }

        public List<Orders> orderhistory { get; set; }
    }
}
