using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio.Infra.Repositories.MembershipContext.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Apelido = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apelido", "Senha", "Status" },
                values: new object[] { new Guid("bb765cd5-c8b9-4d5b-b4be-9f7413b22cac"), "admin", "abc123", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
