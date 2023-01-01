namespace CarRental.Models.ViewModels
{
    public class PriceListViewModel
    {
        public IEnumerable<PriceList> PriceList { get; set; }
        //public PriceList PriceList { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
