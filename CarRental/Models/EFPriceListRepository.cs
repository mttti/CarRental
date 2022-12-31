namespace CarRental.Models
{
    public class EFPriceListRepository : IPriceListRepository
    {
        private AppDbContext context;

        public EFPriceListRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<PriceList> priceLists => context.priceLists;

        public PriceList Delete(int id)
        {
            PriceList dbEntry = context.priceLists.FirstOrDefault(o => o.PriceListId == id);
            if (dbEntry != null)
            {
                context.priceLists.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void Save(PriceList priceList)
        {
            if (priceList.PriceListId == 0)
                context.Add(priceList);
            else
            {
                PriceList dbEntry = context.priceLists.FirstOrDefault(o => o.PriceListId == priceList.PriceListId);
                if (dbEntry != null)
                {
                    dbEntry.Price = priceList.Price;
                    dbEntry.BasePrice = priceList.BasePrice;
                    dbEntry.CarType = priceList.CarType;
                }
            }
            context.SaveChanges();
        }
    }
}
