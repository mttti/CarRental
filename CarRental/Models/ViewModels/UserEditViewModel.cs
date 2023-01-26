using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.ViewModels
{
    public class UserEditViewModel
    {
        public AppUser User { get; set; }

        public List<SelectListItem>? Roles{ get; set; }
    }
}
