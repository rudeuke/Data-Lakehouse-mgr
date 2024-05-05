using System.ComponentModel.DataAnnotations;

namespace application.Models
{
    public class File
    {
        [Key]
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Contents { get; set; } = string.Empty;
    }
}
