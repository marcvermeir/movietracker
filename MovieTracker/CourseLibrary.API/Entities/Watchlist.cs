using System.ComponentModel.DataAnnotations;

namespace MovieTracker.API.Entities
{
    public class Watchlist
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}