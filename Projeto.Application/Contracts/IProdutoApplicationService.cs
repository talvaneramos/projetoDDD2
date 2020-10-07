using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IProdutoApplicationService
    {
        void Insert(ProdutoCadastroModel model);
        void Update(ProdutoEdicaoModel model);
        void Delete(int idProduto);

        List<ProdutoConsultaModel> GetAll();
        ProdutoConsultaModel GetById(int idProduto);
    }
}
