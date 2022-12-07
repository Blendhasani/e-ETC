using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class OrderUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenyraPageses",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NrTel",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Qyteti",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rruga",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenyraPageses",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "NrTel",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Qyteti",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Rruga",
                table: "Orders");
        }
    }
}
