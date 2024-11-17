using MovieTracker.Core.Enums;

namespace MovieTracker.Domain.Entities
{
    public class Movie
    {
        public Movie(string? title, string? description, MovieGenre? genre, int? rating, DateOnly yearOfRelease, string? director, string? status)
        {
            Title = title;
            Description = description;
            Genre = (MovieGenre)genre;
            Rating = rating;
            YearOfRelease = yearOfRelease;
            Director = director;
            Status = status;
        }

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