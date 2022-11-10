using CInema.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<ActorMovie> ActorsMovies { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<Hall> Halls { get; set; } = null!;

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Projection> Projections { get; set; } = null!;

        public DbSet<Reservation> Reservations { get; set; } = null!;

        public DbSet<Seat> Seats { get; set; } = null!;
    }
}