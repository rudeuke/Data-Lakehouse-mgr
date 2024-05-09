using Microsoft.EntityFrameworkCore;

namespace application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.Entities.File>? Files { get; set; }
    }
}