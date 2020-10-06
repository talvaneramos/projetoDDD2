using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        //Relacionamento (TER-MUITOS)
        public List<Produto> Produtos { get; set; }
    }
}
