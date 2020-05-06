using System;
using Radius.Service.DTOs;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;


namespace Radius.Application.Controllers
{
    public class UsuarioController : ApiController
    {

        private readonly IservicoUsuario _servicoUsuario;
        public UsuarioController(
            IservicoUsuario servicoUsuario)
        {
            _servicoUsuario = servicoUsuario;
        }

        [HttpGet]
        //[Authorize(Policy = "Ler")]
        public IActionResult ListarTodos()
        {
            var lista = _servicoUsuario.ListarTodos();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult ListarTodosAtivos()
        {
            var lista = _servicoUsuario.ListarTodosComCondicao();
            return Json(lista);
        }

        [HttpPost]
        //[Authorize(Policy = "Gravar")]
        public IActionResult Adicionar(UsuarioDTOCriacao dTO)
        {
            var result = _servicoUsuario.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpPut]
        public IActionResult Atualizar(Guid Id, UsuarioDTOCriacao dTO)
        {
            var result = _servicoUsuario.Atualizar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpDelete]
        public IActionResult Remover(Guid Id)
        {
            var result = _servicoUsuario.Remover(Id);
            return Json(string.Format("Format: {0}", result));
        }

    }
}