using Microsoft.AspNetCore.Mvc;

namespace Radius.Application.Controllers
{
    public class BaseController : Controller
    {
        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {
            return Json(string.Format("Format"));
        }

        [Route("Post")]
        [HttpPost]
        public IActionResult Post(string data)
        {
            return Json(string.Format("Format: {0}", data));
        }

        [Route("Put")]
        [HttpPut]
        public IActionResult Put(string data)
        {
            return Json(string.Format("Format: {0}", data));
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(bool deletar)
        {
            return Json(string.Format("Format: {0}", deletar));
        }
    }
}