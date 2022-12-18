using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class UpdateTypeIntegerForColumnPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "OrderDetail",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4861), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4873), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4874), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4875), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5118), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5121), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5122), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5124), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5125), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5128), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5129), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5131), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5132), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5133), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5135), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5136), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5138), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5141), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5143), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5144), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5145), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5146), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5147), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5148), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5149), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5151), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4969), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4973), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4976), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4977), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4982), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4984), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4985), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4986), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4987), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4991), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4993), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4994), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4996), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4998), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5025), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5029), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5033), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5036), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5038), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5041), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5044), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5047), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5049), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5053), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5056), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5057), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5062), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5063), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5067), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5069), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5171), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5173), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5175), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5176), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5178), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5180), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5181), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5182), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5184), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5185), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5186), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5188), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5189), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5191), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5193), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5199), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5201), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5202), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5205), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5206), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5232), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5232), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5237), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5238), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5241), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5241), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5271), new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5271) });
        }
    }
}
