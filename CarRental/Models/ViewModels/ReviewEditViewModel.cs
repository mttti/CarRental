using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Models.ViewModels
{
    public class ReviewEditViewModel
    {
        public Review Review { get; set; }

        public List<SelectListItem>? selectListItem { get; set; }
    }
}
