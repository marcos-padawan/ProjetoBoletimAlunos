using Microsoft.EntityFrameworkCore;
using ProjetoBoletimAlunos.Models;

namespace ProjetoBoletimAlunos.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext() { }
        
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options): base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04786\\SQLEXPRESS; Initial Catalog=BancoUniPDWN;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoDeDadosContext).Assembly);

            //-------CHAVES ESTRANGEIRAS---------

            modelBuilder.Entity<Aluno>()
           .HasOne(p => p.Curso)
           .WithMany(b => b.Alunos)
           .HasForeignKey(p => p.CursoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notas>()
           .HasOne(p => p.Alunos)
           .WithMany(b => b.Notas)
           .HasForeignKey(p => p.AlunoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notas>()
           .HasOne(p => p.Materias)
           .WithMany(b => b.Notas)
           .HasForeignKey(p => p.MateriaId)
           .OnDelete(DeleteBehavior.Restrict);

            //--------TABELAS N PARA N----------

            modelBuilder.Entity<CursoMateria>()
            .HasKey(x => new { x.CursoId, x.MateriaId });
            
            modelBuilder.Entity<MateriaAluno>()
            .HasKey(x => new { x.AlunoId, x.MateriaId });
            
            modelBuilder.Entity<AlunosCurso>()
            .HasKey(x => new { x.AlunoId, x.CursoId });

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<MateriaAluno> MateriaAlunos { get; set; }
        public DbSet<CursoMateria> CursoMateria { get; set; }
        public DbSet<AlunosCurso> AlunosCurso { get; set; }
    }
}
