using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
