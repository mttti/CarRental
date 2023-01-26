using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public bool? IsReviewed { get; set; }= false;
        public bool? IsReported { get; set; }= false;

        public virtual Car? Car { get; set; }
    }
}
