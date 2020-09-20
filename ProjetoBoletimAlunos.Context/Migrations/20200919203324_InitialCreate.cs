using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBoletimAlunos.Context.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCurso = table.Column<string>(maxLength: 80, nullable: false),
                    Situação = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matérias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(nullable: false),
                    Situação = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    CursoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matérias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matérias_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MateriaAlunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    MatériaId = table.Column<int>(nullable: false),
                    Nota = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaAlunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_MateriaAlunos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MateriaAlunos_Matérias_MatériaId",
                        column: x => x.MatériaId,
                        principalTable: "Matérias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota = table.Column<decimal>(nullable: false),
                    AlunoId = table.Column<int>(nullable: false),
                    MatériaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Matérias_MatériaId",
                        column: x => x.MatériaId,
                        principalTable: "Matérias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaAlunos_MatériaId",
                table: "MateriaAlunos",
                column: "MatériaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matérias_CursoId",
                table: "Matérias",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_MatériaId",
                table: "Notas",
                column: "MatériaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MateriaAlunos");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Matérias");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
