using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteWithMySkills.Migrations
{
    public partial class AddRosles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("525c5ea5-9ee3-42ba-a0cf-00b98b6bf629"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("66d6729a-092c-4b5f-b148-d2170fa38c00"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("c199e432-b1e0-4581-b672-26eef683fc20"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b7ff66ca-62cc-4e2e-913a-a6bb2eaf2e3b", "7dc1e059-f860-4738-8472-206725bf1832", "Moderator", null },
                    { "cb8cd377-44df-4e2a-9f1d-f6442677b8d0", "9324a267-ba9f-49ef-825c-4aab7351c864", "Admin", null },
                    { "d2592c71-1ac3-4c49-afb0-99970059c6ff", "1d63f1a9-2e27-46f6-bc36-099312b4cf61", "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[,]
                {
                    { new Guid("2146b2e7-f7d1-414f-9203-9a114987d7b0"), 2, "", "book", "wad", "110.0" },
                    { new Guid("6945bdc0-db2b-473b-8cfa-3b81b4ab0f99"), 0, "", "milk", "wad", "100.0" },
                    { new Guid("9c77a65e-9042-47d4-9ad9-68fd6aefddac"), 3, "", "Ker", "wad", "120.0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7ff66ca-62cc-4e2e-913a-a6bb2eaf2e3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb8cd377-44df-4e2a-9f1d-f6442677b8d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2592c71-1ac3-4c49-afb0-99970059c6ff");

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("2146b2e7-f7d1-414f-9203-9a114987d7b0"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("6945bdc0-db2b-473b-8cfa-3b81b4ab0f99"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("9c77a65e-9042-47d4-9ad9-68fd6aefddac"));

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("525c5ea5-9ee3-42ba-a0cf-00b98b6bf629"), 0, "", "milk", "wad", "100.0" });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("66d6729a-092c-4b5f-b148-d2170fa38c00"), 3, "", "Ker", "wad", "120.0" });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("c199e432-b1e0-4581-b672-26eef683fc20"), 2, "", "book", "wad", "110.0" });
        }
    }
}
