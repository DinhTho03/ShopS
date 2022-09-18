using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopShoes.Migrations
{
    public partial class EditNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userInfos_Product_Products",
                table: "userInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userInfos",
                table: "userInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_accounts",
                table: "accounts");

            migrationBuilder.RenameTable(
                name: "userInfos",
                newName: "UserInfo");

            migrationBuilder.RenameTable(
                name: "accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_userInfos_Products",
                table: "UserInfo",
                newName: "IX_UserInfo_Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfo_Product_Products",
                table: "UserInfo",
                column: "Products",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInfo_Product_Products",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "userInfos");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "accounts");

            migrationBuilder.RenameIndex(
                name: "IX_UserInfo_Products",
                table: "userInfos",
                newName: "IX_userInfos_Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userInfos",
                table: "userInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_accounts",
                table: "accounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userInfos_Product_Products",
                table: "userInfos",
                column: "Products",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
