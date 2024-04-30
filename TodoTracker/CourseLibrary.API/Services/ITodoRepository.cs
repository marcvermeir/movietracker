using TT.Api.Entities;

namespace TT.Api.Services;

public interface ITodoRepository
{
    Task<IEnumerable<TodoItem>> GetTodoItemsAsync(Guid todoItemId);
    Task<TodoItem> GetTodoItemAsync(Guid todoListId, Guid todoItemId);
    void AddTodoItem(Guid authorId, TodoItem course);
    void UpdateTodoItem(TodoItem todoItem);
    void DeleteTodoItem(TodoItem todoItem);
    
    Task<IEnumerable<TodoList>> GetTodoListsAsync();
    Task<TodoList> GetTodoListAsync(Guid todoListId);
    Task<IEnumerable<TodoList>> GetTodoListsAsync(IEnumerable<Guid> todoListIds);
    void AddTodoList(TodoList todoList);
    void DeleteTodoList(TodoList todoList);
    void UpdateTodoList(TodoList todoList);
    Task<bool> TodoListExistsAsync(Guid todoListId);
    
    Task<bool> SaveAsync();
}