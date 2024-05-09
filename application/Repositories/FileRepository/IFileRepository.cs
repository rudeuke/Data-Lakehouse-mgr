using application.Domain.Enums;

namespace application.Repositories.FileRepository
{
    public interface IFileRepository
    {
        bool FileExists(string fileName, FileExtension extension);
        void CreateFile(string fileName, string content, FileExtension extension);
    }
}