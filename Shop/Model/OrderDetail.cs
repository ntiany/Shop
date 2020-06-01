﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public Item Item { get; set; }

        public Order Order { get; set; }
    }
}
