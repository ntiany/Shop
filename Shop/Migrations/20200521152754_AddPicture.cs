using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class AddPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/assets/img/chest.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "ImageUrl",
                value: "assets/img/chest.png");
        }
    }
}
