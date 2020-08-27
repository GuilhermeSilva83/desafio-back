using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio.Infra.Repositories.MainContext.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    EstadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leilao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    ValorInicial = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Usado = table.Column<bool>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    DataFinalizacao = table.Column<DateTime>(nullable: false),
                    UsuarioResponsavelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leilao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leilao_Usuario_UsuarioResponsavelId",
                        column: x => x.UsuarioResponsavelId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "São Paulo" },
                    { 2, "Rio de Janeiro" },
                    { 3, "Mato Grosso" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Guilherme Silva" },
                    { 2, "Steve Jobs" },
                    { 3, "Bill Gates" }
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "São Paulo" },
                    { 2, 1, "Barueri" },
                    { 3, 1, "Osasco" },
                    { 4, 2, "Rio de Janeiro" },
                    { 5, 2, "Cabo Frio" },
                    { 6, 2, "Arraial do Cabo" },
                    { 7, 3, "Cuiaba" },
                    { 8, 3, "Chamada dos Guimaraes" },
                    { 9, 3, "Santo Antonio" }
                });

            migrationBuilder.InsertData(
                table: "Leilao",
                columns: new[] { "Id", "DataAbertura", "DataFinalizacao", "Nome", "Usado", "UsuarioResponsavelId", "ValorInicial" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grande Leilao de Carros", true, 1, 9999.50m },
                    { 2, new DateTime(1, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leilao das Casas", true, 1, 199999.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoId",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Leilao_UsuarioResponsavelId",
                table: "Leilao",
                column: "UsuarioResponsavelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Leilao");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
