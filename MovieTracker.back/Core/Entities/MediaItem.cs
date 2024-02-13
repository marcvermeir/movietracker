using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class MediaItem : IEntity
    {
        //TODO: add attributes like MaxLength ..

        #region Properties

        public enum MediaTypeEnum
        {
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

        public DateOnly YearOfRelease { get; set; }

        public PriorityEnum Priority { get; set; }

        public MediaTypeEnum MediaType { get; set; }

        public DateOnly? Consumed { get; set; }

        //TODO: >>> add relation with Director 

        #endregion
    }
}