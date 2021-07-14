using PessoaAPI.Model;
using System.Collections.Generic;

namespace PessoaAPI.Repository
{
    public interface IPessoaRepository
    {
        Pessoa Create(Pessoa pessoa);

        Pessoa Update(Pessoa pessoa);

        Pessoa FindById(long id);
        List<Pessoa> FindAll();

        void Delete(Pessoa pessoa);

        void DeleteById(long id);

        bool Exists(long id);
    }
}
