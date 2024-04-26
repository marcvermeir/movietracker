using AutoMapper;

namespace MovieTracker.API.Profiles;

public class WatchlistProfile : Profile
{
    public WatchlistProfile()
    {
        CreateMap<Entities.Watchlist, Models.WatchlistDto>()
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => $"{src.Title}"));
          //.ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge())

    }
}