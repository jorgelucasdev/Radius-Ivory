using System.Collections.Generic;
using System.Security.Claims;

namespace Radius.CrossCutting.Identity.Abastraction
{
    public interface IUserIdentity
    {
        string Nome { get; }
        bool EstaAutenticado();
        IEnumerable<Claim> ObterClaimsIdentity();
    }
}
