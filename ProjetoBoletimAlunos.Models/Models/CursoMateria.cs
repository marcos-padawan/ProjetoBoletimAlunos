using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBoletimAlunos.Models
{
    public class CursoMateria
    {
        public int MateriaId { get; set; }
        public virtual Materia Materia { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
