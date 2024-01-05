namespace Core.Entities
{
    public class MediaItem : IEntity
    {
        #region Properties

        public enum MediaType
        {
            Book,
            Movie,
            TVShow
        }


        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorOrDirector { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public DateOnly YearWatchedOrRead { get; set; }

        public MediaType Media {  get; set; } 
        
        #endregion

        #region Ctor

        public MediaItem(int id, string title, string authorOrDirector, MediaType media)
        {
            Id = id;
            Title = title;
            AuthorOrDirector = authorOrDirector;
            Media = media;
        }

        #endregion
    }
}
