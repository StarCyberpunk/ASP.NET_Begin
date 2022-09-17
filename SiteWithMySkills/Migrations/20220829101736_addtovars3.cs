using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteWithMySkills.Migrations
{
    public partial class addtovars3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("7a098a01-986e-44f8-a08c-1f88c6dd9bcb"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("81e07fc8-c23a-4a87-bdb6-600a1660c43e"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("d9087f4b-68e4-4aff-9221-066b21ef1b2a"));

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "TovarsItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "TovarsItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("7a098a01-986e-44f8-a08c-1f88c6dd9bcb"), 2, "", "book", "wad", 110.0 });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("81e07fc8-c23a-4a87-bdb6-600a1660c43e"), 3, "", "Ker", "wad", 120.0 });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[] { new Guid("d9087f4b-68e4-4aff-9221-066b21ef1b2a"), 0, "", "milk", "wad", 100.0 });
        }
    }
}
