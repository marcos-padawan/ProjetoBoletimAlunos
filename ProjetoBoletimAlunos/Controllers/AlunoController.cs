using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;


namespace ProjetoBoletimAlunos.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
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

        public static List<Aluno> minhaLista = new List<Aluno>();

        [HttpGet]
        [Route("BuscaAlunoPorNome")]
        public ActionResult GetAluno(string nome, string sobrenome)
        {
            var result = new Result<List<Aluno>>();
            try
            {
                Utilidades<Aluno> auxiliar = new Utilidades<Aluno>();
                result.Data = auxiliar.BuscarAlunoPorNome(nome, sobrenome);

                if (result.Data.Count == 0)
                {
                    result.Error = true;
                    result.Message = Message.Failure;
                    result.Status = System.Net.HttpStatusCode.InternalServerError;

                    return BadRequest(result);
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.Success;

                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = $"{Message.Failure} - {ex.Message}";
                result.Status = System.Net.HttpStatusCode.InternalServerError;

                return NotFound(result);
            }
        }

        [HttpGet]
        [Route("ListarTodosAlunos")]
        public ActionResult ListarAlunos()
        {
            var result = new Result<List<Aluno>>();

            try
            {
                Utilidades<Aluno> auxiliar = new Utilidades<Aluno>();
                result.Data = auxiliar.ListarTodosAlunos();
                if (result.Data is null)
                {
                    result.Error = true;
                    result.Message = Message.Failure;
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.Success;
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound($"{Message.Failure} **** {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("DeleteAluno")]
        public ActionResult DeleteAluno(string nome, string sobrenome)
        {
            var result = new Result<List<Aluno>>();
            try
            {
                Utilidades<Aluno> auxiliar = new Utilidades<Aluno>();
                result.Message = auxiliar.DeletaAluno(nome, sobrenome);

                if (result.Message is null)
                {
                    result.Error = true;
                    result.Message = Message.Failure;
                }
                else
                {
                    result.Error = false;
                    result.Message = Message.Success;
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"{Message.Failure} - {ex.Message}");
            }
        }

        [HttpPut]
        [Route("UpdateAluno")]
        public ActionResult UpdateAluno(string nome, string sobrenome, string novoNome, string novoSobrenome, string novoCpf, DateTime novoNascimento)
        {
            var result = new Result<List<Aluno>>();
            try
            {
                Utilidades<Aluno> auxiliar = new Utilidades<Aluno>();
                result.Message = auxiliar.AlterarAluno(nome, sobrenome, novoNome, novoSobrenome, novoCpf, novoNascimento);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
