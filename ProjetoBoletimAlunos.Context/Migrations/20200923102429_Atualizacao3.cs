using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBoletimAlunos.Context.Migrations
{
    public partial class Atualizacao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "MateriaAlunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Nota",
                table: "MateriaAlunos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
