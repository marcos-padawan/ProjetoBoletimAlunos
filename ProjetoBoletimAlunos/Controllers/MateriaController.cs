using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Context.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;

namespace ProjetoBoletimMaterias.Controllers
{
    [ApiController]
    [Route("Materia")]
    public class MateriaController : ControllerBase
    {

        [HttpPost]
        [Route("AddMateria")]
        public ActionResult PostMateria(Materia materia)
        {
            var result = new Result<Materia>();
            try
            {
                Utilidades<Materia> auxiliar = new Utilidades<Materia>();
                auxiliar.AddMateria(materia);
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
        [Route("BuscaMateriaPorDescricao")]
        public ActionResult GetMateria(string descricao)
        {
            var result = new Result<List<Materia>>();
            try
            {
                Utilidades<Materia> auxiliar = new Utilidades<Materia>();
                result.Data = auxiliar.BuscarMateriaPorNome(descricao);

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
                    result.Status = System.Net.HttpStatusCode.InternalServerError;
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                result.Error = true;
                result.Message = Message.Failure + ex.Message;
                result.Status = System.Net.HttpStatusCode.InternalServerError;

                return NotFound(result);
            }
        }

        [HttpDelete]
        [Route("DeleteMateria")]
        public ActionResult DeleteMateria(string descricao)
        {
            var result = new Result<List<Materia>>();
            try
            {
                Utilidades<Materia> auxiliar = new Utilidades<Materia>();
                result.Message = auxiliar.DeletaMateria(descricao);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateMateria")]
        public ActionResult UpdateMateria(string descricaoMateria, string novoMateria, string novaSituacao)
        {
            var result = new Result<List<Materia>>();
            try
            {
                Utilidades<Materia> auxiliar = new Utilidades<Materia>();
                result.Message = auxiliar.AlterarMateria(descricaoMateria, novoMateria, novaSituacao);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
