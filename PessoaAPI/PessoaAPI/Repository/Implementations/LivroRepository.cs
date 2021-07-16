using PessoaAPI.Model;
using PessoaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PessoaAPI.Repository.Implementations
{
    public class LivroRepository : ILivroRepository
    {

        private PostgreSQLContext _context;

        public LivroRepository(PostgreSQLContext context)
        {
            _context = context;
        }

        public Livro Create(Livro livro)
        {

            try
            {
                _context.Add(livro);
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return livro;
        }


        public void Delete(Livro livro)
        {

            try
            {
                _context.Remove(livro);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteById(long id)
        {
            var livroBuscado = _context.Livros.Single(p => p.Id.Equals(id));

            if (livroBuscado != null)
            {

                try
                {
                    _context.Livros.Remove(livroBuscado);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        public List<Livro> FindAll()
        {

            return _context.Livros.ToList();

        }


        public Livro FindById(long id)
        {
            return _context.Livros.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Livro Update(Livro livro)
        {
            if (_context.Livros.Any(p => p.Id.Equals(livro.Id)))
            {
                var result = _context.Livros.SingleOrDefault(p => p.Id.Equals(livro.Id));
                if (result != null)
                {
                    try
                    {
                        _context.Entry(result).CurrentValues.SetValues(livro);
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
                return null;
            }
            
            return livro;
        }

        public bool Exists(long id)
        {
            return _context.Livros.Any(p => p.Id.Equals(id));
        }



    }
}
