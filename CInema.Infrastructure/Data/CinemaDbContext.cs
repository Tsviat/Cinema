using CInema.Infrastructure.Data.Cofiguration;
using CInema.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Data
{
    public class CinemaDbContext : IdentityDbContext<ApplicationUser>
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HallConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());


            builder.Entity<ProjectionSeat>()
                .HasOne(r => r.Reservation)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ProjectionSeat>()
                .HasOne(p => p.Projection)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
  
            base.OnModelCreating(builder);
        }


        

        

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<Hall> Halls { get; set; } = null!;

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Projection> Projections { get; set; } = null!;

        public DbSet<Reservation> Reservations { get; set; } = null!;

        public DbSet<Seat> Seats { get; set; } = null!;

        public DbSet<ProjectionSeat> ProjectionsSeats { get; set; } = null!;
    }
}