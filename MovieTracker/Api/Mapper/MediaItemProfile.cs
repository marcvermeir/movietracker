using Api.Resources;
using AutoMapper;
using Core.Entities;

namespace Api.Mapper
{
    public class MediaItemProfile : Profile
    {
        public MediaItemProfile()
        {
            CreateMap<MediaItem, MediaItemResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.Title, o => o.MapFrom(t => t.Title))
                //// .ForMember(t => t.DirectorOrAuthor, o => o.MapFrom(t => t.DirectorOrAuthor))
                .ForMember(t => t.YearOfRelease, o => o.MapFrom(t => t.YearOfRelease))
                .ForMember(t => t.Priority, o => o.MapFrom(t => t.Priority))
                .ForMember(t => t.MediaType, o => o.MapFrom(t => t.MediaType))
                .ForMember(t => t.Consumed, o => o.MapFrom(t => t.Consumed))
                .ReverseMap();
        }
    }
}