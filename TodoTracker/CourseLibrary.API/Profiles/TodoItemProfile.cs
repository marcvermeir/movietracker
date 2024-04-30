using AutoMapper;

namespace TT.Api.Profiles;
public class TodoItemProfile : Profile
{
    public TodoItemProfile()
    {
        CreateMap<Entities.TodoItem, Models.TodoItemDto>();
        CreateMap<Models.TodoItemForCreationDto, Entities.TodoItem>();
    }
}