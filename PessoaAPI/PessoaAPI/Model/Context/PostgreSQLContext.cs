using Microsoft.EntityFrameworkCore;

namespace PessoaAPI.Model.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(){}

        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) {}

        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
