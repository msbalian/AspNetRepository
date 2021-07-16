using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Repository
{
    public interface ILivroRepository
    {
        Livro Create(Livro livro);

        Livro Update(Livro livro);

        Livro FindById(long id);
        List<Livro> FindAll();

        void Delete(Livro livro);

        void DeleteById(long id);

        bool Exists(long id);
    }
}
