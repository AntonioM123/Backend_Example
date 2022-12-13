using Microsoft.EntityFrameworkCore;

namespace Example1.Models
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Hotels> Hotels { get; set; }

        public  DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
