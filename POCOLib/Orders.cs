﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseEntities
{
    public class Orders
    {
        public int OrderId { get; set; } //auto property

        public DateTime date { get; set; }  // date to be figured out

        public int amount { get; set; }

        public string Status { get; set; }

    }
}
