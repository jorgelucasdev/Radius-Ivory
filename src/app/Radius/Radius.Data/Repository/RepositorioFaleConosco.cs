using Radius.Data.Context;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;

namespace Radius.Data.Repository
{
    public class RepositorioFaleConosco : Repositorio<FaleConoscoEntidade>, IRepositorioFaleConosco
    {
        public RepositorioFaleConosco(RadiusContext db) : base(db)
        {

        }
    }
}
