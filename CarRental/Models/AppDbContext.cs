using CarRental.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;

namespace CarRental.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<PriceList> priceLists { get; set; }
        public DbSet<Car> cars { get; set; }
        public string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CarRental.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>().HasData(
                new PriceList() { PriceListId = 1, Price = 400, BasePrice = 800, CarType = "Kabriolet" },
                new PriceList() { PriceListId = 2, Price = 100, BasePrice = 200, CarType = "Kompakt" },
                new PriceList() { PriceListId = 3, Price = 250, BasePrice = 500, CarType = "SUV" }
                );

            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1, Color = "Czarny", IsBroken = false, Mileage = 100, Description = "Czarne bmw. Szybsze niż wiatr.", ImgSrc = "bmw.png", PriceListId=1, Brand="BMW" },
                new Car() { Id = 2, Color = "Czerwony", IsBroken = true, Mileage = 40, Description = "Czerwone audi. Brak dachu zwiększa przyspieszenie.", ImgSrc = "audi.png", PriceListId=2, Brand="AUDI" },
                new Car() { Id = 3, Color = "Biały", IsBroken = false, Mileage = 200, Description = "Biały Citroen. Duże gabarty pozwolą na komfortowe podróże dla całej rodziny.", ImgSrc = "citroen.png",PriceListId=3, Brand="CITROEN" }
                );


            modelBuilder.Entity<PriceList>()
                .HasMany(c => c.cars)
                .WithOne(p => p.PriceList)
                .HasForeignKey(k => k.PriceListId);


                


        }
    }
}
