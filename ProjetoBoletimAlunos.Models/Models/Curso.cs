using System.Collections.Generic;

namespace ProjetoBoletimAlunos.Models
{
    public class Curso
    {
        public int Id { get; set; }            //PK
        public string NomeCurso { get; set; }
        public string Situação { get; set; }
        //public ICollection<Materia> Materias { get; set; } = new HashSet<Materia>();
        public ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();
        
    }
}
