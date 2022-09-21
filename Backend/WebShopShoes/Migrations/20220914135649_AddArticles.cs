using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopShoes.Migrations
{
    public partial class AddArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Articles",
                table: "userInfos",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articles",
                table: "userInfos");
        }
    }
}
