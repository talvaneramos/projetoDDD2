using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class FornecedorDomainService : BaseDomainService<Fornecedor>, IFornecedorDomainService
    {
        private readonly IFornecedorRepository fornecedorRepository;

        public FornecedorDomainService(IFornecedorRepository fornecedorRepository)
            : base(fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public override void Insert(Fornecedor obj)
        {
            if(fornecedorRepository.GetByCnpj(obj.Cnpj) == null)
            {
                fornecedorRepository.Insert(obj);
            }
            else
            {
                throw new Exception("Erro, o CNPJ informado já encontra-se cadastrado. ");
            }
        }

        public Fornecedor GetByCnpj(string cnpj)
        {
            return fornecedorRepository.GetByCnpj(cnpj);
        }
    }
}
