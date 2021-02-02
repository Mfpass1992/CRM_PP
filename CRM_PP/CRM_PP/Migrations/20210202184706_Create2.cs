using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_PP.Migrations
{
    public partial class Create2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "surname",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "surname",
                table: "User");
        }
    }
}
