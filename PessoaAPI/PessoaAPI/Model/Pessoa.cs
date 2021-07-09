using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaAPI.Model
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Column("pes_iden")]
        public long Id { get; set;}

        [Column("pes_nome")]
        public string Nome { get; set; }

        [Column("pes_sobrenome")]
        public string Sobrenome { get; set; }

        [Column("pes_endereco")]
        public string Endereco {get; set; }

        [Column("pes_sexo")]
        public string Sexo { get; set; }

    }
}
