using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; //validações

namespace Projeto.Application.Models
{
    public class ProdutoEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do produto.")]
        public string IdProduto { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string Nome { get; set; }

        [RegularExpression("^[0-9.,]{1,9}$", ErrorMessage = "Por favor, informe um preço válido.")]
        [Required(ErrorMessage = "Por favor, informe o preço do produto.")]
        public string Preco { get; set; }

        [RegularExpression("^[0-9]{1,9}$", ErrorMessage = "Por favor, informe uma quantidade válida.")]
        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public string Quantidade { get; set; }

        [RegularExpression("^[0-9]{1,9}$", ErrorMessage = "Por favor, informe um id do fornecedor válido.")]
        [Required(ErrorMessage = "Por favor, informe o id do fornecedor do produto.")]
        public string IdFornecedor { get; set; }
    }
}
