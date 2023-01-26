using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Models.ViewModels
{
    public class CarEditViewModel
    {
        public Car Car { get; set; }

        public List<SelectListItem>? CarTypes { get; set; }
    }
}
