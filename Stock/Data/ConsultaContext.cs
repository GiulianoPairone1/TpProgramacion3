using Stock.Data.Entities;

namespace Stock.Data
{
    public class ConsultaContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
