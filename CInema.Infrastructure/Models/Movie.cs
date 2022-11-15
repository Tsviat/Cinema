using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.MovieTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.DirectorNameMaxLength)]
        public string Director { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.MovieImageUrlMaxLength)]
        public string ImageURL { get; set; } = null!;

        [Required]
        public decimal Rating { get; set; }

        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();

        public IEnumerable<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();

        public IEnumerable<Projection> Projections { get; set; } = new List<Projection>();
    }
}
