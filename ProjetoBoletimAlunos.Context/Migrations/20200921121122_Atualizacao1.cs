using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBoletimAlunos.Context.Migrations
{
    public partial class Atualizacao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Cursos_CursoId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_CursoId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Materias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Materias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_CursoId",
                table: "Materias",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Cursos_CursoId",
                table: "Materias",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
