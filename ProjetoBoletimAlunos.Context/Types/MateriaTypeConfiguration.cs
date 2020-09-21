using ProjetoBoletimAlunos.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ProjetoBoletimAlunos.Context.Types
{
    class MateriaTypeConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Descrição).IsRequired();
            builder.Property(q => q.Situação).IsRequired();
            builder.Property(q => q.DataCadastro).IsRequired();
        }
    }
    
}
