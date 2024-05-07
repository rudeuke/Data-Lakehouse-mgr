namespace Application.Configuration
{
    public class FileStorageConfiguration : IFileStorageConfiguration
    {
        public string StorageFolderPath { get; } = Path.Combine(Directory.GetCurrentDirectory(), "Data\\Files");
    }
}