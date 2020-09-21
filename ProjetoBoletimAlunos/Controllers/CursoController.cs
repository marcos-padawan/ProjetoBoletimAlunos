using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoBoletimCursos.Controllers
{
    [ApiController]
    [Route("Curso")]
    public class CursoController : ControllerBase
    {
        public static List<Curso> minhaLista = new List<Curso>();

        [HttpPost]
        [Route("AddCurso")]
        public ActionResult PostCurso(Curso curso)
        {
            var result = new Result<Curso>();
            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                auxiliar.AddCurso(curso);
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
        [Route("BuscaCursoPorNome")]
        public ActionResult GetCurso(string nome)
        {
            try
            {
                var result = minhaLista.Where(x => x.NomeCurso.Contains(nome)).ToList();
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
        [Route("DeleteCurso")]
        public ActionResult DeleteCurso(string nome)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.NomeCurso == nome);

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
        [Route("UpdateCurso")]
        public ActionResult UpdateCurso(string nomeCurso, string novoCurso)
        {
            var result = new Result<List<Curso>>();
            try
            {
                result.Data = minhaLista.Where(x => x.NomeCurso == nomeCurso).ToList();
                result.Data.Select(s =>
                {
                    s.NomeCurso = novoCurso; // aqui tenho que colocar o valor do form pro usuário decidir qual campo quer alterar, depois que encontra o Curso pelo cpf
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