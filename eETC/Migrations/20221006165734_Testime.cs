using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class Testime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KohaArritjes",
                table: "AdditionalDatas");

            migrationBuilder.AddColumn<int>(
                name: "MenyraPageses",
                table: "AdditionalDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenyraPageses",
                table: "AdditionalDatas");

            migrationBuilder.AddColumn<DateTime>(
                name: "KohaArritjes",
                table: "AdditionalDatas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
