﻿using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Services
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa pessoa);

        Pessoa Update(Pessoa pessoa);

        Pessoa FindById(long id);
        List<Pessoa> FindAll();

        void Delete(Pessoa pessoa);

        void DeleteById(long id);
    }
}
