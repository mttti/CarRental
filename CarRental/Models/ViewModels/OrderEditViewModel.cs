using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Models.ViewModels
{
    public class OrderEditViewModel
    {
        public Order Order { get; set; }

        public List<SelectListItem>? carIds { get; set; }

        public List<SelectListItem>? userNames { get; set; }
    }
}
