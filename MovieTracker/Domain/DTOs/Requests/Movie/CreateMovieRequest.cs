using MovieTracker.Core.Enums;

namespace MovieTracker.Domain.DTOs.Requests.Movie
{
    public class CreateMovieRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre Genre { get; set; }
        public int? Rating { get; set; }


        public DateOnly YearOfRelease { get; set; }

        public string? Director { get; set; }

        public string? Status { get; set; }
    }
}
