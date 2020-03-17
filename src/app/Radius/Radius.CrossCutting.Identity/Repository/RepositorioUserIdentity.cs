using Microsoft.AspNetCore.Http;
using Radius.CrossCutting.Identity.Abastraction;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Radius.CrossCutting.Identity.Repository
{
    public class RepositorioUserIdentity : IUserIdentity
    {
        private readonly IHttpContextAccessor _accessor;

        public RepositorioUserIdentity(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public string Nome => ObterNome();
        private string ObterNome()
        {
            return _accessor.HttpContext.User.Identity.Name ??
                   _accessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
        }
        public bool EstaAutenticado()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public IEnumerable<Claim> ObterClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }
    }
}
