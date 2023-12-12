using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Imcs",
                columns: table => new
                {
                    ImcID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    usuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImcTotal = table.Column<float>(type: "REAL", nullable: true),
                    Classificacao = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imcs", x => x.ImcID);
                    table.ForeignKey(
                        name: "FK_Imcs_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_usuarioId",
                table: "Imcs",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imcs");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
