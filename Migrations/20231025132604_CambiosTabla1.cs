using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanAraujo_Examen1P.Migrations
{
    public partial class CambiosTabla1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JuanAraujo_tabla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JaTieneCita = table.Column<bool>(type: "bit", nullable: false),
                    JaFechaCita = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JaValorCita = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuanAraujo_tabla", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JuanAraujo_tabla");
        }
    }
}
