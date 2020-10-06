using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
    //Regra 1 - Herdar DbContext
    public class DataContext : DbContext
    {
        //Regra 2 - Construtor para receber a connectionstring do banco
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        //Regra 3 - Declarar um set/get DbSet para cada entidade do projeto
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }

        //Regra 4 - Sobrescrever (OVERRIDE) o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
