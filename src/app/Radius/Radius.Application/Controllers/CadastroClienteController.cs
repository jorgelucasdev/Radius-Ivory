using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using System;


namespace Radius.Application.Controllers
{
    public class CadastroClienteController : ApiController
    {

        private readonly IServicoCadastroCliente _servicoCadastroCliente;
        public CadastroClienteController(
            IServicoCadastroCliente servicoCadastroCliente)
        {
            _servicoCadastroCliente = servicoCadastroCliente;
        }

        [HttpGet]
        //[Authorize(Policy = "Ler")]
        public IActionResult ListarTodos()
        {
            var lista = _servicoCadastroCliente.ListarTodos();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult ListarTodosAtivos()
        {
            var lista = _servicoCadastroCliente.ListarTodosComCondicao();
            return Json(lista);
        }

        [HttpGet]
        public IActionResult ListarPorId(Guid id)
        {
            var lista = _servicoCadastroCliente.ListarPorId(id);
            return Json(lista);
        }

        [HttpGet]
        public IActionResult FiltrarResultados([FromQuery] FiltroClienteDTO filtro)
        {
            var lista = _servicoCadastroCliente.Buscar(filtro);

            return Json(lista);
        }

        [HttpPost]
        //[Authorize(Policy = "Gravar")]
        public IActionResult Adicionar(CadastroClienteDTOCriacao dTO)
        {
            var result = _servicoCadastroCliente.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpPut]
        public IActionResult Atualizar(Guid Id, CadastroClienteDTOCriacao dTO)
        {
            var result = _servicoCadastroCliente.Atualizar(dTO);
            return Json(string.Format("Format: {0}", result));
        }

        [HttpDelete]
        public IActionResult Remover(Guid Id)
        {
            var result = _servicoCadastroCliente.Remover(Id);
            return Json(string.Format("Format: {0}", result));
        }
    }
}
