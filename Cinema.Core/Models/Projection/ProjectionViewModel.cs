using CInema.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Models.Projection
{
    public class ProjectionViewModel
    {
        public int Id { get; set; }

        [Required]
        public Movie Movie { get; set; } = null!;

       

        [Required]
        public string Hall { get; set; } = null!;

        [Required]
        [DataType(DataType.Time)]
        public DateTime StartMovie { get; set; }
    }
}
