using CInema.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInema.Infrastructure.Data.Cofiguration
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
               .HasData
               (new Genre()
               {
                   Id = 1,
                   Name = "Action"
               },
               new Genre()
               {
                   Id = 2,
                   Name = "Comedy"
               },
               new Genre()
               {
                   Id = 3,
                   Name = "Drama"
               },
               new Genre()
               {
                   Id = 4,
                   Name = "Horror"
               },
               new Genre()
               {
                   Id = 5,
                   Name = "Romantic"
               },
               new Genre() 
               {
                    Id = 6,
                    Name = "Crime"
               },
               new Genre() 
               {
                    Id = 7,
                    Name = "Adventure"
               },
               new Genre() 
               {
                    Id = 8,
                    Name = "Western"
               },
               new Genre() 
               {
                    Id = 9,
                    Name = "Fantasy"
               },
               new Genre() 
               {
                    Id = 10,
                    Name = "Sport"
               }
               );
        }
    }
}
