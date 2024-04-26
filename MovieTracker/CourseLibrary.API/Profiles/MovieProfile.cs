using AutoMapper;

namespace MovieTracker.API.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<Entities.Movie, Models.MovieDto>();
        CreateMap<Models.MovieForCreationDto, Entities.Movie>();
    }
}