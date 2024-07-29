using Microsoft.EntityFrameworkCore;

namespace ProjetoCRUD.DBContext
{
    public class ContatoDbContext : DbContext
    {
        public ContatoDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Contatos> Contatos { get; set; }
    }
}
