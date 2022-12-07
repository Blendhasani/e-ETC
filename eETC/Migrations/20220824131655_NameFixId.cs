using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class NameFixId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "AdditionalDatas",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AdditionalDatas",
                newName: "id");
        }
    }
}
