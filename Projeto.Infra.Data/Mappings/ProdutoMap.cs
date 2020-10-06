using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.IdProduto)
                .HasColumnName("IdProduto")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Preco)
               .HasColumnName("Preco")
               .HasColumnType("decimal(18,2)")
               .IsRequired();

            builder.Property(p => p.Quantidade)
               .HasColumnName("Quantidade")
               .IsRequired();

            builder.Property(p => p.IdFornecedor)
               .HasColumnName("IdFornecedor")
               .IsRequired();

            //Mapeamento de relacionamento (chave estrangeira)
            builder.HasOne(p => p.Fornecedor) //Produto TEM 1 Fornecedor
                .WithMany(f => f.Produtos) //Fornecedor TEM MUITOS Produtos
                .HasForeignKey(p => p.IdFornecedor); //Chave estrangeira
        }
    }
}
