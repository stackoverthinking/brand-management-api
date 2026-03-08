using System.ComponentModel.DataAnnotations;

namespace BrandCRUDProject.Models
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
        public int IsActive { get; set; }
    }
}
