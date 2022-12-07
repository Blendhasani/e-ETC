using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class NameFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "States",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "States",
                newName: "StateId");
        }
    }
}
