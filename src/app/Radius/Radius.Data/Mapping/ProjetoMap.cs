using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Radius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Data.Mapping
{
    class ProjetoMap : IEntityTypeConfiguration<ProjetoEntidade>
    {
        public void Configure(EntityTypeBuilder<ProjetoEntidade> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired(true);

            builder.Property(p => p.Empresa)
                .IsRequired();

            builder.Property(p => p.CNPJ)
                .IsRequired();

            builder.Property(p => p.Cidade)
               .IsRequired();

            builder.Property(p => p.Estado)
               .IsRequired();

            builder.Property(p => p.Responsavel)
                .IsRequired();

            builder.Property(p => p.SetorR)
               .IsRequired();

            builder.Property(p => p.TelefoneR)
               .IsRequired();

            builder.Property(p => p.EmailR)
               .IsRequired();

            builder.Property(p => p.Corresponsavel)
               .IsRequired();

            builder.Property(p => p.SetorC)
               .IsRequired();

            builder.Property(p => p.TelefoneC)
               .IsRequired();

            builder.Property(p => p.EmailC)
               .IsRequired();

            builder.Property(p => p.NomeProjeto)
               .IsRequired();

            builder.Property(p => p.Segmento)
               .IsRequired();

            builder.Property(p => p.DataInicio)
                .IsRequired();

            builder.Property(p => p.DataTermino)
                .IsRequired();

            builder.Property(p => p.Apresentacao)
               .IsRequired();

            builder.Property(p => p.Descricao)
               .IsRequired();

            builder.Property(p => p.Justificativa)
               .IsRequired();

            builder.Property(p => p.ObjetivoGeral)
               .IsRequired();

            builder.Property(p => p.ObjetivoEspecifico)
               .IsRequired();

            builder.Property(p => p.EstaAtivo)
               .IsRequired();

        }
    }
}