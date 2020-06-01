using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Little help in a bottle", "Potions" },
                    { 2, "Crucial for succesful adventure", "Weapons" },
                    { 3, "Protect yourself in your journeys", "Armor" },
                    { 4, "Some call it junk, I call it treasure", "Junk" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "assets/img/fire-potion.png", true, "Make a small boom", "Fire Potion", 15m, "Make a small boom" },
                    { 2, 1, "assets/img/health-potion.png", true, "First aid in a bottle", "Health Potion", 10m, "First aid in a bottle" },
                    { 3, 1, "assets/img/wind-potion.png", true, "Fly to the sky", "Wind Potion", 20m, "Fly to the sky" },
                    { 4, 1, "assets/img/poison-potion.png", true, "Advantage on your weapon", "Poison Potion", 10m, "Advantage on your weapon" },
                    { 6, 2, "assets/img/axe.png", true, "Hand-made!", "Axe", 80m, "Hand-made!" },
                    { 5, 3, "assets/img/shield.png", true, "Protect yourself from eggs", "Shield", 60m, "Protect yourself from eggs" },
                    { 7, 4, "assets/img/chest.png", true, "In case you have property", "Chest", 30m, "In case you have property" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
