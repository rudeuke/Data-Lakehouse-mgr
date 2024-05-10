using application.Domain.Enums;

namespace application.Services.FileService
{
    public class DiskFileService : IDiskFileService
    {
        private readonly IFilePathProvider _filePathProvider;

        public DiskFileService(IFilePathProvider filePathProvider)
        {
            _filePathProvider = filePathProvider;
        }

        public bool FileExists(string fileName, FileExtension extension)
        {
            string filePath = _filePathProvider.GetFilePath(fileName, extension);
            return File.Exists(filePath);
        }

        public void SaveFileToDisk(string fileName, string content, FileExtension extension)
        {
            string filePath = _filePathProvider.GetFilePath(fileName, extension);
            File.WriteAllText(filePath, content);
        }
    }
}