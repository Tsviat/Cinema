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
    internal class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasData(CreateHalls());
        }

        private List<Hall> CreateHalls() 
        {
            var halls = new List<Hall>();

            var hall = new Hall()
            {
                Id = 1,
                Name = "Small",
                Capacity = 30
                
            };

            halls.Add(hall);

            hall = new Hall()
            {
                Id = 2,
                Name = "Medium",
                Capacity = 50
            };

            halls.Add(hall);

            hall = new Hall()
            {
                Id = 3,
                Name = "Large",
                Capacity = 80
            };

            halls.Add(hall);


            return halls;
        }
    }
}
