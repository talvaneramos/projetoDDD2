using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        //atributo
        private readonly IFornecedorDomainService fornecedorDomainService;

        //construtor com entrada de argumentos (inicialização)
        public FornecedorApplicationService(IFornecedorDomainService fornecedorDomainService)
        {
            this.fornecedorDomainService = fornecedorDomainService;
        }

        public void Insert(FornecedorCadastroModel model)
        {
            //objeto da classe de entidade
            var fornecedor = new Fornecedor();
            fornecedor.Nome = model.Nome;
            fornecedor.Cnpj = model.Cnpj;

            //realizar o cadastro
            fornecedorDomainService.Insert(fornecedor);
        }

        public void Update(FornecedorEdicaoModel model)
        {
            //objeto da classe de entidade
            var fornecedor = new Fornecedor();
            fornecedor.IdFornecedor = int.Parse(model.IdFornecedor);
            fornecedor.Nome = model.Nome;
            fornecedor.Cnpj = model.Cnpj;

            //realizar a atualização
            fornecedorDomainService.Update(fornecedor);
        }

        public void Delete(int idFornecedor)
        {
            //buscando o fornecedor pelo id
            var fornecedor = fornecedorDomainService.GetById(idFornecedor);

            //realizar a exclusão
            fornecedorDomainService.Delete(fornecedor);
        }

        public List<FornecedorConsultaModel> GetAll()
        {
            var lista = new List<FornecedorConsultaModel>();

            foreach (var item in fornecedorDomainService.GetAll())
            {
                var model = new FornecedorConsultaModel();
                model.IdFornecedor = item.IdFornecedor.ToString();
                model.Nome = item.Nome;
                model.Cnpj = item.Cnpj;

                lista.Add(model);
            }

            return lista;
        }

        public FornecedorConsultaModel GetById(int idFornecedor)
        {
            var fornecedor = fornecedorDomainService.GetById(idFornecedor);

            var model = new FornecedorConsultaModel();
            model.IdFornecedor = fornecedor.IdFornecedor.ToString();
            model.Nome = fornecedor.Nome;
            model.Cnpj = fornecedor.Cnpj;

            return model;
        }
    }
}
