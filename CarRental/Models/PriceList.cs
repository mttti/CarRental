namespace CarRental.Models
{
    public class PriceList
    {
        public int PriceListId { get; set; }
        public decimal Price { get; set; }
        public decimal BasePrice { get; set; }
        public string CarType { get; set; }

        virtual public ICollection<Car>? cars { get; set; }
    }
}
