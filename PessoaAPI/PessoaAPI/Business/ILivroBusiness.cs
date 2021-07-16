using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Business
{
    public interface ILivroBusiness
    {
        Livro Create(Livro livro);

        Livro Update(Livro livro);

        Livro FindById(long id);
        
        List<Livro> FindAll();

        void Delete(Livro livro);

        void DeleteById(long id);
    }
}
