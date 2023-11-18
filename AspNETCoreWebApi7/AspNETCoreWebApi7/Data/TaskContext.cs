using Microsoft.EntityFrameworkCore;

namespace AspNETCoreWebApi7.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; } = null!;
    }
}