using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineStockApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChemicalComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetAilment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfTabletsInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
