using System.ComponentModel.DataAnnotations.Schema;

namespace CInema.Infrastructure.Models
{
    public class ActorMovie
    {
        public int ActorId { get; set; }

        [ForeignKey(nameof(ActorId))]
        public Actor Actor { get; set; } = null!;

        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
    }
}
