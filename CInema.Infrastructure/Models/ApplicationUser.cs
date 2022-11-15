using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CInema.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public bool IsAdmin { get; set; } = false;

        public IEnumerable<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
