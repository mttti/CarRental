using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class CarDefect
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadź opis usterki. Maksymalnie 200 znaków.")]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public string UserName { get; set; }
        public int OrderId { get; set; }

        public bool? IsSolved { get; set; }= false;
    }
}
