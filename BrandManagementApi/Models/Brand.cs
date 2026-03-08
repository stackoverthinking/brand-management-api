using System.ComponentModel.DataAnnotations;

namespace BrandManagementApi.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Category { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
