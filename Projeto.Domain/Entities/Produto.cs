using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int IdFornecedor { get; set; }

        //Relacionamento (TER-1)
        public Fornecedor Fornecedor { get; set; }
    }
}
