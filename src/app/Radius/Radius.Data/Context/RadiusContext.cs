using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using Radius.Data.Mapping;
using Radius.Domain.Entities;

namespace Radius.Data.Context
{
    public class RadiusContext : DbContext
    {
        public RadiusContext(DbContextOptions<RadiusContext> ctx) : base(ctx)
        {
          
        }

        public DbSet<FaleConoscoEntidade> FaleConosco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FaleConoscoMap());
            modelBuilder.Ignore<Notification>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
