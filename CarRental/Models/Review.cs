using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Wprowadź opinię o samochodzie. Maksymalnie 200 znaków.")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Podaj ocene w skali 1-5.")]
        [Range(1,5)]
        public int Rating { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }
    }
}
