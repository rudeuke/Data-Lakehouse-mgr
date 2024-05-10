using application.Domain.Enums;

namespace application.Services.FileService
{
    public interface IDatabaseFileService
    {
        void CreateFile(string fileName, string content, FileExtension extension);
    }
}