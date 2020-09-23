using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBoletimAlunos.Models
{
    public class MateriaAluno
    {
        public int MateriaId { get; set; }
        public virtual Materia Materia { get; set; }
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
