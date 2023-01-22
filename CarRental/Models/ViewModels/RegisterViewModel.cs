using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Wpisz adres e-mail!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Wpisz login!")]
        [Display(Name ="Login")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Wpisz hasło!")]
        [StringLength(100, ErrorMessage = "Hasło musi zawierać minimum {2} znaków!.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Wprowadź hasło ponownie!")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Wprowadzone hasła muszą być takie same.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Wprowadź swoje imie!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wprowadź swoje nazwisko!")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public string? ReturnUrl { get; set; } 
    }
}
