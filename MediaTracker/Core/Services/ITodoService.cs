using Core.Entities;

namespace Core.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetTodos4UserAsync(int userId);
    }
}