using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchItWebAPI.Migrations
{
    public partial class CarIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Services",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Services",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Services",
                newName: "id");
        }
    }
}
