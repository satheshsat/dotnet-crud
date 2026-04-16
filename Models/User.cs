using System.ComponentModel.DataAnnotations;

namespace dotnetcrud.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string email { get; set; } = string.Empty;

        public DateTime createdat { get; set; } = DateTime.UtcNow;
    }
}
