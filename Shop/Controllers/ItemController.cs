using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Model;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();
            return View(item);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Item> items;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.AllItems.OrderBy(i => i.Name);
                currentCategory = "All items";
            }
            else
            {
                items = _itemRepository.AllItems.Where(i => i.Category.CategoryName == category)
                    .OrderBy(i => i.Name);
                currentCategory = category;
            }

            return View(new ItemListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            });
        }
    }
}