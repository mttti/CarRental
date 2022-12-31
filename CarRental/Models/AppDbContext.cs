using Microsoft.EntityFrameworkCore;

namespace CarRental.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<PriceList> priceLists { get; set; }
        public string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath =Path.Join(path, "priceList.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>().HasData(
                new PriceList() { PriceListId = 1, Price = 400, BasePrice = 800, CarType = "Kabriolet" },
                new PriceList() { PriceListId = 2, Price = 100, BasePrice = 200, CarType = "Kompakt" },
                new PriceList() { PriceListId = 3, Price = 250, BasePrice = 500, CarType = "SUV" }
                );
        }
    }
}
