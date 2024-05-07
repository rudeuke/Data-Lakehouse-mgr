using application.Domain.Enums;
using application.Configuration;

namespace application.Services.FileService
{
    public class FileService : IFileService
    {
        private readonly IFileStorageConfiguration _fileStorageConfiguration;

        public FileService(IFileStorageConfiguration fileStorageConfiguration)
        {
            _fileStorageConfiguration = fileStorageConfiguration;
        }

        public bool FileExists(string fileName, FileExtension extension)
        {
            string filePath = GetFilePath(fileName, extension);
            return File.Exists(filePath);
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            string filePath = GetFilePath(fileName, extension);
            File.WriteAllText(filePath, content);
        }

        private string GetFilePath(string fileName, FileExtension extension)
        {
            return Path.Combine(_fileStorageConfiguration.StorageFolderPath, fileName + "." + extension);
        }
    }
}