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
    [Route("MateriaAluno")]
    public class MateriaAlunoController : ControllerBase
    {
        [HttpPost]
        [Route("AddMateriaAluno")]
        public ActionResult PostMateriaAluno(MateriaAluno materiaAluno)
        {
            var result = new Result<MateriaAluno>();
            try
            {
                Utilidades<MateriaAluno> auxiliar = new Utilidades<MateriaAluno>();
                auxiliar.AddMateriaAluno(materiaAluno);
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
        [Route("ListarTodasMateriaAluno")]
        public ActionResult ListarMateriaAluno()
        {
            var result = new Result<List<MateriaAluno>>();

            try
            {
                Utilidades<MateriaAluno> auxiliar = new Utilidades<MateriaAluno>();
                result.Data = auxiliar.ListarTodasMateriaAluno();
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
