using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.GenreNameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
