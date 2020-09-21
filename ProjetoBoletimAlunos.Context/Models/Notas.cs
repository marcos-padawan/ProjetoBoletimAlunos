using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBoletimAlunos.Context.Models
{
    public class Notas
    {
        public int Id { get; set; }         //PK
        public decimal Nota { get; set; }

        public int AlunoId { get; set; }     //FK
        public int MateriaId { get; set; }   //FK

        public virtual Aluno Alunos { get; set; }
        public virtual Materia Materias { get; set; }

    }
}
