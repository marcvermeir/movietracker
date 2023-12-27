namespace Core.Entities
{
    public class MediaItem : IEntity
    {
        #region Properties

        public int Id { get; set; }

        public required string Title { get; set; }

        public required string AuthorOrDirector { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public DateOnly YearWatchedOrRead { get; set; }

        #endregion
    }
}
