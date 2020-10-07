using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBoletimAlunos.Models
{
    public class Notas
    {
        public int Id { get; set; }         //PK
        public double Nota { get; set; }

        public int AlunoId { get; set; }     //FK
        public int MateriaId { get; set; }   //FK

        public virtual Aluno Alunos { get; set; }
        public virtual Materia Materias { get; set; }

    }
}
