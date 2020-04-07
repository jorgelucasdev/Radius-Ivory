using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Radius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Data.Mapping
{
    class FuncionarioMap : IEntityTypeConfiguration<FuncionarioEntidade>
    {
        public void Configure(EntityTypeBuilder<FuncionarioEntidade> builder)
        {
            //TODO: Terminar esta cricao

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.EstaAtivo)
                .IsRequired();

            builder.Property(p => p.DataCriacao)
                .IsRequired();

            builder.Property(p => p.DataAtualizacao)
                .IsRequired(false);
        }
    }
}
