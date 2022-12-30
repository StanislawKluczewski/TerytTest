using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teryt.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SIMCs",
                columns: table => new
                {
                    WojewodztwoId = table.Column<int>(type: "int", nullable: false),
                    PowiatId = table.Column<int>(type: "int", nullable: false),
                    GminaId = table.Column<int>(type: "int", nullable: false),
                    RodzGminaId = table.Column<int>(type: "int", nullable: false),
                    RmNumer = table.Column<int>(type: "int", nullable: false),
                    MzNumer = table.Column<int>(type: "int", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SymNumer = table.Column<int>(type: "int", nullable: false),
                    SymPod = table.Column<int>(type: "int", nullable: false),
                    StanNa = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TERCs",
                columns: table => new
                {
                    WojewodztwoId = table.Column<int>(type: "int", nullable: false),
                    PowiatId = table.Column<int>(type: "int", nullable: true),
                    GminaId = table.Column<int>(type: "int", nullable: true),
                    RodzGminaId = table.Column<int>(type: "int", nullable: true),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazwaTerytorialna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StanNa = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ULICs",
                columns: table => new
                {
                    WojewodztwoId = table.Column<int>(type: "int", nullable: false),
                    PowiatId = table.Column<int>(type: "int", nullable: false),
                    GminaId = table.Column<int>(type: "int", nullable: false),
                    RodzGminaId = table.Column<int>(type: "int", nullable: false),
                    SymNumer = table.Column<int>(type: "int", nullable: false),
                    SymNumerUlicy = table.Column<int>(type: "int", nullable: false),
                    Cecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwa1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwa2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanNa = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIMCs");

            migrationBuilder.DropTable(
                name: "TERCs");

            migrationBuilder.DropTable(
                name: "ULICs");
        }
    }
}
