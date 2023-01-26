namespace CarRental.Models.ViewModels
{
    public class OrderListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
