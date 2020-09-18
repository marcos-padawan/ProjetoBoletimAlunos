using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Context.Models;
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
                Alunos = { },                  // aqui tenho que colocar o valor do form pro usuário preencher o Notas que quer adicionar
                Matérias = { },
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
        public ActionResult GetNotas(string alunoNome,string alunoSobrenome, string materia)
        {
            try
            {
                var result = minhaLista.Where(x => x.Alunos.Nome.Contains(alunoNome) && x.Alunos.Sobrenome.Contains(alunoSobrenome) &&  x.Matérias.Descrição.Contains(materia)).ToList();
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
        public ActionResult DeleteNotas(string alunoNome, string alunoSobrenome, string materia)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Alunos.Nome == alunoNome && x.Alunos.Sobrenome == alunoSobrenome &&  x.Matérias.Descrição == materia);

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
        public ActionResult UpdateNotas(string alunoNome,string alunoSobrenome, string materia, decimal novaNota)
        {
            var result = new Result<List<Notas>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Alunos.Nome == alunoNome && x.Alunos.Sobrenome == alunoSobrenome &&  x.Matérias.Descrição == materia).ToList();
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
