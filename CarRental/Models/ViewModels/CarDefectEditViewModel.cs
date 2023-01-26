using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Models.ViewModels
{
    public class CarDefectEditViewModel
    {
        public CarDefect carDefect { get; set; }

        public List<SelectListItem>? CarIDs { get; set; }

        public List<SelectListItem>? OrderIDs { get; set; }

        public List<SelectListItem>? UserNames { get; set; }

    }
}
