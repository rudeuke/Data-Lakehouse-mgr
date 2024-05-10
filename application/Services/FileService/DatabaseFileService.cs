using application.Domain.Enums;
using application.Repositories.FileRepository;

namespace application.Services.FileService
{
    public class DatabaseFileService : IDatabaseFileService
    {
        private readonly IFilePathProvider _filePathProvider;
        private readonly IFileRepository _fileRepository;

        public DatabaseFileService(IFilePathProvider filePathProvider, IFileRepository fileRepository)
        {
            _filePathProvider = filePathProvider;
            _fileRepository = fileRepository;
        }

        public void CreateFile(string fileName, string content, FileExtension extension)
        {
            var file = new Domain.Entities.File
            {
                Name = fileName,
                Path = _filePathProvider.GetFilePath(fileName, extension),
                Content = content
            };

            _fileRepository.CreateFileAsync(file);
        }
    }
}