using CInema.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CInema.Infrastructure.Data.Cofiguration
{
    internal class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasData(CreateSeats());
        }

        private List<Seat> CreateSeats() 
        {
            var seats = new List<Seat>();
            int count = 1;

            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    

                    var seat = new Seat
                    {
                        Id = count,                       
                        Number = col,
                        HallId = 1,
                        
                    };

                    seats.Add(seat);
                    count++;
                }
            }
            return seats;
        }
    }
}
