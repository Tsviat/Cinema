using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Core.Models.Movies
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.MovieTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "10.0", ConvertValueInInvariantCulture = true)]
        public decimal Rating { get; set; }

        [Required]
        [StringLength(DataValidation.MovieImageUrlMaxLength)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.DirectorNameMaxLength)]
        public string Director { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; } = null!;


    }
}
