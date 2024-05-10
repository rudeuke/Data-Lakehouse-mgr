namespace application.Repositories.FileRepository
{
    public interface IFileRepository
    {
        public Task CreateFileAsync(Domain.Entities.File file);
    }
}