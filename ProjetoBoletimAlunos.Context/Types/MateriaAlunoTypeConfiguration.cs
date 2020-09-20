using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBoletimAlunos.Context.Models;

namespace ProjetoBoletimAlunos.Context.Types
{
    class MateriaAlunoTypeConfiguration : IEntityTypeConfiguration<MateriaAluno>
    {
        public void Configure(EntityTypeBuilder<MateriaAluno> builder)
        {

        }
    }
}
