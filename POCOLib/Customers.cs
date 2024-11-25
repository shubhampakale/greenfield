using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseEntities
{
    public class Customers
    {
        public int CustomerId { get; set; } //auto property

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }
    }
}
