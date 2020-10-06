using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext dataContext;

        //construtor com entrada de argumentos (inicialização)
        public ProdutoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Produto> GetByNome(string nome)
        {
            return dataContext.Produto
                .Where(p => p.Nome.Contains(nome))
                .ToList();
        }
    }
}
