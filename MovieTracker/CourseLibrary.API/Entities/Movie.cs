using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTracker.API.Entities
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        [ForeignKey("WatchlistId")]
        public Watchlist Watchlist { get; set; } = null!;

        public Guid WatchlistId { get; set; }
    }
}