namespace AspNETCoreWebApi7.Models
{
    public class Task
    {
        public long Id { get; set; }

        public required string Title { get; set; }

        public string? Notes { get; set; }

        public Task(string title) 
        {
            Title = title;
        }
    }
}
