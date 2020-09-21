using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoBoletimAlunos.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {

        public static List<Aluno> minhaLista = new List<Aluno>();

        [HttpPost]
        [Route("AddAluno")]
        public ActionResult AddAluno(Aluno aluno)
        {
            var result = new Result<Aluno>();
            try
            {
                Utilidades<Aluno> auxiliar = new Utilidades<Aluno>();
                auxiliar.AddAluno(aluno);
                result.Error = false;
                result.Message = Message.Success;

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = Message.Failure + ex.Message;
                result.Status = System.Net.HttpStatusCode.InternalServerError;

                return NotFound(result);
            }
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
            catch (Exception)
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
