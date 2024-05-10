using application.Domain.Enums;

namespace application.Services.FileService
{
    public interface IFilePathProvider
    {
        string GetFilePath(string fileName, FileExtension extension);
    }
}
