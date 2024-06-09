using Microsoft.EntityFrameworkCore;

namespace application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Domain.Entities.File>().ToTable("Files");
        }

        public DbSet<Domain.Entities.File>? Files { get; set; }
    }
}