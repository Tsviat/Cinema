using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CInema.Infrastructure.Models
{
    public class Reservation
    {
        [Required]
        public string ApplicationUserId { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUserId))]
        [Required]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        public int ProjectionId { get; set; }

        [ForeignKey(nameof(ProjectionId))]
        [Required]
        public Projection Projection { get; set; } = null!;

        [Required]
        public IEnumerable<Seat> Seats { get; set; } = new List<Seat>();
    }
}
