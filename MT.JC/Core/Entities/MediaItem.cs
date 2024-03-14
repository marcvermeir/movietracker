using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("MediaItems")]
    public class MediaItem : IEntity
    {
        #region Properties

        public enum MediaTypeEnum
        {
            Movie,
            TVShow,
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

        [ForeignKey("Watchlist")]
        public long WatchlistId { get; set; } // Required foreign key property

        public required Watchlist Watchlist { get; set; }

        // public Blog Blog { get; set; } = null!; // Required reference navigation to principal

        #endregion
    }
}