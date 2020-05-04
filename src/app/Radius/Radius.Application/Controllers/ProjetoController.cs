using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using System;
using System.Linq;

namespace Radius.Application.Controllers
{
    public class ProjetoController : ApiController
    {

        private readonly IServicoProjeto _servicoProjeto;
        public ProjetoController(
            IServicoProjeto servicoProjeto)
        {
            _servicoProjeto = servicoProjeto;
        }

        [HttpGet]
        //[Authorize(Policy = "Ler")]
        public IActionResult ListarTodos()
        {
            var lista = _servicoProjeto.ListarTodos();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult ListarTodosAtivos()
        {
            var lista = _servicoProjeto.ListarTodosComCondicao();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult FiltrarResultados([FromQuery] FiltroProjetoDTO filtro)
        {
            var lista = _servicoProjeto.Buscar(filtro);

            return Json(lista);
        }

        [HttpPost]
        //[Authorize(Policy = "Gravar")]
        public IActionResult Adicionar(ProjetoDTOCriacao dTO)
        {
            var result = _servicoProjeto.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpPut]
        public IActionResult Atualizar(Guid Id, ProjetoDTOCriacao dTO)
        {
            var result = _servicoProjeto.Atualizar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpDelete]
        public IActionResult Remover(Guid Id)
        {
            var result = _servicoProjeto.Remover(Id);
            return Json(string.Format("Format: {0}", result));
        }

    }
}