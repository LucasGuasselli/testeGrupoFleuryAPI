using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testeGrupoFleuryAPI.Repository.Migrations
{
    public partial class storedProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoredProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeNome = table.Column<string>(nullable: true),
                    UnidadeId = table.Column<int>(nullable: false),
                    FichaId = table.Column<int>(nullable: false),
                    DataAtendimento = table.Column<DateTime>(nullable: false),
                    ClienteNome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    IdSubItem = table.Column<int>(nullable: false),
                    SiglaExame = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredProcedures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoredProcedures");
        }
    }
}
