using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteWithMySkills.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "282cb2fb-7509-4ef7-b09c-0496fed6a341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b27efba-a6c7-44d3-ae34-56956c9a2f5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51cf6f04-cee8-4ded-b649-cab97d0e45e8");

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("0f404dfc-9f4f-4e4d-ad7a-07e11691fc2d"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("db598935-1382-4e00-986f-37656267cb4f"));

            migrationBuilder.DeleteData(
                table: "TovarsItems",
                keyColumn: "id",
                keyValue: new Guid("f2198c93-7df6-4f76-8318-2d3f4bb49ffb"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "282cb2fb-7509-4ef7-b09c-0496fed6a341", "b3bbf112-be66-4756-a949-cd56329ba42c", "Guest", null },
                    { "3b27efba-a6c7-44d3-ae34-56956c9a2f5b", "8d144f7c-2b31-4cfb-be52-a217b780ca11", "Moderator", null },
                    { "51cf6f04-cee8-4ded-b649-cab97d0e45e8", "8664d825-83f0-43d7-8ab7-02d9e12c89f1", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "TovarsItems",
                columns: new[] { "id", "IdType", "Img", "Name", "Opisanie", "Price" },
                values: new object[,]
                {
                    { new Guid("0f404dfc-9f4f-4e4d-ad7a-07e11691fc2d"), 2, "", "book", "wad", "110.0" },
                    { new Guid("db598935-1382-4e00-986f-37656267cb4f"), 3, "", "Ker", "wad", "120.0" },
                    { new Guid("f2198c93-7df6-4f76-8318-2d3f4bb49ffb"), 0, "", "milk", "wad", "100.0" }
                });
        }
    }
}
