using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testeGrupoFleuryAPI.Repository.Migrations
{
    public partial class alterandoColunmFicha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Fichas");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtendimento",
                table: "Fichas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtendimento",
                table: "Fichas");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Fichas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
