using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriEnergyConnect.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; } // "Farmer" or "Employee"

        //public ICollection<Product> Products { get; set; }

    }
}
//GeeksforGeeks (2024). MVC Design Pattern - GeeksforGeeks. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/mvc-design-pattern/.