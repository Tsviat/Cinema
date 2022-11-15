using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class Hall
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.HallNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        public Projection Projections { get; set; } = null!;

        public IEnumerable<Seat> Seats { get; set; } = new List<Seat>();
    }
}
