using Microsoft.EntityFrameworkCore;

namespace MVCProjectDemo.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> customers { get; set; }
    }
}
