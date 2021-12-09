using Microsoft.EntityFrameworkCore.Migrations;

namespace Winter.Migrations
{
    public partial class updateBlogCategoryPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Page",
                table: "BlogCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Page",
                table: "BlogCategories");
        }
    }
}
