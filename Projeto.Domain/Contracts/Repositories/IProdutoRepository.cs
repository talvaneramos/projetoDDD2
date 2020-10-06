using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> GetByNome(string nome);
    }
}