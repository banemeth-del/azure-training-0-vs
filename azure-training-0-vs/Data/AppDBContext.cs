using Microsoft.EntityFrameworkCore;

namespace azure_training_0_vs.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { 
        
        }

        public DbSet<Person> Persons { get; set; }

    }
}
