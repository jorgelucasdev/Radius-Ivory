using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Radius.Application.Interfaces;
using Radius.Application.ViewModels;

namespace Radius.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        private readonly IServicoFaleConosco _servicoFaleConosco;
        public BaseController(
            IServicoFaleConosco servicoFaleConosco)
        {
            _servicoFaleConosco = servicoFaleConosco;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = _servicoFaleConosco.ListarTodos();
            return Json(lista);
        }

        [Route("Post")]
        [HttpPost]
        public IActionResult Post(FaleConoscoDTO dTO)
        {
            var result = _servicoFaleConosco.Adicionar(dTO);
            return Json(string.Format("Format: {0}", result));
        }
    }
}