using ProjetoBoletimAlunos.Context;
using ProjetoBoletimAlunos.Models;
using System;
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
        public void AddMateria(Materia materia)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.Materias.Add(materia);
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
        public void AddCursoMateria(CursoMateria cursoMateria)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                meuBanco.CursoMateria.Add(cursoMateria);
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
        public List<Notas> ListarNotasPorAluno(int idAluno, int idMateria)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Notas.Where(x => x.AlunoId.Equals(idAluno)
                && x.MateriaId.Equals(idMateria)).ToList();
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
        //--------------LISTAR TODOS OS ITEMS ----------------- READ ALL
        public List<Curso> ListarTodosCursos()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Cursos.ToList();
            }
        }
        public List<Curso> ListarTodosCursosAtivos()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Cursos.Where(q => q.Situação.Equals("Ativo")).ToList();
            }
        }
        public List<Aluno> ListarTodosAlunos()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Alunos.ToList();
            }
        }
        public List<Materia> ListarTodasMaterias()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.Materias.ToList();
            }
        }
        public List<MateriaAluno> ListarTodasMateriaAluno()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.MateriaAlunos.ToList();
            }
        }
        public List<CursoMateria> ListarTodasCursoMateria()
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                return meuBanco.CursoMateria.ToList();
            }
        }

        //-----ALTERAÇÃO DE ITENS DO BANCO-------  UPDATE
        public string AlterarMateria(string descricao, string novaDescricao, string novoStatus, DateTime novaData)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var materia = meuBanco.Materias.FirstOrDefault(q => q.Descrição.Equals(descricao));
                if (materia != null)
                {
                    materia.Descrição = novaDescricao;
                    materia.Situação = novoStatus;
                    materia.DataCadastro = novaData;
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }
        public string AlterarAluno(string nome, string sobrenome, string novoNome, string novoSobrenome, string novoCpf, DateTime novoNascimento)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var aluno = meuBanco.Alunos.FirstOrDefault(q => q.Nome.Equals(nome) && q.Sobrenome.Equals(sobrenome));
                if (aluno != null)
                {
                    aluno.Nome = novoNome;
                    aluno.Sobrenome = novoSobrenome;
                    aluno.Cpf = novoCpf;
                    aluno.DataNascimento = novoNascimento;

                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }
        public string AlterarCurso(string nome, string novoNome, string novoStatus)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var curso = meuBanco.Cursos.FirstOrDefault(q => q.NomeCurso.Equals(nome));
                if (curso != null)
                {
                    curso.NomeCurso = novoNome;
                    curso.Situação = novoStatus;
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }
        public string AlterarNotas(int idAluno, int idMateria, decimal novaNota)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var nota = meuBanco.Notas.FirstOrDefault(q => q.AlunoId.Equals(idAluno)
                                                            && q.MateriaId.Equals(idMateria));
                if (nota != null)
                {
                    nota.Nota = novaNota;
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }

        //-----EXCLUSÃO DE ITENS DO BANCO-------  DELETE
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
                    return Message.Failure;
            }
        }
        public string DeletaAluno(string nome, string sobrenome)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var alunoRemovido = meuBanco.Alunos.FirstOrDefault(q => q.Nome.Equals(nome) && q.Sobrenome.Equals(sobrenome));
                if (alunoRemovido != null)
                {
                    meuBanco.Alunos.Remove(alunoRemovido);
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }
        public string DeletaCurso(string nome)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var cursoRemovido = meuBanco.Cursos.FirstOrDefault(q => q.NomeCurso.Equals(nome));
                if (cursoRemovido != null)
                {
                    meuBanco.Cursos.Remove(cursoRemovido);
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }
        public string DeletaNotas(int idAluno, int idMateria)
        {
            meuBanco = new BancoDeDadosContext();
            using (meuBanco)
            {
                var notaRemovida = meuBanco.Notas.FirstOrDefault(q => q.AlunoId.Equals(idAluno)
                                                                   && q.MateriaId.Equals(idMateria));
                if (notaRemovida != null)
                {
                    meuBanco.Notas.Remove(notaRemovida);
                    meuBanco.SaveChanges();
                    return Message.Success;
                }
                else
                    return Message.Failure;
            }
        }

    }
}
