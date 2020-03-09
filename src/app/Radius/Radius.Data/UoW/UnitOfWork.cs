using Radius.Data.Context;
using Radius.Domain.Interfaces.Repositories;

namespace Radius.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RadiusContext _context;

        public UnitOfWork(RadiusContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
