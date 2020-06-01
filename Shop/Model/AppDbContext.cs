using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Shop.Model
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Potions", CategoryDescription = "Little help in a bottle"});
            modelBuilder.Entity<Category>().HasData(new Category{ CategoryId = 2, CategoryName = "Weapons", CategoryDescription = "Crucial for succesful adventure"});
            modelBuilder.Entity<Category>().HasData(new Category{ CategoryId = 3, CategoryName = "Armor", CategoryDescription = "Protect yourself in your journeys"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Junk", CategoryDescription = "Some call it junk, I call it treasure"});

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                Name = "Fire Potion",
                ShortDescription = "Make a small boom",
                LongDescription = "Make a small boom",
                Price = 15M,
                CategoryId = 1,
                InStock = true,
                Popular = true,
                ImageUrl = "/assets/img/fire-potion.png"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 2,
                Name = "Health Potion",
                ShortDescription = "First aid in a bottle",
                LongDescription = "First aid in a bottle",
                Price = 10M,
                CategoryId = 1,
                InStock = true,
                Popular = true,
                ImageUrl = "/assets/img/health-potion.png"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Wind Potion",
                ShortDescription = "Fly to the sky",
                LongDescription = "Fly to the sky",
                Price = 20M,
                CategoryId = 1,
                InStock = true,
                Popular = false,
                ImageUrl = "/assets/img/wind-potion.png"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 4,
                Name = "Poison Potion",
                ShortDescription = "Advantage on your weapon",
                LongDescription = "Advantage on your weapon",
                Price = 10M,
                CategoryId = 1,
                InStock = true,
                Popular = false,
                ImageUrl = "/assets/img/poison-potion.png"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 5,
                Name = "Shield",
                ShortDescription = "Protect yourself from eggs",
                LongDescription = "Protect yourself from eggs",
                Price = 60M,
                CategoryId = 3,
                InStock = true,
                Popular = true,
                ImageUrl = "/assets/img/shield.png"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 6,
                Name = "Axe",
                ShortDescription = "Hand-made!",
                LongDescription = "Hand-made!",
                Price = 80,
                CategoryId = 2,
                InStock = true,
                Popular = false,
                ImageUrl = "/assets/img/axe.png"
            });


             modelBuilder.Entity<Item>().HasData(new Item
             {
                 ItemId = 7,
                 Name = "Chest",
                 ShortDescription = "In case you have property",
                 LongDescription = "In case you have property",
                 Price = 30M,
                 CategoryId = 4,
                 InStock = true,
                 Popular = false,
                 ImageUrl = "/assets/img/chest.png"
             });
        }
    }
}
