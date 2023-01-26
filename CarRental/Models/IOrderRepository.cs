namespace CarRental.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }

        void Save(Order order);
        Order Delete(int id);
    }
}
