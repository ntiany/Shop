﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Model;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200522125846_ShoppingCartItem")]
    partial class ShoppingCartItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Little help in a bottle",
                            CategoryName = "Potions"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Crucial for succesful adventure",
                            CategoryName = "Weapons"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Protect yourself in your journeys",
                            CategoryName = "Armor"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Some call it junk, I call it treasure",
                            CategoryName = "Junk"
                        });
                });

            modelBuilder.Entity("Shop.Model.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Popular")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CategoryId = 1,
                            ImageUrl = "/assets/img/fire-potion.png",
                            InStock = true,
                            LongDescription = "Make a small boom",
                            Name = "Fire Potion",
                            Popular = true,
                            Price = 15m,
                            ShortDescription = "Make a small boom"
                        },
                        new
                        {
                            ItemId = 2,
                            CategoryId = 1,
                            ImageUrl = "/assets/img/health-potion.png",
                            InStock = true,
                            LongDescription = "First aid in a bottle",
                            Name = "Health Potion",
                            Popular = true,
                            Price = 10m,
                            ShortDescription = "First aid in a bottle"
                        },
                        new
                        {
                            ItemId = 3,
                            CategoryId = 1,
                            ImageUrl = "/assets/img/wind-potion.png",
                            InStock = true,
                            LongDescription = "Fly to the sky",
                            Name = "Wind Potion",
                            Popular = false,
                            Price = 20m,
                            ShortDescription = "Fly to the sky"
                        },
                        new
                        {
                            ItemId = 4,
                            CategoryId = 1,
                            ImageUrl = "/assets/img/poison-potion.png",
                            InStock = true,
                            LongDescription = "Advantage on your weapon",
                            Name = "Poison Potion",
                            Popular = false,
                            Price = 10m,
                            ShortDescription = "Advantage on your weapon"
                        },
                        new
                        {
                            ItemId = 5,
                            CategoryId = 3,
                            ImageUrl = "/assets/img/shield.png",
                            InStock = true,
                            LongDescription = "Protect yourself from eggs",
                            Name = "Shield",
                            Popular = true,
                            Price = 60m,
                            ShortDescription = "Protect yourself from eggs"
                        },
                        new
                        {
                            ItemId = 6,
                            CategoryId = 2,
                            ImageUrl = "/assets/img/axe.png",
                            InStock = true,
                            LongDescription = "Hand-made!",
                            Name = "Axe",
                            Popular = false,
                            Price = 80m,
                            ShortDescription = "Hand-made!"
                        },
                        new
                        {
                            ItemId = 7,
                            CategoryId = 4,
                            ImageUrl = "/assets/img/chest.png",
                            InStock = true,
                            LongDescription = "In case you have property",
                            Name = "Chest",
                            Popular = false,
                            Price = 30m,
                            ShortDescription = "In case you have property"
                        });
                });

            modelBuilder.Entity("Shop.Model.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Shop.Model.Item", b =>
                {
                    b.HasOne("Shop.Model.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Model.ShoppingCartItem", b =>
                {
                    b.HasOne("Shop.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
