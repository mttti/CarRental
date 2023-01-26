namespace CarRental.Models.ViewModels
{
    public class BrokenCarsViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<CarDefect> CarDefects { get; set; }
    }
}
