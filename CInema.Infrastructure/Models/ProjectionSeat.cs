using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInema.Infrastructure.Models
{
    public class ProjectionSeat
    {
        [Key]
        public int Id { get; set; }

        public int ProjectionId { get; set; }

        [ForeignKey(nameof(ProjectionId))]
        public Projection Projection { get; set; } = null!;

        public int SeatId { get; set; }

        [ForeignKey(nameof(SeatId))]
        public Seat Seat { get; set; } = null!;

        public int ReservationId { get; set; }

        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;

        public bool IsAvailable { get; set; }
    }
}
