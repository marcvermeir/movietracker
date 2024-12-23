using MovieTracker.WebApi.Core.Enums;

namespace MovieTracker.WebApi.Domain.Entities.Movie
{
    public class Movie
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre Genre { get; set; }
        public int? Rating { get; set; }
    }
}