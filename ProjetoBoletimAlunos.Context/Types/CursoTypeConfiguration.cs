using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBoletimAlunos.Models;

namespace ProjetoBoletimAlunos.Context.Types
{
    class CursoTypeConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.NomeCurso).IsRequired().HasMaxLength(80);
            builder.Property(q => q.Situação).IsRequired();
        }
    }
}
