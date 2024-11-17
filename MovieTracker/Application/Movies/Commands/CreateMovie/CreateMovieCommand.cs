using MediatR;
using MovieTracker.Core.Enums;
using MovieTracker.Domain.DTOs.Responses.Movie;

namespace MovieTracker.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommand : IRequest<CreateMovieDto>
    {
        public CreateMovieCommand(
                    string title,
                    string description,
                    MovieGenre genre,
                    int rating,
                    DateOnly yearOfRelease,
                    string? director,
                    string? status)
        {
            Title = title;
            Description = description;
            Genre = genre;
            Rating = rating;
            YearOfRelease = yearOfRelease;
            Director = director;
            Status = status;
        }

        public string? Title { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public MovieGenre? Genre { get; }
        public DateOnly YearOfRelease { get; set; }
        public string? Director { get; set; }
        public string? Status { get; set; }
    }
}