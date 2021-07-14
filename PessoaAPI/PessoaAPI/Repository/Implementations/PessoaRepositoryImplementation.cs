using PessoaAPI.Model;
using PessoaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PessoaAPI.Repository.Implementations
{
    public class PessoaRepositoryImplementation : IPessoaRepository
    {

        private PostgreSQLContext _context;

        public PessoaRepositoryImplementation(PostgreSQLContext context)
        {
            _context = context;
        }

        public Pessoa Create(Pessoa pessoa)
        {

            try
            {
                _context.Add(pessoa);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return pessoa;
        }


        public void Delete(Pessoa pessoa)
        {

            try
            {
                _context.Remove(pessoa);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteById(long id)
        {
            var pessoaBuscada = _context.Pessoas.Single(p => p.Id.Equals(id));

            if (pessoaBuscada != null)
            {

                try
                {
                    _context.Pessoas.Remove(pessoaBuscada);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }

            }

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
            if (_context.Pessoas.Any(p => p.Id.Equals(pessoa.Id)))
            {
                var result = _context.Pessoas.SingleOrDefault(p => p.Id.Equals(pessoa.Id));
                if (result != null)
                {
                    try
                    {
                        _context.Entry(result).CurrentValues.SetValues(pessoa);
                        _context.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }

            }
            else
            {
                return new Pessoa();
            }
            
            return pessoa;
        }

        public bool Exists(long id)
        {
            return _context.Pessoas.Any(p => p.Id.Equals(id));
        }



    }
}
