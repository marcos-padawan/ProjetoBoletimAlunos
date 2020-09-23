using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBoletimAlunos.Context.Migrations
{
    public partial class Atualizacao4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaAlunos_Alunos_AlunoId",
                table: "MateriaAlunos");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaAlunos_Materias_MateriaId",
                table: "MateriaAlunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriaAlunos",
                table: "MateriaAlunos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriaAlunos",
                table: "MateriaAlunos",
                columns: new[] { "AlunoId", "MateriaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaAlunos_Alunos_AlunoId",
                table: "MateriaAlunos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaAlunos_Materias_MateriaId",
                table: "MateriaAlunos",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriaAlunos_Alunos_AlunoId",
                table: "MateriaAlunos");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaAlunos_Materias_MateriaId",
                table: "MateriaAlunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriaAlunos",
                table: "MateriaAlunos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriaAlunos",
                table: "MateriaAlunos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaAlunos_Alunos_AlunoId",
                table: "MateriaAlunos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaAlunos_Materias_MateriaId",
                table: "MateriaAlunos",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
