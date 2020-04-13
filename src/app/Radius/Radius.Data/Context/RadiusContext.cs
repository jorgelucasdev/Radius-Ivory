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
        public DbSet<CadastroClienteEntidade> CadastroCliente { get; set; }
        public DbSet<EnderecoEntidade> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FaleConoscoMap());
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new CadastroClienteMap());

            modelBuilder.ApplyConfiguration(new EnderecoMap());




            base.OnModelCreating(modelBuilder);
        }
    }
}
