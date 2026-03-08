using System.ComponentModel.DataAnnotations;

namespace BrandCRUDProject.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public int IsActive { get; set; }
    }
}
