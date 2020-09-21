using System.Collections.Generic;

namespace ProjetoBoletimAlunos.Forms.Models
{
    public class Curso
    {
        public int Id { get; set; }            //PK
        public string NomeCurso { get; set; }
        public string Situação { get; set; }
        public ICollection<Matéria> Matérias { get; set; } = new HashSet<Matéria>();
        public ICollection<Aluno> Alunos { get; set; } = new HashSet<Aluno>();
        
    }
}
