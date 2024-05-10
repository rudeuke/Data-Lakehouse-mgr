using application.Configuration;
using application.Domain.Enums;

namespace application.Services.FileService
{
    public class FilePathProvider : IFilePathProvider
    {
        private readonly IFileStorageConfiguration _fileStorageConfiguration;

        public FilePathProvider(IFileStorageConfiguration fileStorageConfiguration)
        {
            _fileStorageConfiguration = fileStorageConfiguration;
        }

        public string GetFilePath(string fileName, FileExtension extension)
        {
            return Path.Combine(_fileStorageConfiguration.StorageFolderPath, fileName + "." + extension);
        }
    }
}