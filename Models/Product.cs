using System.ComponentModel.DataAnnotations;

namespace ProductListChallenge.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0.01, 100000)]
        public decimal Price { get; set; }
    }
}