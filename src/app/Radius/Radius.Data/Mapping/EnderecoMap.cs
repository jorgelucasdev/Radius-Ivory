using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Radius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Data.Mapping
{
    class EnderecoMap : IEntityTypeConfiguration<EnderecoEntidade>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntidade> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Logradouro)
                .IsRequired(); 
            
            builder.Property(p => p.Numero)
                .IsRequired();

            builder.Property(p => p.Complemento);

            builder.Property(p => p.Bairro)
                .IsRequired();

            builder.Property(p => p.CEP)
                .IsRequired();

            builder.Property(p => p.Cidade)
                .IsRequired();

            builder.Property(p => p.Estado)
                .IsRequired();

            builder.Property(p => p.EstaAtivo)
                .IsRequired();

        }
    }
}
