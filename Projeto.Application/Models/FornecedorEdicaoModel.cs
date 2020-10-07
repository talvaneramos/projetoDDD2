using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class FornecedorEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do fornecedor.")]
        public string IdFornecedor { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do fornecedor.")]
        public string Nome { get; set; }

        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Por favor, informe um CNPJ válido.")]
        [Required(ErrorMessage = "Por favor, informe o cnpj do fornecedor.")]
        public string Cnpj { get; set; }
    }
}