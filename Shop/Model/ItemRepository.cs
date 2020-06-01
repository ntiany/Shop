using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> AllItems
        {
            get
            {
                return _appDbContext.Items.Include(i => i.Category);
            }
        }

        public IEnumerable<Item> PopularItems => _appDbContext.Items.Where(x => x.Popular == true).Include(x => x.Category).ToList();

        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.ItemId == itemId);
        }
    }
}
