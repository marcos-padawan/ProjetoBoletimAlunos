using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBoletimAlunos.Models
{
    public class AlunosCurso
    {
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
