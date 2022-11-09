using Cinema.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInema.Infrastructure.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(DataValidation.Genre.NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
