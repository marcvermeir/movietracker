using Core.Entities;

namespace Core.Interfaces
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetTodos4User(int userId);
    }
}