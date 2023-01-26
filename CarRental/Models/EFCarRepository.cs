namespace CarRental.Models
{
    public class EFCarRepository : ICarRepository
    {
        private AppDbContext context;
        public EFCarRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Car> cars => context.cars;

        public Car Delete(int id)
        {
            Car dbEntry = context.cars.FirstOrDefault(x => x.Id == id);
            if (dbEntry != null)
            {
                context.cars.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void Save(Car car)
        {
            if (car.Id == 0)
                context.Add(car);
            else
            {
                Car dbEntry = context.cars.FirstOrDefault(x => x.Id == car.Id);
                if (dbEntry != null)
                {
                    dbEntry.PriceList = car.PriceList;
                    dbEntry.IsBroken = car.IsBroken;
                    dbEntry.Color = car.Color;
                    dbEntry.Description = car.Description;
                    dbEntry.ImgSrc = car.ImgSrc;
                    dbEntry.Mileage = car.Mileage;
                    dbEntry.Model = car.Model;
                    dbEntry.PriceListId=car.PriceListId;
                    dbEntry.Brand = car.Brand;
                }
            }
            context.SaveChanges();
        }
    }
}
