using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Context.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoBoletimAlunos.Telas;

namespace ProjetoBoletimAlunos.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
      
        [HttpGet]
        [Route("GetAluno")]
        public ActionResult GetAluno()
        {
            var result = new Aluno()
            {
                Nome = "",                  // aqui tenho que colocar o valor do form pro usuário preencher o aluno que quer adicionar
                Sobrenome = "",             
                Curso = { },
                Cpf = "",
                DataNascimento = DateTime.Parse("29/11/1995")
            };
            return Ok(result);
        }

        public static List<Aluno> minhaLista = new List<Aluno>();

        [HttpPost]
        [Route ("PostAluno")]
        public ActionResult PostAluno(Aluno aluno)
        {
            minhaLista.Add(aluno);
            return Ok(minhaLista);
        }

        [HttpGet]
        [Route("BuscaAlunoPorNome")]
        public ActionResult GetAluno(string nome, string sobrenome)
        {
            try
            {
                var result = minhaLista.Where(x => x.Nome.Contains(nome) && x.Sobrenome.Contains(sobrenome)).ToList();
                if (result.Count == 0)
                {
                    return BadRequest(Message.Failure);
                }
                else
                    return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(Message.Failure + "****" + ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteAluno")]
        public ActionResult DeleteAluno(string nome, string sobrenome)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Nome == nome && x.Sobrenome == sobrenome);

                if (result == 0)
                    return BadRequest(Message.Failure);
                else
                    return Ok(Message.Failure);
            }
            catch(Exception)
            {
                return BadRequest(Message.Failure);
            }
        }

        [HttpPut]
        [Route("UpdateAluno")]
        public ActionResult UpdateAluno(string cpfAluno, string novoAluno)
        {
            var result = new Result<List<Aluno>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Cpf == cpfAluno).ToList();
                result.Data.Select(s =>
                {
                    s.Cpf = novoAluno; // aqui tenho que colocar o valor do form pro usuário decidir qual campo quer alterar, depois que encontra o aluno pelo cpf
                    return s;
                }).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = ex.Message;
                return BadRequest(result);
            }

        }
    }
}
