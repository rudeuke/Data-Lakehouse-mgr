using application.Domain.Enums;

namespace application.Repositories
{
    public interface IFileRepository
    {
        bool FileExists(string fileName);
        void CreateFile(string fileName, string content, FileExtension extension);
    }
}