using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Radius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Data.Mapping
{
    class CadastroClienteMap : IEntityTypeConfiguration<CadastroClienteEntidade>
    {
        public void Configure(EntityTypeBuilder<CadastroClienteEntidade> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.RazaoSocial)
                .IsRequired();

            builder.Property(p => p.NomeFantasia)
                .IsRequired();

            builder.Property(p => p.CNPJ).HasMaxLength(14)
                .IsRequired();


            builder.Property(p => p.Telefone)
               .IsRequired();

            builder.Property(p => p.Email)
               .IsRequired();

            builder.Property(p => p.DataCadastro)
                .IsRequired();

            builder.Property(p => p.DataEncerramento)
                .IsRequired();

            builder.Property(p => p.EstaAtivo)
                .IsRequired();

            builder.HasOne(f => f.Endereco)
               .WithOne(e => e.Cliente);
        }
    }
}
