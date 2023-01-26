namespace CarRental.Models
{
    public class EFCarDefectRepository : ICarDefectRepository
    {

        private AppDbContext _context;

        public EFCarDefectRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarDefect> carDefects => _context.carDefects;

        public CarDefect Delete(int id)
        {
            CarDefect dbEntry = _context.carDefects.FirstOrDefault(c => c.Id == id);
            if (dbEntry != null)
            {
                _context.carDefects.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }

        public void Save(CarDefect carDefect)
        {
            if (carDefect.Id == 0)
                _context.Add(carDefect);
            else
            {
                CarDefect dbEntry = _context.carDefects.FirstOrDefault(i => i.Id == carDefect.Id);
                if (dbEntry != null)
                {
                    dbEntry.Description = carDefect.Description;
                    dbEntry.CarId = carDefect.CarId;
                    dbEntry.OrderId = carDefect.OrderId;
                    dbEntry.UserName = carDefect.UserName;
                    dbEntry.IsSolved = carDefect.IsSolved;
                }
            }
            _context.SaveChanges();
        }
    }
}



