using Microsoft.EntityFrameworkCore;

namespace TodoAPI
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}