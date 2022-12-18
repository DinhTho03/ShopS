using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class EditTypeDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductDetail",
                type: "Nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1736), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1757), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1759), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1761), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2364), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2366), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2368), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2370), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2373), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2374), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2377), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2381), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2382), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2384), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2385), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2387), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2398), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2401), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2405), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2409), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2415), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2418), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2421), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2425), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2428), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2430), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2434), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1995), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1997), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2005), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2010), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2024), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2029), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2031), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2036), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2043), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2046), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2113), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2116), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2121), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2124), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2129), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2132), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2138), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2141), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2145), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2150), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2153), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2156), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2159), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2162), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2291), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2295), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2299), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2302), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2307), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2309), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2312), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2314), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2470), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2475), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2479), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2481), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2486), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2491), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2497), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2547), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2549), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2551), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2553), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2555), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2558), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2569), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2571), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2574), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2576), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2580), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2584), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2587), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2589), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2593), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2595), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2596), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2598), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2600), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2605), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2608), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2706), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2708), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2713), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2717), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2723), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2726), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2727), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2731), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2732), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2736), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2737), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2738), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 11, 18, 9, 44, 46, 728, DateTimeKind.Local).AddTicks(2740) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ProductDetail",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1729), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1740), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1741), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1742), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1994), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1995), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1997), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2001), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2002), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2004), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2005), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2008), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2009), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2010), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2014), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2018), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2020), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2021), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1822), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1824), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1827), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1831), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1832), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1833), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1836), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1838), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1839), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1841), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1845), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1846), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1847), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1848), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1849), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1851), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1852), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1876), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1879), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1883), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1936), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1937), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1939), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1941), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1945), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1954), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1955), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1959), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1966), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2039), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2040), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2044), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2045), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2046), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2047), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2051), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2054), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2055), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2057), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2063), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2064), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2067), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2068), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2069), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2070), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2071), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2073), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2074), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2149), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2173), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2173), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2175), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2176), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2177), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2178), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2181), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2182), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2185), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2185), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2191), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2191), new DateTime(2022, 11, 17, 23, 27, 36, 912, DateTimeKind.Local).AddTicks(2192) });
        }
    }
}
