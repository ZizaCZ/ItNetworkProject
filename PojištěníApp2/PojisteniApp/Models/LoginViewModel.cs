using System.ComponentModel.DataAnnotations;
namespace PojisteniApp.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Zadejte prosím Email")]
        [EmailAddress(ErrorMessage = "Neplatná emailová adresa")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; } = "";

        [Display(Name = "Pamatuj si mě")]
        public bool RememberMe { get; set; }
    }
}
