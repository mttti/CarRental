namespace CarRental.Models
{
    public interface IPriceListRepository
    {
        IEnumerable<PriceList> priceLists { get; }

        void Save(PriceList priceList);

        PriceList Delete(int id);
    }
}
