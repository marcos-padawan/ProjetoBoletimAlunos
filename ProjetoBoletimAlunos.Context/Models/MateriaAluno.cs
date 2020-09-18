using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBoletimAlunos.Context.Models
{
    public class MateriaAluno
    {
        public int MatériaId { get; set; }
        public Matéria Matéria { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public decimal Nota { get; set; }
    }
}
