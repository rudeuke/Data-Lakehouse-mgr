using System.ComponentModel.DataAnnotations;

namespace application.Domain.Entities
{
    public class File
    {
        [Key]
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
