using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CInema.Infrastructure.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUserId))]
        [Required]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        public int ProjectionId { get; set; }

        [ForeignKey(nameof(ProjectionId))]
        [Required]
        public Projection Projection { get; set; } = null!;

        
    }
}
