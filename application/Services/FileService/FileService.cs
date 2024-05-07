using application.Domain.Enums;

namespace application.Services.FileService
{
    public class FileService : IFileService
    {
        public bool FileExists(string fileName)
        {
            return File.Exists("../" + fileName);
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            File.WriteAllText($"../{fileName}.{extension}", content);
        }
    }
}