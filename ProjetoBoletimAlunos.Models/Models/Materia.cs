using System;
using System.Collections.Generic;

namespace ProjetoBoletimAlunos.Models
{
    public class Materia
    {
        public int Id { get; set; }              //PK
        public string Descrição { get; set; }
        public string Situação { get; set; }
        public DateTime DataCadastro { get; set; }

        public ICollection<Notas> Notas { get; set; } = new HashSet<Notas>();
        public virtual ICollection<MateriaAluno> Alunos { get; set; } = new HashSet<MateriaAluno>();

    }
}
