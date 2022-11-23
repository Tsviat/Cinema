using Cinema.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(DataValidation.UserFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.UserLastNameMaxLength)]
        public string LastName { get; set; } = null!;
        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
