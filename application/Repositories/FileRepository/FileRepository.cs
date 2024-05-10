using application.Data;

namespace application.Repositories.FileRepository
{
    public class FileRepository : IFileRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FileRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateFileAsync(Domain.Entities.File file)
        {
            _dbContext.Files.Add(file);
            await _dbContext.SaveChangesAsync();
        }
    }
}