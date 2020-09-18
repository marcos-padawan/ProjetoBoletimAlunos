using ProjetoBoletimAlunos.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjetoBoletimAlunos.Context.Types
{
    public class NotasTypeConfiguration : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nota).IsRequired();
            builder.HasOne(x => x.Alunos).WithMany().HasForeignKey(x => x.AlunoId);
            builder.HasOne(x => x.Matérias).WithMany().HasForeignKey(x => x.MatériaId);
        }
    }
}
