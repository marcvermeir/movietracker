using System.ComponentModel.DataAnnotations;

namespace TT.Api.Entities;

public class TodoList
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

    public TodoList(string title)
    {
        Title = title;
    }
}