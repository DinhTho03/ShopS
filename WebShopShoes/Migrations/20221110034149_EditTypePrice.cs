using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class EditTypePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5025), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5028), 189, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5029), 173, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5031), 120, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5033), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5034), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5036), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5038), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5039), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5041), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5043), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5044), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5046), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5047), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5049), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5050), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5053), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5054), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5056), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5057), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5060), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5062), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5063), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5065), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5067), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5069), 213, new DateTime(2022, 11, 10, 10, 41, 48, 491, DateTimeKind.Local).AddTicks(5069) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ProductDetail",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3216), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3219), 189.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3221), 173.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3222), 120.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3223), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3225), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3227), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3230), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3232), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3233), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3235), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3237), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3238), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3240), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3241), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3243), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3244), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3246), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3247), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3249), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3251), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3253), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3254), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3256), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3257), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Price", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3259), 213.0, new DateTime(2022, 11, 10, 10, 15, 48, 256, DateTimeKind.Local).AddTicks(3259) });

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
    }
}
