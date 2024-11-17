using MovieTracker.Core.Enums;

namespace MovieTracker.Domain.Entities
{
    public class Movie
    {
        public long Id { get; set; }

        public string? Title { get; set; }
        
        public string? Description { get; set; }

        public MovieGenre Genre { get; set; }

        public int? Rating { get; set; }


        public DateOnly YearOfRelease { get; set; }

        public string? Director { get; set; }

        public string? Status { get; set; }
    }
}