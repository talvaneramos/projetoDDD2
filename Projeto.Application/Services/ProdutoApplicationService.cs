using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        //atributo
        private readonly IProdutoDomainService produtoDomainService;

        //construtor para inicialização (entrada de argumentos)
        public ProdutoApplicationService(IProdutoDomainService produtoDomainService)
        {
            this.produtoDomainService = produtoDomainService;
        }

        public void Insert(ProdutoCadastroModel model)
        {
            var produto = new Produto();

            produto.Nome = model.Nome;
            produto.Preco = decimal.Parse(model.Preco);
            produto.Quantidade = int.Parse(model.Quantidade);
            produto.IdFornecedor = int.Parse(model.IdFornecedor);

            produtoDomainService.Insert(produto);
        }

        public void Update(ProdutoEdicaoModel model)
        {
            var produto = new Produto();

            produto.IdProduto = int.Parse(model.IdProduto);
            produto.Nome = model.Nome;
            produto.Preco = decimal.Parse(model.Preco);
            produto.Quantidade = int.Parse(model.Quantidade);
            produto.IdFornecedor = int.Parse(model.IdFornecedor);

            produtoDomainService.Update(produto);
        }

        public void Delete(int idProduto)
        {
            var produto = produtoDomainService.GetById(idProduto);
            produtoDomainService.Delete(produto);
        }

        public List<ProdutoConsultaModel> GetAll()
        {
            var lista = new List<ProdutoConsultaModel>();

            foreach (var item in produtoDomainService.GetAll())
            {
                var model = new ProdutoConsultaModel();
                model.IdProduto = item.IdProduto.ToString();
                model.Nome = item.Nome;
                model.Preco = item.Preco.ToString();
                model.Quantidade = item.Quantidade.ToString();
                model.Total = (item.Preco * item.Quantidade).ToString();

                model.Fornecedor = new FornecedorConsultaModel();
                model.Fornecedor.IdFornecedor = item.Fornecedor.IdFornecedor.ToString();
                model.Fornecedor.Nome = item.Fornecedor.Nome;
                model.Fornecedor.Cnpj = item.Fornecedor.Cnpj;

                lista.Add(model);
            }

            return lista;
        }

        public ProdutoConsultaModel GetById(int idProduto)
        {
            var produto = produtoDomainService.GetById(idProduto);

            var model = new ProdutoConsultaModel();
            model.IdProduto = produto.IdProduto.ToString();
            model.Nome = produto.Nome;
            model.Preco = produto.Preco.ToString();
            model.Quantidade = produto.Quantidade.ToString();
            model.Total = (produto.Preco * produto.Quantidade).ToString();

            model.Fornecedor = new FornecedorConsultaModel();
            model.Fornecedor.IdFornecedor = produto.Fornecedor.IdFornecedor.ToString();
            model.Fornecedor.Nome = produto.Fornecedor.Nome;
            model.Fornecedor.Cnpj = produto.Fornecedor.Cnpj;

            return model;
        }
    }
}
