using ProjetoBoletimAlunos.Context;
using ProjetoBoletimAlunos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBoletimAlunos.Utilidades
{
    public class Utilidades<T>
    {
        private BancoDeDadosContext meuBanco;
        //-----ADICIONAR ITENS AO BANCO-------    CREATE
        public void AddNota(Notas nota)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.Notas.Add(nota);
                meuBanco.SaveChanges();
            }
        }
        public void AddAluno(Aluno aluno)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.Alunos.Add(aluno);
                meuBanco.SaveChanges();
            }
        }
        public void AddMateria(Materia matéria)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.Materias.Add(matéria);
                meuBanco.SaveChanges();
            }
        }
        public void AddCurso(Curso curso)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.Cursos.Add(curso);
                meuBanco.SaveChanges();
            }
        }
        public void AddMateriaAluno(MateriaAluno materiaAluno)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.MateriaAlunos.Add(materiaAluno);
                meuBanco.SaveChanges();
            }
        }
        //-----LISTAR PESQUISA FILTRADA DO BANCO-------  READ
        public List<Notas> ListarNotasPorMateria(string nomeAluno, string sobrenomeAluno, string materia)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Notas.Where(x => x.Alunos.Nome.Equals(nomeAluno)
                && x.Alunos.Sobrenome.Equals(sobrenomeAluno)
                && x.Materias.Descrição.Equals(materia)).ToList();
            }
        }
        public List<Notas> ListarNotasPorCurso(string nomeAluno, string sobrenomeAluno, string nomeCurso)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Notas.Where(x => x.Alunos.Nome.Equals(nomeAluno)
                && x.Alunos.Sobrenome.Equals(sobrenomeAluno)
                && x.Alunos.Curso.NomeCurso.Equals(nomeCurso)).ToList();
            }
        }
        public List<Aluno> BuscarAlunoPorNome(string nomeAluno, string sobrenomeAluno)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Alunos.Where(x => x.Nome.Equals(nomeAluno)
                && x.Sobrenome.Equals(sobrenomeAluno)
                ).ToList();
            }
        }
        public List<Materia> BuscarMateriaPorNome(string nomeMateria)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Materias.Where(x => x.Descrição.Equals(nomeMateria)).ToList();
            }
        }
        public List<Curso> BuscarCursoPorNome(string nomeCurso)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Cursos.Where(x => x.NomeCurso.Equals(nomeCurso)).ToList();
            }
        }
        //-----ALTERAÇÃO DE ITENS DO BANCO-------  UPDATE
        public string AlterarMateria(string descricao, string novaDescricao, string novoStatus)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var materia = meuBanco.Materias.FirstOrDefault(q => q.Descrição == descricao);
                if (materia != null)
                {
                    materia.Descrição = novaDescricao;
                    materia.Situação = novoStatus;
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
            
        
        }

        //-----EXCLUSÃO DE ITENS DO BANCO-------  REMOVE
        public string DeletaMateria(string descricao)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var materiaRemovida = meuBanco.Materias.FirstOrDefault(q => q.Descrição == descricao);
                if (materiaRemovida != null)
                {
                    meuBanco.Materias.Remove(materiaRemovida);
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return  Message.Failure;
            }
        }


    }
}
