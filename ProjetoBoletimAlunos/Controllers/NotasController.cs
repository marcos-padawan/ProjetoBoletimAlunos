using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBoletimAlunos.Controllers
{
    [ApiController]
    [Route("Notas")]
    public class NotasController : ControllerBase
    {
        public static List<Notas> minhaLista = new List<Notas>();

        [HttpPost]
        [Route("AddNotas")]
        public ActionResult PostNota(Notas nota)
        {
            var result = new Result<Notas>();
            try
            {
                Utilidades<Notas> auxiliar = new Utilidades<Notas>();
                auxiliar.AddNota(nota);
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
        [Route("BuscaNotasPorAlunoEMateria")]
        public ActionResult GetNotas(int idAluno, int idMateria)
        {
            var result = new Result<List<Notas>>();
            try
            {
                Utilidades<Notas> auxiliar = new Utilidades<Notas>();
                result.Data = auxiliar.ListarNotasPorAluno(idAluno, idMateria);
                if (result.Data is null)
                {
                    result.Error = false;
                    result.Message = Message.Failure;
                    return BadRequest(result);
                }
                else
                {
                    result.Error = true;
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

        [HttpDelete]
        [Route("DeleteNotas")]
        public ActionResult DeleteNotas(int idAluno, int idMateria)
        {
            var result = new Result<List<Notas>>();
            try
            {
                Utilidades<Notas> auxiliar = new Utilidades<Notas>();
                result.Message = auxiliar.DeletaNotas(idAluno,idMateria);

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
        [Route("UpdateNotas")]
        public ActionResult UpdateNotas(int idAluno, int idMateria, decimal novaNota)
        {
            var result = new Result<List<Notas>>();
            try
            {
                Utilidades<Notas> auxiliar = new Utilidades<Notas>();
                result.Message = auxiliar.AlterarNotas(idAluno, idMateria, novaNota);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
