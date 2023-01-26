namespace CarRental.Models
{
    public interface ICarDefectRepository
    {
        IEnumerable<CarDefect> carDefects { get; }

        void Save(CarDefect carDefect);
        CarDefect Delete(int id);
    }
}
