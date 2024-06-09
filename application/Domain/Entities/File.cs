using System.ComponentModel.DataAnnotations;

namespace application.Domain.Entities
{
    public class File
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FileName { get; set; }

        [Required]
        public byte[] FileData { get; set; }
    }
}
