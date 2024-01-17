using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class MediaItem : IEntity
    {
        #region Properties

        public enum MediaTypeEnum
        {
            Book,
            Movie,
            TVShow
        }

        public enum PriorityEnum
        {
            Low,
            Normal,
            High,
            Asap
        }

        [Key]
        public long Id { get; set; }

        //TODO: MaxLength
        public required string Title { get; set; }

        //TODO: MaxLength
        public required string DirectorOrAuthor { get; set; }

        public DateOnly YearOfRelease { get; set; }

        public PriorityEnum Priority { get; set; }

        public MediaTypeEnum MediaType { get; set; }

        public DateOnly? Consumed { get; set; }

        #endregion
    }
}
