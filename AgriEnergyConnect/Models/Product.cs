using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        // Add UserId as a foreign key reference
        [Required]
        public int UserId { get; set; }

        public User? User { get; set; } // Navigation property (optional)
    }
}
