namespace MT.Api.Resources
{
    public class MovieResource
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public required string Director { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public string? IMDBRef { get; set; }
    }
}