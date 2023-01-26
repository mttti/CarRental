namespace CarRental.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private AppDbContext context;

        public EFOrderRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public IEnumerable<Order> Orders => context.orders;

        public Order Delete(int id)
        {
            Order dbEntry = context.orders.FirstOrDefault(r => r.Id ==id);
            if (dbEntry != null)
            {
                context.orders.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void Save(Order order)
        {
            if (order.Id == 0)
                context.Add(order);
            else
            {
                Order dbEntry = context.orders.FirstOrDefault(r => r.Id == order.Id);
                if (dbEntry != null)
                {
                    dbEntry.StartDate = order.StartDate;
                    dbEntry.EndDate = order.EndDate;
                    dbEntry.Price = order.Price;
                    dbEntry.CarId = order.CarId;
                    dbEntry.UserId = order.UserId;
                    dbEntry.IsReported = order.IsReported;
                    dbEntry.IsReviewed = order.IsReviewed;
                }
            }
            context.SaveChanges();
        }
    }
}
