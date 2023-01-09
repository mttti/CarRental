using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
    }
}
