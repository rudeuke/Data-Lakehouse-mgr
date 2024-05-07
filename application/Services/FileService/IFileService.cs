using application.Domain.Enums;

namespace application.Services.FileService
{
    public interface IFileService
    {
        bool FileExists(string fileName);
        void CreateFile(string fileName, string content, FileExtension extension);
    }
}