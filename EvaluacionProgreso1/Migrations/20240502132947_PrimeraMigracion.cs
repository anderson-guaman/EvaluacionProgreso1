using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluacionProgreso.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Carrera = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Semestre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guaman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calificacion = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ecuatoriano = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guaman", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "Guaman");
        }
    }
}
