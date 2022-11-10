using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.ActorFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.ActorLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public IEnumerable<ActorMovie> ActorMovies { get; set; } = null!;
    }
}
