using Microsoft.AspNetCore.Mvc;
using ProjetoBoletimAlunos.Context.Models;
using ProjetoBoletimAlunos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBoletimMaterias.Controllers
{
    [ApiController]
    [Route("Matéria")]
    public class MatériaController : ControllerBase 
    {
        [HttpGet]
        [Route("GetMateria")]
        public ActionResult GetMateria()
        {
            var result = new Matéria()
            {
                Descrição = "",                  // aqui tenho que colocar o valor do form pro usuário preencher o Materia que quer adicionar
                Situação = "",
                DataCadastro = DateTime.Parse("10/09/2018")
            };
            return Ok(result);
        }

        public static List<Matéria> minhaLista = new List<Matéria>();

        [HttpPost]
        [Route("PostMateria")]
        public ActionResult PostMateria(Matéria materia)
        {
            minhaLista.Add(materia);
            return Ok(minhaLista);
        }

        [HttpGet]
        [Route("BuscaMateriaPorDescricao")]
        public ActionResult GetMateria(string descricao)
        {
            try
            {
                var result = minhaLista.Where(x => x.Descrição.Contains(descricao)).ToList();
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
        [Route("DeleteMateria")]
        public ActionResult DeleteMateria(string descricao)
        {
            try
            {
                var result = minhaLista.RemoveAll(x => x.Descrição == descricao);

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
        [Route("UpdateMateria")]
        public ActionResult UpdateMateria(string descricaoMateria, string novoMateria)
        {
            var result = new Result<List<Matéria>>();
            try
            {
                result.Data = minhaLista.Where(x => x.Descrição == descricaoMateria).ToList();
                result.Data.Select(s =>
                {
                    s.Descrição = novoMateria; // aqui tenho que colocar o valor do form pro usuário decidir qual campo quer alterar, depois que encontra o Materia pelo cpf
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
