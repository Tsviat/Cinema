using Cinema.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int ReleaseDate { get; set; }

        [Required]
        public decimal Rating { get; set; }

        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        public IEnumerable<Projection> Projections { get; set; } = new List<Projection>();
    }
}
