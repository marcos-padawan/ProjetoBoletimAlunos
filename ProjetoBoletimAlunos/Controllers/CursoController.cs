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
            var result = new Result<List<Curso>>();
            
            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                result.Data= auxiliar.BuscarCursoPorNome(nome);
                if(result.Data is null)
                {
                    result.Error = true;
                    result.Message = Message.Failure;
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
                return NotFound(result);
            }
        }

        [HttpGet]
        [Route("ListarTodosCursos")]
        public ActionResult ListarCurso()
        {
            var result = new Result<List<Curso>>();

            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                result.Data = auxiliar.ListarTodosCursos();
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
        [HttpGet]
        [Route("ListarTodosCursosAtivos")]
        public ActionResult ListarCursoAtivo()
        {
            var result = new Result<List<Curso>>();

            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                result.Data = auxiliar.ListarTodosCursosAtivos();
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
        [Route("DeleteCurso")]
        public ActionResult DeleteCurso(string nome)
        {
            var result = new Result<List<Curso>>();
            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                result.Message = auxiliar.DeletaCurso(nome);

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
        [Route("UpdateCurso")]
        public ActionResult UpdateCurso(string nomeCurso, string novoNome, string novoStatus)
        {
            var result = new Result<List<Curso>>();
            try
            {
                Utilidades<Curso> auxiliar = new Utilidades<Curso>();
                result.Message = auxiliar.AlterarCurso(nomeCurso, novoNome, novoStatus);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}