using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using System;

namespace Radius.Application.Controllers
{
  
    public class FaleConoscoController : BaseController
    {
        private readonly IServicoFaleConosco _servicoFaleConosco;
        public FaleConoscoController(
            IServicoFaleConosco servicoFaleConosco)
        {
            _servicoFaleConosco = servicoFaleConosco;
        }

        [Route("ListarTodos")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = _servicoFaleConosco.ListarTodos();
            return Json(lista);
        }


        [Route("ListarTodosAtivos")]
        [HttpGet]
        public IActionResult GetAllAtivos()
        {
            var lista = _servicoFaleConosco.ListarTodosComCondicao();
            return Json(lista);
        }

        [Route("Adicionar")]
        [HttpPost]
        public IActionResult Post(FaleConoscoDTOCriacao dTO)
        {
            var result = _servicoFaleConosco.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [Route("Remover")]
        [HttpDelete]
        public IActionResult Delete(Guid Id)
        {
            var result = _servicoFaleConosco.Remover(Id);
            return Json(string.Format("Format: {0}", result));
        }
    }
}