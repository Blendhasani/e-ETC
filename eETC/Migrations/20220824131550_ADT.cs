using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class ADT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transporti = table.Column<bool>(type: "bit", nullable: false),
                    Cash = table.Column<bool>(type: "bit", nullable: false),
                    Qyteti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rruga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KohaArritjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalDatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_AdditionalDatas_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalDatas_OrderId",
                table: "AdditionalDatas",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalDatas");
        }
    }
}
