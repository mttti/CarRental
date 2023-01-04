using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podać kolor samochodu.")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę pliku .png.")]
        public string ImgSrc { get; set; }

        [Required(ErrorMessage = "Proszę wprowadzić opis. Maksymalna długość: 200 znaków.")]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Proszę podać przebieg samochodu.")]
        public int Mileage { get; set; }
        [Required(ErrorMessage ="Proszę wprowadzić stan techniczny pojazdu.")]
        public bool IsBroken { get; set; }

        [Required(ErrorMessage ="Podaj markę pojazdu.")]
        public string Brand { get; set; }

        public PriceList? PriceList { get; set; }

        public int PriceListId { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
