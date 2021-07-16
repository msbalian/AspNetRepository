using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaAPI.Model
{
    [Table("livros")]
    public class Livro
    {
        [Column("liv_iden")]
        public long Id { get; set; }

        [Column("liv_titulo")]
        public string Titulo { get; set; }

        [Column("liv_autor")]
        public string Autor { get; set; }

        [Column("liv_data_lancamento")]
        public DateTime DataLancamento { get; set; }

        [Column("liv_preco")]
        public double preco { get; set; }
    }
}
