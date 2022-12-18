using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class DropColumnSizeinTableProductDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "ProductDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3043), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3044), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3284), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3285), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3289), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3295), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3297), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3298), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3133), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3134), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3135), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3136), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3139), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3158), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3192), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3216), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3221), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3222), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3232), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3253), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3254), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3256), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3367), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3371), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3372), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3374), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3377), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3382), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3399), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3401), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3402), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3404), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3405), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3441), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3443), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3445), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3450) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "ProductDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(123), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(487), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(489), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(491), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(497), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(499), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(500), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(504), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(505), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(509), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(511), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(513), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(515), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(297), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(302), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(306), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(307), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(308), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(309), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(313), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(314), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(323), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(325), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(411), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(415), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(416), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(418), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(420), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(421), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(424), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(426), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(427), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(429), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(430), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(432), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(433), "M", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(435), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(436), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(439), "L", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(440), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(442), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(444), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(449), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(450), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(452), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(453), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(455), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(457), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(458), "S", new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(536), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(538), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(539), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(541), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(639), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(641), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(642), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(643), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(644), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(647), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(648), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(651), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(652), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(654), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(655), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(656), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(658), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(659), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(660), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(662), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(664), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(665), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(666), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(670), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(672), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(673), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(703), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(707), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(710), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(710), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(712), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(715), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(715), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(716), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(722) });
        }
    }
}
