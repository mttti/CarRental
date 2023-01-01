namespace CarRental.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> cars { get; }

        void Save(Car car);
        Car Delete(int id);
    }
}
