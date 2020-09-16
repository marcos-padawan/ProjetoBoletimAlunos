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
        [HttpGet]
        [Route("GetNotas")]
        public ActionResult GetNotas()
        {
            var result = new Notas()
            {
                Aluno = "",                  // aqui tenho que colocar o valor do form pro usuário preencher o Notas que quer adicionar
                Matéria = "",
                Nota = 0
            };
            return Ok(result);
        }

        public static List<Notas> minhaLista = new List<Notas>();

        [HttpPost]
        [Route("PostNotas")]
        public ActionResult PostNotas(Notas notas)
        {
            minhaLista.Add(notas);
            return Ok(minhaLista);
        }

        [HttpGet]
        [Route("BuscaNotasPorAlunoEMateria")]
        public ActionResult GetNotas(string aluno, string materia)
        {
            try
            {
                var result = minhaLista.Where(x => x.Aluno.Contains(aluno) && x.Matéria.Contains(materia)).ToList();
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
        [Route("DeleteNotas")]
        public ActionResult DeleteNotas(string aluno, string materia)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Aluno == aluno && x.Matéria == materia);

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
        [Route("UpdateNotas")]
        public ActionResult UpdateNotas(string aluno, string materia, decimal novaNota)
        {
            var result = new Result<List<Notas>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Aluno == aluno && x.Matéria == materia).ToList();
                result.Data.Select(s =>
                {
                    s.Nota = novaNota; // aqui tenho que colocar o valor do form pro usuário decidir qual campo quer alterar, depois que encontra o Notas pelo cpf
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
