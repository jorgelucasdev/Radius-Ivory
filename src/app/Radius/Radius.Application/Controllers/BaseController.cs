using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Radius.Application.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
    }
}