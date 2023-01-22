using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Wpisz login!")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Wpisz hasło!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
