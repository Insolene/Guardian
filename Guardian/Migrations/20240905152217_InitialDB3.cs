using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guardian.Migrations
{
    public partial class InitialDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageRandom",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Shelters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Shelters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRandom",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Shelters");
        }
    }
}
