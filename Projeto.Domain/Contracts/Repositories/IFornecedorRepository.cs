﻿using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        Fornecedor GetByCnpj(string cnpj);
    }
}
