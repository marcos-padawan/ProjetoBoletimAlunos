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
    [Route("CursoAlunos")]
    public class AlunosCursoController : ControllerBase
    {
        [HttpPost]
        [Route("AddCursoAlunos")]
        public ActionResult PostCursoAlunos(AlunosCurso alunosCurso)
        {
            var result = new Result<AlunosCurso>();
            try
            {
                Utilidades<AlunosCurso> auxiliar = new Utilidades<AlunosCurso>();
                auxiliar.AddAlunosCurso(alunosCurso);
                result.Error = false;
                result.Message = Message.Success;

                return Ok(result);
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
        [Route("ListarTodosAlunoscurso")]
        public ActionResult ListarAlunosCurso()
        {
            var result = new Result<List<AlunosCurso>>();

            try
            {
                Utilidades<AlunosCurso> auxiliar = new Utilidades<AlunosCurso>();
                result.Data = auxiliar.ListarTodosAlunosCurso();
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
