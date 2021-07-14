﻿using PessoaAPI.Model;
using PessoaAPI.Model.Context;
using PessoaAPI.Repository;
using PessoaAPI.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PessoaAPI.Business.Implementations
{
    public class PessoaBusinessImplementation : IPessoaBusiness
    {

        private readonly IPessoaRepository _repository;

        public PessoaBusinessImplementation(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public Pessoa Create(Pessoa pessoa)
        {
            return _repository.Create(pessoa);
        }


        public void Delete(Pessoa pessoa)
        {
            _repository.Delete(pessoa);
        }

        public void DeleteById(long id)
        {
            _repository.DeleteById(id);
        }

        public List<Pessoa> FindAll()
        {
            return _repository.FindAll();
        }


        public Pessoa FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return _repository.Update(pessoa);
        }
        

    }
}
