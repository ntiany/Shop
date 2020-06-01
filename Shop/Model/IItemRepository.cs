using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }

        IEnumerable<Item> PopularItems { get; }

        Item GetItemById(int itemId);
    }
}
