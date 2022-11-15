using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CInema.Infrastructure.Models
{
    public class Seat
    {
        [Key]
        
        public int Id { get; set; }

        
        [Required]
        public int Number { get; set; }

        [Required]
        public int HallId { get; set; }

        [Required]
        [ForeignKey(nameof(HallId))]
        public Hall Hall { get; set; } = null!;

        public IEnumerable<ProjectionSeat> ProjectionSeats { get; set; } = new List<ProjectionSeat>();
    }
}
