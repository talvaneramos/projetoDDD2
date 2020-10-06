using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            //nome da tabela
            builder.ToTable("Fornecedor");

            //chave primária
            builder.HasKey(f => f.IdFornecedor);

            //demais campos..
            builder.Property(f => f.IdFornecedor)
                .HasColumnName("IdFornecedor")
                .IsRequired();

            builder.Property(f => f.Nome)
               .HasColumnName("Nome")
               .HasMaxLength(150)
               .IsRequired();

            builder.Property(f => f.Cnpj)
               .HasColumnName("Cnpj")
               .HasMaxLength(25)
               .IsRequired();


        }
    }
}
