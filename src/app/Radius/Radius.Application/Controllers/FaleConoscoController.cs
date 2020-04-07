using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using System;

namespace Radius.Application.Controllers
{
    public class FaleConoscoController : ApiController
    {
        private readonly IServicoFaleConosco _servicoFaleConosco;
        public FaleConoscoController(
            IServicoFaleConosco servicoFaleConosco)
        {
            _servicoFaleConosco = servicoFaleConosco;
        }

        [HttpGet]
        [Authorize(Policy = "Ler")]
        public IActionResult ListarTodos()
        {
            var lista = _servicoFaleConosco.ListarTodos();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult ListarTodosAtivos()
        {
            var lista = _servicoFaleConosco.ListarTodosComCondicao();
            return Json(lista);
        }

        [HttpPost]
        [Authorize(Policy = "Gravar")]
        public IActionResult Adicionar(FaleConoscoDTOCriacao dTO)
        {
            var result = _servicoFaleConosco.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpDelete]
        public IActionResult Remover(Guid Id)
        {
            var result = _servicoFaleConosco.Remover(Id);
            return Json(string.Format("Format: {0}", result));
        }
    }
}