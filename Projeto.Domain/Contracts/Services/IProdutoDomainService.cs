using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Services
{
    public interface IProdutoDomainService : IBaseDomainService<Produto>
    {
        List<Produto> GetByNome(string nome);
    }
}
