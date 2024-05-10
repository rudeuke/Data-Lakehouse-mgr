using application.Domain.Enums;
using application.Services.FileService;

namespace application.Repositories.FileRepository
{
    public class FileRepository : IFileRepository
    {
        private readonly IDiskFileService _diskFileService;

        public FileRepository(IDiskFileService diskFileService)
        {
            _diskFileService = diskFileService;
        }
        public bool FileExists(string fileName, FileExtension extension)
        {
            return _diskFileService.FileExists(fileName, extension);
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            _diskFileService.SaveFileToDisk(fileName, content, extension);
        }
    }
}