namespace CarRental.Models.ViewModels
{
    public class OrderViewModel
    {
        public PriceList? PriceList { get; set; }
        public Car? Car { get; set; }
        public Order Order { get; set; }
    }
}
