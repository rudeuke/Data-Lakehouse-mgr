using application.Domain.Enums;
using application.Services.FileService;

namespace application.Repositories.FileRepository
{
    public class FileRepository : IFileRepository
    {
        private readonly IFileService _fileService;

        public FileRepository(IFileService fileService)
        {
            _fileService = fileService;
        }
        public bool FileExists(string fileName)
        {
            return _fileService.FileExists(fileName);
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            _fileService.CreateFile(fileName, content, extension);
        }
    }
}