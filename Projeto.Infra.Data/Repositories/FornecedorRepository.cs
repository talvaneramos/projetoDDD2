using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
       
        private readonly DataContext dataContext;

        //construtor para inicializar o DataContext
        public FornecedorRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Fornecedor GetByCnpj(string cnpj)
        {
            return dataContext.Fornecedor
                .FirstOrDefault(f => f.Cnpj.Equals(cnpj));
        }
    }
}
