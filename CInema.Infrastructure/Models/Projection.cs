using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CInema.Infrastructure.Models
{
    public class Projection
    {
        [Key]
        public int Id { get; set; }
       
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        [Required]
        public Movie Movie { get; set; } = null!;

        public int HallId { get; set; }

        [ForeignKey(nameof(HallId))]
        [Required]
        public Hall Hall { get; set; } = null!;

        [Required]
        public DateTime StartMovie { get; set; }

        public IEnumerable<Seat> Seats { get; set; } = new List<Seat>();
    }
}
