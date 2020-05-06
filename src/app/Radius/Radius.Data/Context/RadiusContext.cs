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
        public DbSet<ProjetoEntidade> Projetos { get; set; }
        public DbSet<UsuarioEntidade> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FaleConoscoMap());
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new CadastroClienteMap());

            modelBuilder.ApplyConfiguration(new EnderecoMap());

            modelBuilder.ApplyConfiguration(new ProjetoMap());

            modelBuilder.ApplyConfiguration(new UsuarioMap());




            base.OnModelCreating(modelBuilder);
        }
    }
}
