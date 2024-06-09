using application.Domain.Enums;
using application.Repositories.FileRepository;

namespace application.Services.FileService
{
    public class DatabaseFileService : IDatabaseFileService
    {
        private readonly IFileRepository _fileRepository;

        public DatabaseFileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public void CreateFile(string fileName, byte[] fileData)
        {
            var file = new Domain.Entities.File
            {
                FileName = fileName,
                FileData = fileData
            };

            _fileRepository.CreateFileAsync(file);
        }
    }
}