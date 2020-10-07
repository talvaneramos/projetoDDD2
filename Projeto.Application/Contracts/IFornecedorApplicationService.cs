using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IFornecedorApplicationService
    {
        void Insert(FornecedorCadastroModel model);
        void Update(FornecedorEdicaoModel model);
        void Delete(int idFornecedor);

        List<FornecedorConsultaModel> GetAll();
        FornecedorConsultaModel GetById(int idFornecedor);
    }
}

