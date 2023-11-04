using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTracker.Data.Data
{
    public enum MItemType
    {
        Movie,
        TVShow
    }

    [Table("MItems")]
    public class MItem
    {
        [Key]
        [DatabaseGenerat‌​ed(DatabaseGeneratedOption.Identity)]
        public long MItemID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public MItemType Type { get; set; }

        [Required]
        [MaxLength(10)]
        public string Watched { get; set; }

        [MaxLength(10)]
        public string WatchPriority { get; set; }


        public string BuildSearchTerms() => $"{MItemID} {Title} {Type} {Watched} {WatchPriority}".ToLower();
    }
}
