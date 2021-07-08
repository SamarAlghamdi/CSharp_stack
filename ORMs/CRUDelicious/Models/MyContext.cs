using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dishe> Dishes { get; set; }
    }
}