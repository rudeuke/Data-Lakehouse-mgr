using application.Data;
using application.Domain.Enums;
using application.Services.FileService;

namespace application.Repositories.FileRepository
{
    public class FileRepository : IFileRepository
    {
        private readonly IDiskFileService _diskFileService;
        private readonly ApplicationDbContext _dbContext;
        private readonly IFilePathProvider _filePathProvider;

        public FileRepository(IDiskFileService diskFileService, ApplicationDbContext dbContext, IFilePathProvider filePathProvider)
        {
            _diskFileService = diskFileService;
            _dbContext = dbContext;
            _filePathProvider = filePathProvider;
        }

        public bool FileExists(string fileName, FileExtension extension)
        {
            return _diskFileService.FileExists(fileName, extension);
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            _diskFileService.SaveFileToDisk(fileName, content, extension);
        }

        public async Task CreateFileAsync(string fileName, string content, FileExtension extension)
        {
            var file = new Domain.Entities.File
            {
                Name = fileName,
                Path = _filePathProvider.GetFilePath(fileName, extension),
                Content = content
            };

            _dbContext.Files.Add(file);
            await _dbContext.SaveChangesAsync();
        }
    }
}