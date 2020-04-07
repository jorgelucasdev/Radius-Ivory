using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Radius.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class ApiController : Controller
    {
        public ApiController()
        {

        }

        private bool EstaValidaOperacao()
        {
            return true;
        }

        protected new IActionResult Resposta(object result = null)
        {
            if (EstaValidaOperacao())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = new { }
            });
        }
    }
}