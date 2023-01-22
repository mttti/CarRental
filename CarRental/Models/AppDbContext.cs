using CarRental.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;

namespace CarRental.Models
{
    //public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<PriceList> priceLists { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Review> reviews { get; set; }
        public string DbPath { get; set; }

        //public AppDbContext()
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CarRental.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hashed = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser {Id= "26481377-54b6-4866-9552-673295ea5e98", Email = "admin@admin.pl", NormalizedEmail = "ADMIN@ADMIN.PL", UserName = "Admin", NormalizedUserName = "ADMIN", PasswordHash = hashed.HashPassword(null, "Administrator1!"), Name="Mateusz", LastName="Magiera"},

                new AppUser {Id= "ff023250-c33f-48c2-80b8-703f5ab34531", Email = "Mietekmechanik@onet.pl", NormalizedEmail="MIETEKMECHANIK@ONET.PL", UserName="MietekMechanik", NormalizedUserName="MIETEKMECHANIK", PasswordHash=hashed.HashPassword(null,"Mieczyslaw1978?"), Name="Mieczyslaw", LastName="Kowalski"},

                new AppUser {Id= "a4d55acc-2778-48ed-bd6e-7d454db01b09", Email="jnowak@interia.pl", NormalizedEmail="JNOWAK@INTERIA.PL", UserName="Nowak_Jan", NormalizedUserName="NOWAK_JAN", PasswordHash=hashed.HashPassword(null,"Janek2000#"), Name="Jan", LastName="Kowalski"}
                );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole {Id= "0773fad5-d7e7-47e1-9ef8-6fad8120694f", Name = "admin", NormalizedName="ADMIN"},
                new IdentityRole {Id= "5d1880d4-bc4a-4873-9043-5320c72b35c0", Name ="mechanik", NormalizedName="MECHANIK"}
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                //Administrator role
                new IdentityUserRole<string>() { RoleId = "0773fad5-d7e7-47e1-9ef8-6fad8120694f", UserId = "26481377-54b6-4866-9552-673295ea5e98" },
                //Mechanic role
                new IdentityUserRole<string>() { RoleId = "5d1880d4-bc4a-4873-9043-5320c72b35c0", UserId= "ff023250-c33f-48c2-80b8-703f5ab34531" }
                );


            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, CarId = 1, Rating = 4, Description="Przyjemnyd samochód"},
                new Review() { Id = 2, CarId = 2, Rating = 2, Description="Słaby samochód"},
                new Review() { Id = 3, CarId = 3, Rating = 3, Description="Średni samochód"}
                );

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

            modelBuilder.Entity<Car>()
                .HasMany(r=>r.Reviews)
                .WithOne(c=>c.Car)
                .HasForeignKey(k => k.CarId);
            base.OnModelCreating(modelBuilder);

        }
    }
}
