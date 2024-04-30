using AutoMapper;

namespace TT.Api.Profiles;
public class TodoListProfile : Profile
{
    public TodoListProfile()
    {
        CreateMap<Entities.TodoList, Models.TodoListDto>()
            .ForMember(dest => dest.Title, opt => 
                opt.MapFrom(src => $"{src.Title}"))
            ////.ForMember(dest => dest.Age, opt => 
            ////    opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
    }
}