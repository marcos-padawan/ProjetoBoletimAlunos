using System;
using System.Collections.Generic;

namespace ProjetoBoletimAlunos.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Curso { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
