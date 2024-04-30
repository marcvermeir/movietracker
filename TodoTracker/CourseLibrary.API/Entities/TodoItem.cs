using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TT.Api.Entities;

public class TodoItem
{
    [Key]
    public Guid Id { get; set; }
     
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [MaxLength(1500)]
    public string? Description { get; set; }

    [ForeignKey("TodoListId")]
    public TodoList TodoList { get; set; } = null!;

    public Guid TodoListId { get; set; }

    public TodoItem(string title)
    {
        Title = title; 
    }
}