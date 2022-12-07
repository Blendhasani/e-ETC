using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class Disa_Testime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Cash",
                table: "AdditionalDatas");

            migrationBuilder.DropColumn(
                name: "Transporti",
                table: "AdditionalDatas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "AdditionalDatas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Transporti",
                table: "AdditionalDatas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
