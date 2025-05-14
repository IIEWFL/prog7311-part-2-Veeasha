using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
//Stonis, M. (2022). Model-View-ViewModel. [online] learn.microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm.