using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Radius.Application.Controllers
{
    public class BaseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}