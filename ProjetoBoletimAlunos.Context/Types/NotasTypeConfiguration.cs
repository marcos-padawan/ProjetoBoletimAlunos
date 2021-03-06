﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBoletimAlunos.Models;

namespace ProjetoBoletimAlunos.Context.Types
{
    public class NotasTypeConfiguration : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nota).IsRequired();
        }
    }
}
