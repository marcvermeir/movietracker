using Api.Resources;
using AutoMapper;
using Core.Entities;

namespace Api.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.Username, o => o.MapFrom(t => t.Username))
                .ReverseMap();
        }
    }
}