using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("Watchlists")]
    public class Watchlist : IEntity
    {
        #region Properties

        [Key]
        public long Id { get; set; }

        //TODO: MaxLength
        public required string Title { get; set; }

        //TODO: MaxLength
        public string? Description { get; set; }

        public ICollection<MediaItem> MediaItems { get; } = new List<MediaItem>();

        #endregion
    }
}