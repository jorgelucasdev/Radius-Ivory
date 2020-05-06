using Radius.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Radius.Data.Mapping
{
    class UsuarioMap : IEntityTypeConfiguration<UsuarioEntidade>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntidade> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired(true);

            builder.Property(p => p.CPF)
                .IsRequired();

            builder.Property(p => p.Nome)
                .IsRequired();

            builder.Property(p => p.Email)
               .IsRequired();

            builder.Property(p => p.Celular)
               .IsRequired();

            builder.Property(p => p.Whatsapp)
               .IsRequired();

            builder.Property(p => p.Telefone)
               .IsRequired();

            builder.Property(p => p.Setor)
               .IsRequired();

            builder.Property(p => p.Cargo)
               .IsRequired();

            builder.Property(p => p.Aniversario)
               .IsRequired();

            builder.Property(p => p.DataInicio)
               .IsRequired();

            builder.Property(p => p.DataFim)
                .IsRequired();

            builder.Property(p => p.Status)
               .IsRequired();

            builder.Property(p => p.Observacoes)
               .IsRequired();

            builder.Property(p => p.EstaAtivo)
               .IsRequired();

        }

    }
}
