using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage ="Imie jest wymagane!")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Nazwisko jest wymagane!")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Adres e-mail jest wymagany!")]
        [EmailAddress]
        public string Email { get; set; }

        public string? Role { get; set; }
    }
}
