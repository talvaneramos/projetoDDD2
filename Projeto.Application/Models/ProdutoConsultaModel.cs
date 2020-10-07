using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Models
{
    public class ProdutoConsultaModel
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Quantidade { get; set; }
        public string Total { get; set; }

        public FornecedorConsultaModel Fornecedor { get; set; }
    }
}
