using Microsoft.EntityFrameworkCore;
using ProjetoBoletimAlunos.Context.Models;
using System.Reflection;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;


namespace ProjetoBoletimAlunos.Context
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options)
            :base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04786\\SQLEXPRESS; Initial Catalog=BoletimMarotoBanco;Integrated Secutiry=True;");
        }

        public Microsoft.EntityFrameworkCore.DbSet<Aluno> Alunos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Curso> Cursos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Matéria> Matérias { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Notas> Notaas { get; set; }

       

    }
}
