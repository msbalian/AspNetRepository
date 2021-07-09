using PessoaAPI.Model;
using PessoaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PessoaAPI.Services.Implementations
{
    public class PessoaServiceImplementation : IPessoaService
    {

        private PostgreSQLContext _context;

        public PessoaServiceImplementation(PostgreSQLContext context)
        {
            _context = context;
        }

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }


        public void Delete(Pessoa pessoa)
        {
        }

        public void DeleteById(long id)
        {
        }

        public List<Pessoa> FindAll()
        {

            return _context.Pessoas.ToList();

        }


        public Pessoa FindById(long id)
        {
            return _context.Pessoas.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }
        

    }
}
