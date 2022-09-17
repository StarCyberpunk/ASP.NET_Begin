using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteWithMySkills.Migrations
{
    public partial class AddMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1323a3db-e505-4938-93d7-d85512dc1806");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21aeeb72-bca5-45ca-8e07-f56ddbbfe852");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "940ffa41-fb3f-4cf0-8db6-60852287075a");

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("bb8ead99-1ce2-4c3a-a7bd-c8a312eaecee"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("f9529264-8e14-4934-bca7-583426f07af3"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("ff5ceecc-fca9-4b36-9468-9c9b1b11bdd0"));

            migrationBuilder.CreateTable(
                name: "MessageItems",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Messages = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageItems", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14aee0cc-f886-4c2f-ac3b-a56d808e50d3", "f8d0fb7d-7f65-4e39-b2e5-2a8f75f29e66", "Moderator", null },
                    { "7a65a808-d71c-4beb-bb87-6af1fee6d53c", "b723a9d3-0661-453b-b360-46320ed48f25", "Admin", null },
                    { "8bd7a0ea-062c-456a-8490-6e536ab619b7", "a4c40d72-7a23-4a32-b2d8-c7c81efee065", "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[,]
                {
                    { new Guid("2324d568-23cf-4842-8bad-46d6cd546f53"), 3, "ker.jpg", "Ker", "Лук по лбу стук", "120.0" },
                    { new Guid("400f41c0-8618-4800-97a8-528e8ce14a0e"), 2, "book.jpg", "book", "Крутая книга", "110.0" },
                    { new Guid("be1608d5-6306-4a8f-b829-3057d2e1e68b"), 0, "milk.jpg", "milk", "Вкусное молоко", "100.0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14aee0cc-f886-4c2f-ac3b-a56d808e50d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a65a808-d71c-4beb-bb87-6af1fee6d53c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bd7a0ea-062c-456a-8490-6e536ab619b7");

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("2324d568-23cf-4842-8bad-46d6cd546f53"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("400f41c0-8618-4800-97a8-528e8ce14a0e"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("be1608d5-6306-4a8f-b829-3057d2e1e68b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1323a3db-e505-4938-93d7-d85512dc1806", "0b594f33-00c5-4f2e-a3e7-e4d369891cea", "Admin", null },
                    { "21aeeb72-bca5-45ca-8e07-f56ddbbfe852", "0ae7554d-9e92-4727-8c5b-7d364b7121c8", "Moderator", null },
                    { "940ffa41-fb3f-4cf0-8db6-60852287075a", "76705b4e-a100-48ca-88ac-89c84606b910", "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[,]
                {
                    { new Guid("bb8ead99-1ce2-4c3a-a7bd-c8a312eaecee"), 3, "ker.jpg", "Ker", "Лук по лбу стук", "120.0" },
                    { new Guid("f9529264-8e14-4934-bca7-583426f07af3"), 0, "milk.jpg", "milk", "Вкусное молоко", "100.0" },
                    { new Guid("ff5ceecc-fca9-4b36-9468-9c9b1b11bdd0"), 2, "book.jpg", "book", "Крутая книга", "110.0" }
                });
        }
    }
}
