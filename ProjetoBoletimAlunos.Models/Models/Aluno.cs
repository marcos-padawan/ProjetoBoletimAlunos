﻿using System;
using System.Collections.Generic;

namespace ProjetoBoletimAlunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }             //PK
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CursoId { get; set; }        //FK
        public virtual Curso Curso { get; set; }        //FK
        public virtual ICollection<MateriaAluno> Materias { get; set; } = new HashSet<MateriaAluno>();
        public virtual ICollection<Notas> Notas { get; set; } = new HashSet<Notas>();
    }
}
