using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaryCalculator.Migrations
{
    /// <inheritdoc />
    public partial class AddSalaryAndTypesOfContractTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaryEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brutto = table.Column<long>(type: "bigint", nullable: false),
                    Netto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfContract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Shortcut = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfContract", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TypesOfContract",
                columns: new[] { "Id", "FullName", "Shortcut" },
                values: new object[,]
                {
                    { 1, "Umowa o pracę", "UoP" },
                    { 2, "Business to business", "B2B" },
                    { 3, "Umowa zlecenie", "UZ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaryEntities");

            migrationBuilder.DropTable(
                name: "TypesOfContract");
        }
    }
}
