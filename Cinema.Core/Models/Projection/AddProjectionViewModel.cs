using CInema.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Core.Models.Projection
{
    public class AddProjectionViewModel
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int HallId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartMovie { get; set; }

        public IEnumerable<Hall> Halls { get; set; } = new List<Hall>();

        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
    }
}
