using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteWithMySkills.Migrations
{
    public partial class AddWeather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vlaga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Td = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NaprVet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeedVetra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oblach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    h = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pogoda = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");

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
    }
}
