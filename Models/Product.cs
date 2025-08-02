using System.ComponentModel.DataAnnotations;

namespace CrudWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        
        public int Stock { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}