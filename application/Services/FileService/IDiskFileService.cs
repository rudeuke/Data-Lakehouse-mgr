using application.Domain.Enums;

namespace application.Services.FileService
{
    public interface IDiskFileService
    {
        bool FileExists(string fileName, FileExtension extension);
        void SaveFileToDisk(string fileName, string content, FileExtension extension);
    }
}