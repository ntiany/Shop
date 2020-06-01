using Shop.Model;

using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> PopularItems { get; set; }
    }
}
