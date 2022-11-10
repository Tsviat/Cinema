using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class Seat
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}
