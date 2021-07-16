using PessoaAPI.Model;
using PessoaAPI.Repository;
using System.Collections.Generic;

namespace PessoaAPI.Business.Implementations
{
    public class LivroBusiness: ILivroBusiness
    {

        private readonly ILivroRepository _repository;

        public LivroBusiness(ILivroRepository repository)
        {
            _repository = repository;
        }

        public Livro Create(Livro livro)
        {
            return _repository.Create(livro);
        }


        public void Delete(Livro livro)
        {
            _repository.Delete(livro);
        }

        public void DeleteById(long id)
        {
            _repository.DeleteById(id);
        }

        public List<Livro> FindAll()
        {
            return _repository.FindAll();
        }


        public Livro FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Livro Update(Livro livro)
        {
            return _repository.Update(livro);
        }

    }
}
