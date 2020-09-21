using Microsoft.EntityFrameworkCore;
using ProjetoBoletimAlunos.Context.Models;

namespace ProjetoBoletimAlunos.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext()
        {
        }
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04786\\SQLEXPRESS; Initial Catalog=BancoUniPDWN;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoDeDadosContext).Assembly);

            //-------CHAVES PRIMÁRIAS------------
            modelBuilder.Entity<MateriaAluno>()
            .HasKey(q => new { q.AlunoId });

            //-------CHAVES ESTRANGEIRAS------------
            modelBuilder.Entity<Aluno>()
           .HasOne(p => p.Curso)
           .WithMany(b => b.Alunos)
           .HasForeignKey(p => p.CursoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Matéria>()
           .HasOne(p => p.Curso)
           .WithMany(b => b.Matérias)
           .HasForeignKey(p => p.CursoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MateriaAluno>()
           .HasOne(p => p.Aluno)
           .WithMany(b => b.Matérias)
           .HasForeignKey(p => p.AlunoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MateriaAluno>()
           .HasOne(p => p.Matéria)
           .WithMany(b => b.Alunos)
           .HasForeignKey(p => p.MatériaId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notas>()
           .HasOne(p => p.Alunos)
           .WithMany(b => b.Notas)
           .HasForeignKey(p => p.AlunoId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notas>()
           .HasOne(p => p.Matérias)
           .WithMany(b => b.Notas)
           .HasForeignKey(p => p.MatériaId)
           .OnDelete(DeleteBehavior.Restrict);

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matéria> Matérias { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<MateriaAluno> MateriaAlunos { get; set; }

    }
}
