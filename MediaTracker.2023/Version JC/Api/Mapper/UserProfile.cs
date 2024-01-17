using Api.Resources;
using AutoMapper;
using Core.Obsolete;

namespace Api.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, MediaItemResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.Username, o => o.MapFrom(t => t.Username))
                .ReverseMap();
        }
    }
}