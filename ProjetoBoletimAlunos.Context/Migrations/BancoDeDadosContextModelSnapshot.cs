﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoBoletimAlunos.Context;

namespace ProjetoBoletimAlunos.Context.Migrations
{
    [DbContext(typeof(BancoDeDadosContext))]
    partial class BancoDeDadosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.AlunosCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCurso");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.CursoMateria", b =>
                {
                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("CursoId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("CursoMateria");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.MateriaAluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("MateriaAlunos");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoBoletimAlunos.Models.Curso", "Curso")
                        .WithMany("Alunos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.AlunosCurso", b =>
                {
                    b.HasOne("ProjetoBoletimAlunos.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoBoletimAlunos.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.CursoMateria", b =>
                {
                    b.HasOne("ProjetoBoletimAlunos.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoBoletimAlunos.Models.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.MateriaAluno", b =>
                {
                    b.HasOne("ProjetoBoletimAlunos.Models.Aluno", "Aluno")
                        .WithMany("Materias")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoBoletimAlunos.Models.Materia", "Materia")
                        .WithMany("Alunos")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoBoletimAlunos.Models.Notas", b =>
                {
                    b.HasOne("ProjetoBoletimAlunos.Models.Aluno", "Alunos")
                        .WithMany("Notas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProjetoBoletimAlunos.Models.Materia", "Materias")
                        .WithMany("Notas")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
