using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBoletimAlunos.Controllers
{
    [ApiController]
    [Route("CursoMateria")]
    public class CursoMateriaController :ControllerBase
    {
        [HttpPost]
        [Route("AddCursoMateria")]
        public ActionResult PostCurso(CursoMateria cursoMateria)
        {
            var result = new Result<CursoMateria>();
            try
            {
                Utilidades<CursoMateria> auxiliar = new Utilidades<CursoMateria>();
                auxiliar.AddCursoMateria(cursoMateria);
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
        [Route("ListarTodasCursoMateria")]
        public ActionResult ListarCursoMateria()
        {
            var result = new Result<List<CursoMateria>>();

            try
            {
                Utilidades<CursoMateria> auxiliar = new Utilidades<CursoMateria>();
                result.Data = auxiliar.ListarTodasCursoMateria();
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
    }
}
