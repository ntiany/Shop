﻿using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }

        public string CurrentCategory { get; set; }
    }
}
