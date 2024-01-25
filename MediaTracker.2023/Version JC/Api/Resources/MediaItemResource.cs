namespace Api.Resources
{
    public class MediaItemResource
    {
        #region Properties

        public enum MediaTypeEnum
        {
            Book = 1,
            Movie,
            TVShow
        }

        public enum PriorityEnum
        {
            Low = 1,
            Normal,
            High,
            Asap
        }

        public long Id { get; set; }

        public required string Title { get; set; }

        public required string DirectorOrAuthor { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public PriorityEnum Priority { get; set; }

        public MediaTypeEnum MediaType { get; set; }

        public DateOnly? Consumed { get; set; }

        #endregion

        #region Derived Properties

        public string TitleLong
        {
            get
            {
                return $"{Title} - {DirectorOrAuthor} - {YearOfRelease}";
            }
        }

        #endregion
    }
}